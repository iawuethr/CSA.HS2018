using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class LEDView : UserControl
    {
        private LEDState state = LEDState.OFF;
        private RobotCtrl.Led LED;

        private void setLEDState(LEDState state)
        {
            this.state = state;
            switch (this.state)
            {
                case LEDState.ON:
                    PictureLED.Image = Resource.LedOn;
                    break;
                case LEDState.OFF:
                    PictureLED.Image = Resource.LedOff;
                    break;
                default:
                    throw new ArgumentException("Tried to set LED to invalid state.");
            }
        }

        public void setLED(RobotCtrl.Led led)
        {
            this.LED = led;
            led.LedStateChanged += Led_LedStateChanged;
        }

        private void Led_LedStateChanged(object sender, RobotCtrl.LedEventArgs e)
        {
            this.setLEDState(e.LedEnabled ? LEDState.ON : LEDState.OFF);
        }

        private LEDState getLEDState()
        {
            return this.state;
        }

        public LEDView()
        {
            InitializeComponent();
        }

        private enum LEDState { ON, OFF }
    }
}