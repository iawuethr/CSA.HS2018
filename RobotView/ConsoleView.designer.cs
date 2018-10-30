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
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.switchView1 = new RobotView.SwitchView();
            this.switchView2 = new RobotView.SwitchView();
            this.switchView3 = new RobotView.SwitchView();
            this.ledView3 = new RobotView.LEDView();
            this.ledView2 = new RobotView.LEDView();
            this.ledView1 = new RobotView.LEDView();
            this.ledView0 = new RobotView.LEDView();
            this.switchView0 = new RobotView.SwitchView();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(4, 50);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(20, 20);
            this.label0.Text = "0";
            this.label0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(29, 3);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(20, 40);
            this.switchView1.TabIndex = 8;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(55, 3);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(20, 40);
            this.switchView2.TabIndex = 7;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(81, 3);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(20, 40);
            this.switchView3.TabIndex = 6;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(81, 77);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.TabIndex = 5;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(55, 77);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.TabIndex = 4;
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(29, 77);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.TabIndex = 3;
            // 
            // ledView0
            // 
            this.ledView0.Location = new System.Drawing.Point(3, 77);
            this.ledView0.Name = "ledView0";
            this.ledView0.Size = new System.Drawing.Size(20, 20);
            this.ledView0.TabIndex = 1;
            // 
            // switchView0
            // 
            this.switchView0.Location = new System.Drawing.Point(3, 3);
            this.switchView0.Name = "switchView0";
            this.switchView0.Size = new System.Drawing.Size(20, 40);
            this.switchView0.TabIndex = 2;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.switchView1);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Controls.Add(this.ledView0);
            this.Controls.Add(this.switchView0);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(105, 105);
            this.ResumeLayout(false);

        }

        #endregion
        private LEDView ledView0;
        private SwitchView switchView0;
        private LEDView ledView1;
        private LEDView ledView2;
        private LEDView ledView3;
        private SwitchView switchView3;
        private SwitchView switchView2;
        private SwitchView switchView1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
