using System;
using System.Threading;
using System.Windows.Forms;
using RobotCtrl;

namespace DriveServer
{
    public class Driver
    {
        private LogServer httpLogServer;
        private Thread httpLogServerThread;
        private Thread logThread;
        private Robot robot;
        private TextBox tbLog;
        private Log positionLogger;


        public Driver(Robot robot, Thread httpLogServerThread, LogServer httpLogServer,
            TextBox tblog)
        {
            this.robot = robot;
            this.positionLogger = new Log(this.robot);
            this.httpLogServerThread = httpLogServerThread;
            this.httpLogServer = httpLogServer;
            this.tbLog = tblog;
        }


        private void SetLabel(string log)
        {
            tbLog.Text += log.ToString() + Environment.NewLine;
        }

        public delegate void AddLog(string log);

        public void Drive()
        {
            this.logThread = new Thread(positionLogger.Run); ;
            this.logThread.Start();

            foreach (Command command in Command.readCommands())
            {
                command.Drive(this.robot);
                tbLog.BeginInvoke(new AddLog(SetLabel), new object[] { command.ToString() + " started" });
                while (!this.robot.Drive.Done)
                {
                    Thread.Sleep(100);
                };
            }

            this.logThread.Abort();
            this.httpLogServerThread?.Abort();
            httpLogServerThread = new Thread(httpLogServer.Run);
            this.httpLogServerThread.Start();
        }


        public void httpServerLogEvent(object sender, EventArgs e)
        {
            if (tbLog.InvokeRequired)
            {
                tbLog.BeginInvoke(new Driver.AddLog(SetLabel), new object[] { sender.ToString() });
            }
        }

    }
}