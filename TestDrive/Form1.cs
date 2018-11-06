using RobotCtrl;
using RobotView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Drive dr1 = new Drive();
            runLineView1.Drive = dr1;
            runTurnView1.Drive = dr1;
            runArcView1.Drive = dr1;
            
            

            runLineView1.Speed = commonRunParameters1.Speed;
            runLineView1.Acceleration = commonRunParameters1.Acceleration;

            runTurnView1.Speed = commonRunParameters1.Speed;
            runTurnView1.Acceleration = commonRunParameters1.Acceleration;

            runArcView1.Speed = commonRunParameters1.Speed;
            runArcView1.Acceleration = commonRunParameters1.Acceleration;

            commonRunParameters1.SpeedChanged += (sender, e) => runLineView1.Speed = commonRunParameters1.Speed;
            commonRunParameters1.AccelerationChanged += (sender, e) => runLineView1.Acceleration = commonRunParameters1.Acceleration;

            commonRunParameters1.SpeedChanged += (sender, e) => runTurnView1.Speed = commonRunParameters1.Speed;
            commonRunParameters1.AccelerationChanged += (sender, e) => runTurnView1.Acceleration = commonRunParameters1.Acceleration;

            commonRunParameters1.SpeedChanged += (sender, e) => runArcView1.Speed = commonRunParameters1.Speed;
            commonRunParameters1.AccelerationChanged += (sender, e) => runArcView1.Acceleration = commonRunParameters1.Acceleration;
        }


    }
}