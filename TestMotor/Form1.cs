using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestMotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int IOAddress = 0; // TODO enter right IOaddresses (might be more than one number)
            RobotCtrl.DriveCtrl driveCtrl = new RobotCtrl.DriveCtrl(IOAddress);
            RobotCtrl.MotorCtrl motorCtrlLeft = new RobotCtrl.MotorCtrl(IOAddress);
            RobotCtrl.MotorCtrl motorCtrlRight = new RobotCtrl.MotorCtrl(IOAddress);

            this.driveCtrlView.DriveCtrl = driveCtrl;
            this.motorCtrlViewLeft.MotorCtrl = motorCtrlRight;
            this.motorCtrlViewRight.MotorCtrl = motorCtrlLeft;

        }
    }
}