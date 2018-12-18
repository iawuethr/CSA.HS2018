using RobotCtrl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DriveServer
{
    public partial class Form1 : Form
    {
        private int port = 1819;
        private int httpPort = 8080;
        private Server tcpServer;
        private Robot robot;
        private Thread driveThread;
        private Driver driver;
        private Thread tcpThread;
        LogServer httpLogServer;
        private Thread httpLogServerThread;



        public Form1()
        {
            InitializeComponent();

            robot = new Robot();
            robot.Drive.Power = true;
            this.init();
        }

        private void init()
        {
            httpLogServer = new LogServer(httpPort);
            httpLogServerThread = new Thread(httpLogServer.Run);

            driver = new Driver(robot, this.httpLogServerThread, this.httpLogServer, this.tbLog);

            tcpServer = new DriveServer.Server(port, httpLogServerThread, driver);
            tcpThread = new Thread(tcpServer.Run);

            tcpServer.logEvent += driver.httpServerLogEvent;


            tcpThread.Start();
        }

        private void ResetThreads()
        {
            driveThread = new Thread(driver.Drive);
            tcpThread = new Thread(tcpServer.Run);
        }





        protected override void OnClosing(CancelEventArgs e)
        {
            this.robot.Drive.Power = false;
            this.robot.Dispose();
            this.tcpThread?.Abort();
            this.driveThread?.Abort();
            this.httpLogServerThread?.Abort();
            base.OnClosing(e);
        }
    }
}
