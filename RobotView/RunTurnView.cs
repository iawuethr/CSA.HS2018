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
    public partial class RunTurnView : UserControl
    {
        public RunTurnView()
        {
            InitializeComponent();
           Button btnStart = new Button();

        }

        public Drive Drive { get; set; }
        public float Speed { get; set; }
        public float Acceleration { get; set; }

        public float Angle
        {
            set { numericUpDown1.Value = (decimal)value; }
            get { return (float)numericUpDown1.Value; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Drive.RunTurn(Angle, Speed, Acceleration);
        }

        private void buttonChangeAngle_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)numericUpDown1.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                numericUpDown1.Value = (int)nk.Number;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Angle = -Angle;
        }
    }
}