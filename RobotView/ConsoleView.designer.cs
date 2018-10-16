namespace RobotView
{
    partial class ConsoleView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LEDView = new RobotView.LEDView();
            this.SuspendLayout();
            // 
            // LEDView
            // 
            this.LEDView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDView.Location = new System.Drawing.Point(0, 0);
            this.LEDView.Name = "LEDView";
            this.LEDView.Size = new System.Drawing.Size(150, 150);
            this.LEDView.TabIndex = 1;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.LEDView);
            this.Name = "ConsoleView";
            this.Click += new System.EventHandler(this.ConsoleView_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private LEDView LEDView;
    }
}
