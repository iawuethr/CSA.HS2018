using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace DriveServer
{
    class Server
    {
        TcpListener tcpListener;
        public event EventHandler<EventArgs> logEvent;

        private Driver driver;
        private int port;
        private Thread httpThread;
        
        public Server(int port, Thread httpThread, Driver driver)
        {
            this.port = port;
            this.httpThread = httpThread;
            this.driver = driver;
        }

        public void Run()
        {
            tcpListener.Start();
            logEvent?.Invoke("TCP Server UP", new EventArgs());

            while (Thread.CurrentThread.IsAlive)
            {
                bool isAlive = false;
                using (TcpClient tcpClient = tcpListener.AcceptTcpClient())
                {
                    if (tcpClient.ReceiveBufferSize > 0)
                    {
                        StreamReader tcpReader = new StreamReader(tcpClient.GetStream());
                        StreamWriter tcpWriter = new StreamWriter(tcpClient.GetStream());

                        string request = tcpReader.ReadLine();

                        logEvent?.Invoke(request, new EventArgs());

                        if (httpThread != null && httpThread.IsAlive) {
                            httpThread.Abort();
                        }

                        Command.newCommand(Command.ParseCommand(request));

                        if (request.StartsWith("Start"))
                        {
                            isAlive = false;
                        } else
                        {
                            isAlive = true;
                        }

                        tcpWriter.WriteLine("OK");
                        tcpWriter.Flush();
                        tcpWriter.Close();
                        tcpReader.Close();

                    
                    }
                }

                if (!isAlive)
                {
                    Thread driveThread = new Thread(new ThreadStart(driver.Drive));
                    driveThread.Start();
                    driveThread.Join();
                    Command.createFile();
                }
            }
        }
    }
}
