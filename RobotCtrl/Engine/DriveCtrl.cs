﻿//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: MotorCtrl.cs 973 2015-11-10 13:12:03Z zajost $
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RobotCtrl
{

    public class DriveCtrl : IDisposable
    {

        #region members
        private int ioAddress;
        #endregion


        #region constructor & destructor
        public DriveCtrl(int IOAddress)
        {
            this.ioAddress = IOAddress;
            Reset();
        }

        public void Dispose()
        {
            Reset();
        }
        #endregion


        #region properties
        /// <summary>
        /// Schaltet die Stromversorgung der beiden Motoren ein oder aus.
        /// </summary>
        public bool Power
        {
            set { DriveState = (value) ? DriveState | 0x03 : DriveState & ~0x03; }
        }


        /// <summary>
        /// Liefert den Status ob der rechte Motor ein-/ausgeschaltet ist bzw. schaltet den rechten Motor ein-/aus.
        /// Die Information dazu steht im Bit0 von DriveState.
        /// </summary>
        public bool PowerRight
        {
            get { return ~(this.DriveState | ~(1 << 0)) == 0;  }
            set { this.DriveState = value ? this.DriveState | (1 << 0) : this.DriveState & ~(1 << 0); } 
        }


        /// <summary>
        /// Liefert den Status ob der linke Motor ein-/ausgeschaltet ist bzw. schaltet den linken Motor ein-/aus.
        /// </summary>
        public bool PowerLeft
        {
            get { return ~(this.DriveState | ~(1 << 1)) == 0; }
            set { this.DriveState = value ? this.DriveState | (1 << 1) : this.DriveState & ~(1 << 1); }
        }


        /// <summary>
        /// Bietet Zugriff auf das Status-/Controlregister
        /// </summary>
        public int DriveState
        {
            get { return IOPort.Read(ioAddress); } 
            set { IOPort.Write(ioAddress, value); } 
        }
        #endregion


        #region methods
        /// <summary>
        /// Setzt die beiden Motorencontroller (LM629) zurück, 
        /// indem kurz die Reset-Leitung aktiviert wird.
        /// </summary>
        public void Reset()
        {
            this.DriveState = 0;
            Thread.Sleep(5);
            this.DriveState = 1 << 7;
            Thread.Sleep(5);
            this.DriveState = 0;
        }
        #endregion

    }
}
