using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text;
    using System.IO;
using System.Threading;
namespace DriveServer
{
    public class LogServer
    {
        private int port;
        private TcpListener tcpListener;

        public LogServer(int port)
        {
            this.port = port;

            tcpListener = new TcpListener(IPAddress.Any, this.port);
        }

        public void Run()
        {
            tcpListener.Start();

            while (Thread.CurrentThread.IsAlive)
            {
                using (TcpClient tcpClient = tcpListener.AcceptTcpClient())
                {
                    using (NetworkStream networkStream = tcpClient.GetStream())
                    {
                        StreamReader tcpReader = new StreamReader(tcpClient.GetStream());
                        StreamWriter tcpWriter = new StreamWriter(tcpClient.GetStream());

                        string request = tcpReader.ReadLine();

                        StringBuilder sb = new StringBuilder();

                        sb.AppendLine(@"HTTP/1.1 200 OK");
                        sb.AppendLine(@"Content-Type: text/plain");
                        sb.AppendLine();
                        using (StreamReader logReader = new StreamReader(Log.FilePath))
                        {
                            sb.AppendLine(logReader.ReadToEnd());
                        }

                        tcpWriter.WriteLine(sb.ToString());
                        tcpWriter.Flush();
                        tcpWriter.Close();
                        tcpReader.Close();
                    }
                }
            }
        }
    }
}
