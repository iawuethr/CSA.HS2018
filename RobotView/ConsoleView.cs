using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotConsole roboCo;
        public RobotConsole RoboCo
        {
            get
            {
                return roboCo;
            }

            set
            {
                roboCo = value;
                ledView1.Led = roboCo[Leds.Led1];
                ledView2.Led = roboCo[Leds.Led2];
                ledView3.Led = roboCo[Leds.Led3];
                ledView4.Led = roboCo[Leds.Led4];
                switchView1.Schalter = roboCo[Switches.Switch1];
                switchView2.Schalter = roboCo[Switches.Switch2];
                switchView3.Schalter = roboCo[Switches.Switch3];
                switchView4.Schalter = roboCo[Switches.Switch4];
                
            }
        }

        public ConsoleView()
        {
            InitializeComponent();
        }

        
    }
}