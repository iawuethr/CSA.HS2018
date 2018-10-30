using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotCtrl.RobotConsole console = new RobotCtrl.RobotConsole();
        public ConsoleView()
        {
            InitializeComponent();


        }

        public void setConsole(RobotCtrl.RobotConsole console)
        {
            this.console = console;

            this.ledView0.setLED(console[RobotCtrl.Leds.Led1]);
            this.ledView1.setLED(console[RobotCtrl.Leds.Led2]);
            this.ledView2.setLED(console[RobotCtrl.Leds.Led3]);
            this.ledView3.setLED(console[RobotCtrl.Leds.Led4]);

            this.switchView0.setSwitch(console[RobotCtrl.Switches.Switch1]);
            this.switchView1.setSwitch(console[RobotCtrl.Switches.Switch2]);
            this.switchView2.setSwitch(console[RobotCtrl.Switches.Switch3]);
            this.switchView3.setSwitch(console[RobotCtrl.Switches.Switch4]);
        }
    }
}