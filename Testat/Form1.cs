using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Testat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RobotConsole robo = new RobotConsole();
            Drive dr1 = new Drive();


            robo[Switches.Switch2].SwitchStateChanged += (sender, e) => dr1.RunLine((float)2.5, 500, 300);
        }
    }
}