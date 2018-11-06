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
    public partial class SwitchView : UserControl
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
                    // pictureBox1.Image = Images.SwitchOn;  
                    pictureBox1.Invoke(new Action(changeImageOn));
                }
                else
                {
                    // pictureBox1.Image = Images.SwitchOff;
                    pictureBox1.Invoke(new Action(changeImageOff));
                }
                
            }
        }
        public void changeImageOn()
        {
            pictureBox1.Image = Images.SwitchOn;
        }
        public void changeImageOff()
        {
            pictureBox1.Image = Images.SwitchOff;
        }


        public Switch Schalter
        {
            get
            {
                return schalter;
            }

            set
            {
                schalter = value;
                if (value != null)
                {
                    schalter.SwitchStateChanged += (sender, e) => State = e.SwitchEnabled;
                    
                }
            }
        }

        private Switch schalter;

        public SwitchView()
        {
            InitializeComponent();
            State = false;
        }

        
    }
}