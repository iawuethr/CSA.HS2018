using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        RobotCtrl.RobotConsole console = new RobotCtrl.RobotConsole();

        public Form1()
        {
            InitializeComponent();
            this.consoleView1.setConsole(console);

            console[RobotCtrl.Switches.Switch1].SwitchStateChanged += Form1_SwitchStateChanged;
            console[RobotCtrl.Switches.Switch2].SwitchStateChanged += Form2_SwitchStateChanged;
            console[RobotCtrl.Switches.Switch3].SwitchStateChanged += Form3_SwitchStateChanged;
            console[RobotCtrl.Switches.Switch4].SwitchStateChanged += Form4_SwitchStateChanged;
        }

        private void Form1_SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            console[RobotCtrl.Leds.Led1].LedEnabled = e.SwitchEnabled;
        }

        private void Form2_SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            console[RobotCtrl.Leds.Led2].LedEnabled = e.SwitchEnabled;
        }

        private void Form3_SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            console[RobotCtrl.Leds.Led3].LedEnabled = e.SwitchEnabled;
        }

        private void Form4_SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            console[RobotCtrl.Leds.Led4].LedEnabled = e.SwitchEnabled;
        }
    }
}
