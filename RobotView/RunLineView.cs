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
    public partial class RunLineView : UserControl
    {
        public RunLineView()
        {
            InitializeComponent();
           Button btnStart = new Button();
                        
        }

        public Drive Drive { get; set; }
        public float Speed { get; set; }
        public float Acceleration { get; set; }

        public float Length
        {
            set { numericUpDown1.Value = (decimal) value; }
            get { return (float) numericUpDown1.Value / 1000; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Drive.RunLine(Length, Speed, Acceleration);
        }

        private void buttonChangeLength_Click(object sender, EventArgs e)
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
            Length = -Length;
        }

      
    }
}