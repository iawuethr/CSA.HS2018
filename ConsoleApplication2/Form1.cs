using RobotCtrl;
using RobotView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveCtrl dc1 = new DriveCtrl(0xF330);
            MotorCtrl motorCtrlLeft = new MotorCtrl(0xF328);
            MotorCtrl motorCtrlRight = new MotorCtrl(0xF320);

            if (dc1 != null)
            {
                driveCtrlView1.DriveCtrl = dc1;
                dc1.Power = true;
               
            }

            if (motorCtrlLeft != null)
            {
                motorCtrlViewLeft.MotorCtrl = motorCtrlLeft;
                
                
            }

            if (motorCtrlRight != null)
            {
                motorCtrlViewRight.MotorCtrl = motorCtrlRight;
            }

        }
    }
}