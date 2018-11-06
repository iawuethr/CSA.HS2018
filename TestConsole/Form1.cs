using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            RobotConsole rc1 = new RobotConsole();
            consoleView1.RoboCo = rc1;
            if (rc1 != null)
            {

                rc1[Switches.Switch1].SwitchStateChanged += (sender, e) => rc1[Leds.Led1].LedEnabled = e.SwitchEnabled;
                rc1[Switches.Switch2].SwitchStateChanged += (sender, e) => rc1[Leds.Led2].LedEnabled = e.SwitchEnabled;
                rc1[Switches.Switch3].SwitchStateChanged += (sender, e) => rc1[Leds.Led3].LedEnabled = e.SwitchEnabled;
                rc1[Switches.Switch4].SwitchStateChanged += (sender, e) => rc1[Leds.Led4].LedEnabled = e.SwitchEnabled;
                // rc1[Leds.Led1].LedStateChanged += (sender, e) => rc1[Leds.Led1].LedEnabled = e.LedEnabled;


            }
        }
    }
}
