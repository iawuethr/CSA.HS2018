namespace RobotView
{
    partial class RunArcView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonChangeRadius = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.buttonChangeAngle = new System.Windows.Forms.Button();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "RunArc";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.Text = "Radius (+ mm)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "+/-";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChangeRadius
            // 
            this.buttonChangeRadius.Location = new System.Drawing.Point(389, 20);
            this.buttonChangeRadius.Name = "buttonChangeRadius";
            this.buttonChangeRadius.Size = new System.Drawing.Size(72, 33);
            this.buttonChangeRadius.TabIndex = 3;
            this.buttonChangeRadius.Text = "...";
            this.buttonChangeRadius.Click += new System.EventHandler(this.buttonChangeRadius_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(467, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 71);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(283, 20);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(100, 28);
            this.numericUpDownRadius.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 33);
            this.label3.Text = "Angle (+/- degrees)";
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(283, 58);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(100, 28);
            this.numericUpDownAngle.TabIndex = 13;
            // 
            // buttonChangeAngle
            // 
            this.buttonChangeAngle.Location = new System.Drawing.Point(389, 58);
            this.buttonChangeAngle.Name = "buttonChangeAngle";
            this.buttonChangeAngle.Size = new System.Drawing.Size(72, 33);
            this.buttonChangeAngle.TabIndex = 14;
            this.buttonChangeAngle.Text = "...";
            this.buttonChangeAngle.Click += new System.EventHandler(this.buttonChangeAngle_Click);
            // 
            // radioLeft
            // 
            this.radioLeft.Checked = true;
            this.radioLeft.Location = new System.Drawing.Point(283, 0);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(100, 20);
            this.radioLeft.TabIndex = 15;
            this.radioLeft.Text = "Left";
            this.radioLeft.Click += new System.EventHandler(this.radioLeft_Click);
            // 
            // radioRight
            // 
            this.radioRight.Location = new System.Drawing.Point(389, 0);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(100, 20);
            this.radioRight.TabIndex = 16;
            this.radioRight.Text = "Right";
            this.radioRight.Click += new System.EventHandler(this.radioRight_Click);
            // 
            // RunArcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radioRight);
            this.Controls.Add(this.radioLeft);
            this.Controls.Add(this.buttonChangeAngle);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownRadius);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.buttonChangeRadius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RunArcView";
            this.Size = new System.Drawing.Size(542, 95);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonChangeRadius;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Button buttonChangeAngle;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
    }

}
