using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class SwitchView : UserControl
    {
        private SwitchState state = SwitchState.OFF;
        private RobotCtrl.Switch rswitch;
        public SwitchView()
        {
            InitializeComponent();
        }

        private void setState(SwitchState state)
        {
            this.state = state;
            switch (this.state)
            {
                case SwitchState.ON:
                    pictureBox.Image = Resource.SwitchOn;
                    break;
                case SwitchState.OFF:
                    pictureBox.Image = Resource.SwitchOff;
                    break;
                default:
                    throw new ArgumentException("Tried to set Switch to illegal state.");
            }
        }

        public void setSwitch(RobotCtrl.Switch rswitch)
        {
            this.rswitch = rswitch;
            rswitch.SwitchStateChanged += Rswitch_SwitchStateChanged;
        }

        private void Rswitch_SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            if (InvokeRequired)
            {

                Invoke(new EventHandler<RobotCtrl.SwitchEventArgs>(Rswitch_SwitchStateChanged), sender, e);
            }
            else
            {
                this.setState(e.SwitchEnabled ? SwitchState.ON : SwitchState.OFF);
            }
        }

        private enum SwitchState { ON, OFF }
    }
}