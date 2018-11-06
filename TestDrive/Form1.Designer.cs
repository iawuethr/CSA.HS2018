namespace TestDrive
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.driveView1 = new RobotView.DriveView();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.SuspendLayout();
            // 
            // driveView1
            // 
            this.driveView1.Drive = null;
            this.driveView1.Location = new System.Drawing.Point(0, 0);
            this.driveView1.Name = "driveView1";
            this.driveView1.Size = new System.Drawing.Size(292, 289);
            this.driveView1.TabIndex = 0;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(0, 0);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(0, 0);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.driveView1);
            this.Controls.Add(this.commonRunParameters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        
        private RobotView.DriveView driveView1;
        private RobotView.CommonRunParameters commonRunParameters;
    }
}