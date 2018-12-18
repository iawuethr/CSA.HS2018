using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using RobotCtrl;

namespace DriveServer
{
    class Log
    {
        public const string FilePath = @"\temp\log.txt";
        public const string headLine = @"Team 11";

        private float[] position = new float[2];
        private Robot robot;

        public Log(Robot robot)
        {
            this.robot = robot;
        }

        public void Run()
        {
            createFile();

            while (Thread.CurrentThread.IsAlive)
            {
                PositionInfo posInfo = this.robot.Position;
                this.Write(posInfo.X, posInfo.Y);

                Thread.Sleep(100);
            }
        }

        private void Write(float positionX, float positionY)
        {
            createFile();

            using (StreamWriter streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd-hh:mm:ss.fff")};{positionX.ToString()};{positionY.ToString()}");
            }
        }

        private static void createFile()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();

                using (StreamWriter streamWriter = new StreamWriter(FilePath))
                {
                    streamWriter.WriteLine(headLine);
                }
            }
        }
    }
}
