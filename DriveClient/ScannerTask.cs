using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RobotCtrl;

namespace DriveClient
{
    // Man I wish it wasnt 3.5
    public class ScannerTask
    {

        public event EventHandler<EventArgs> scanAlert;

        private float lastDist = float.MaxValue;
        public void Run(Robot robot)
        {
            float currentDist;
            while (Thread.CurrentThread.IsAlive)
            {
                currentDist = robot.Radar.Distance;
                if (currentDist < 0.8f && lastDist >= 0.8f)
                {
                    scanAlert?.Invoke(this, new EventArgs());
                }
                lastDist = currentDist;

                Thread.Sleep(100);
            }
        }
    }
}
