using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RobotCtrl;

namespace DriveClient
{
    public class LEDTask
    {
        private int LEDid = 0;

        public void Run( Robot robot )
        {
            while (Thread.CurrentThread.IsAlive)
            {
                robot.RobotConsole[(Leds)LEDid].LedEnabled = false;

                // Do sequence 0 to 4 over and over
                LEDid++;
                LEDid %= 4;

                robot.RobotConsole[(Leds)LEDid].LedEnabled = true;
            }

            Thread.Sleep(100);
        }
    }
}
