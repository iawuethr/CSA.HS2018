using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Testat
{
    public partial class Form1 : Form
    {
        private Robot _robot = new Robot();
        private bool _isRunning = false;
        private bool _isCounting = false;
        private Thread _ledBlinkThread;
        private Thread _counterThread;
        private Thread _workerThread;
        private readonly float _margin = 0.20f;
        private int _count;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radarView1.Radar = new Radar(Constants.IORadarSensor);
            _robot.Drive.DriveCtrl.Power = true;

            _robot.RobotConsole[Switches.Switch2].SwitchStateChanged += SwitchTwoChanged;
        }

        private void LetLedBlink()
        {
            bool newState = false;
            while (_isRunning)
            {
                Thread.Sleep(500);
                newState = !newState;
                _robot.RobotConsole[Leds.Led1].LedEnabled = newState;
                _robot.RobotConsole[Leds.Led2].LedEnabled = newState;
                _robot.RobotConsole[Leds.Led3].LedEnabled = newState;
                _robot.RobotConsole[Leds.Led4].LedEnabled = newState;
            }

            _robot.RobotConsole[Leds.Led1].LedEnabled = false;
            _robot.RobotConsole[Leds.Led2].LedEnabled = false;
            _robot.RobotConsole[Leds.Led3].LedEnabled = false;
            _robot.RobotConsole[Leds.Led4].LedEnabled = false;
        }

        private void SwitchTwoChanged(object sender, SwitchEventArgs e)
        {
            if (e.SwitchEnabled)
            {
                Start();
            }
            else
            {
                Stop();
            }

        }

        private void Count()
        {
            int measuredDCount = 5b0;
            Queue<float> measuredDists = new Queue<float>() ;
            _isCounting = true;
            // Let the LED blinking
            _ledBlinkThread = new Thread(LetLedBlink);
            _ledBlinkThread.Start();
            SetLabelText("Counting...");
            float last = -(_margin + 0.01f);
            _count = 0;
            int walk = 0;
            float current = _robot.Radar.Distance;
            for (int i = 0; i < measuredDCount; i++)
            {
                measuredDists.Enqueue(current);
            }
            while (_isRunning)
            {
                walk++;
                measuredDists.Enqueue(_robot.Radar.Distance);
                if (measuredDists.Count > (measuredDCount + 1))
                {
                    measuredDists.Dequeue();
                }
                current = measuredDists.OrderByDescending(i => i).ToArray()[measuredDCount / 2];
                if (_isCounting && (walk >= measuredDCount) && (last - current <= -_margin || last - current >= _margin))
                {
                    last = current;
                    if (current <= 1)
                    {
                        _count++;
                        SetLabelText("Current count: " + _count);
                    }
                    walk = 0;
                }
                Thread.Sleep(10);
            }
        }

        private void Start()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                _workerThread = new Thread(DoWork);
                _workerThread.Start();
            }
        }

        private void Stop()
        {
            _isRunning = false;

            // So that the led blinker and counter are able to stop..
            Thread.Sleep(100);

            _robot.Drive.Stop();
            _ledBlinkThread.Abort();
            _counterThread.Abort();
            
        }

        private void WaitDriveDone(int intervalWait)
        {
            while (!_robot.Drive.Done)
            {
                if (!_isRunning)
                {
                    Stop();
                    return;
                }

                Thread.Sleep(intervalWait);
            }
        }

        private void DoWork()
        {
            // Let the counter start counting
            _counterThread = new Thread(Count);
            _counterThread.Start();

            _robot.Drive.RunLine(2.5f, 0.1f, 0.5f);
            WaitDriveDone(500);

            _isCounting = false;
            Thread.Sleep(10);
            _robot.Drive.RunTurn(180f, 0.1f, 0.5f);
            WaitDriveDone(500);
            Thread.Sleep(10);
            _isCounting = true;
            Thread.Sleep(10);

            _robot.Drive.RunLine(2.5f, 0.1f, 0.5f);
            WaitDriveDone(500);

            _isCounting = false;
            Thread.Sleep(10);
            _robot.Drive.RunTurn(180f, 0.1f, 0.5f);
            WaitDriveDone(500);
            Thread.Sleep(10);
            _isRunning = false;

            SetLabelText("Number of objects counted: " + _count);
        }

        private void SetLabelText(string text)
        {
            if(label1.InvokeRequired)
            {
                Invoke(new EventHandler((s, e) => SetLabelText(text)));
                return;
            }

            label1.Text = text;
        }
    }
}
