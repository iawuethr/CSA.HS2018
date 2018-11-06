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
    public partial class RunArcView : UserControl
    {
        public RunArcView()
        {
            InitializeComponent();
            Button btnStart = new Button();
        }

        public Drive Drive { get; set; }
        public float Speed { get; set; }
        public float Acceleration { get; set; }

        public float Angle
        {
            set { numericUpDownAngle.Value = (decimal)value; }
            get { return (float)numericUpDownAngle.Value; }
        }

        public float Radius
        {
            get { return (float)numericUpDownRadius.Value / 1000; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (radioLeft.Checked)
            {
                Drive.RunArcLeft(Radius, Angle, Speed, Acceleration);
            }
            if (radioRight.Checked)
            {
                Drive.RunArcRight(Radius, Angle, Speed, Acceleration);
            }

        }

        private void buttonChangeAngle_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)numericUpDownAngle.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                numericUpDownAngle.Value = (int)nk.Number;
            }

        }

        private void buttonChangeRadius_Click(object sender, EventArgs e)
        {
            NumberKeyboard nk = new NumberKeyboard();
            nk.Number = (float)numericUpDownRadius.Value;
            if (nk.ShowDialog() == DialogResult.OK)
            {
                numericUpDownRadius.Value = (int)nk.Number;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Angle = -Angle;
        }

        private void radioLeft_Click(object sender, EventArgs e)
        {
            radioRight.Checked = !radioLeft.Checked;
            //if (radioLeft.Checked == true)
            //{
            //    radioRight.Checked = false;
            //}
            //else
            //{
            //    radioRight.Checked = true;
            //}
        }

        private void radioRight_Click(object sender, EventArgs e)
        {
            radioLeft.Checked = !radioRight.Checked;
            //if (radioRight.Checked == true)
            //{
            //    radioLeft.Checked = false;
            //}
            //else
            //{
            //    radioLeft.Checked = true;
            //}
        }

    }
}