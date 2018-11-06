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
    public partial class LedView : UserControl
    {
        private bool state;
        public bool State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                if (state == true)
                {
                    // pictureBox1.Image = Images.LedOn;
                    pictureBox1.Invoke(new Action(changeImageOn));
                }
                else
                {
                    // pictureBox1.Image = Images.LedOff;
                    pictureBox1.Invoke(new Action(changeImageOff));
                }
                
            }
        }
        public void changeImageOn()
        {
            pictureBox1.Image = Images.LedOn;
        }
        public void changeImageOff()
        {
            pictureBox1.Image = Images.LedOff;
        }

        public Led Led
        {
            get
            {
                return led;
            }

            set
            {
                led = value;
                if (value != null)
                {
                    led.LedStateChanged += (sender, e) => State = e.LedEnabled;
                }
            }
        }

        private Led led;
        public LedView()
        {
            InitializeComponent();
            State = false;
        }

    }
}