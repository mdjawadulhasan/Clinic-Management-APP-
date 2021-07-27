
namespace Clinic
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PendingAppProgress = new CircularProgressBar.CircularProgressBar();
            this.NextAppPr = new CircularProgressBar.CircularProgressBar();
            this.PatientsProg = new CircularProgressBar.CircularProgressBar();
            this.UserProgressBar = new CircularProgressBar.CircularProgressBar();
            this.Pendinglbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Patientlbl = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(292, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "DashBoard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 111);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(911, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(293, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(749, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // PendingAppProgress
            // 
            this.PendingAppProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PendingAppProgress.AnimationSpeed = 500;
            this.PendingAppProgress.BackColor = System.Drawing.Color.Transparent;
            this.PendingAppProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.PendingAppProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PendingAppProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PendingAppProgress.InnerMargin = 2;
            this.PendingAppProgress.InnerWidth = -1;
            this.PendingAppProgress.Location = new System.Drawing.Point(79, 199);
            this.PendingAppProgress.MarqueeAnimationSpeed = 2000;
            this.PendingAppProgress.Name = "PendingAppProgress";
            this.PendingAppProgress.OuterColor = System.Drawing.Color.Gray;
            this.PendingAppProgress.OuterMargin = -25;
            this.PendingAppProgress.OuterWidth = 26;
            this.PendingAppProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PendingAppProgress.ProgressWidth = 20;
            this.PendingAppProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PendingAppProgress.Size = new System.Drawing.Size(193, 190);
            this.PendingAppProgress.StartAngle = 270;
            this.PendingAppProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PendingAppProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PendingAppProgress.SubscriptText = ".23";
            this.PendingAppProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PendingAppProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PendingAppProgress.SuperscriptText = "°C";
            this.PendingAppProgress.TabIndex = 24;
            this.PendingAppProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PendingAppProgress.Value = 68;
            this.PendingAppProgress.Click += new System.EventHandler(this.PendingAppProgress_Click);
            // 
            // NextAppPr
            // 
            this.NextAppPr.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.NextAppPr.AnimationSpeed = 500;
            this.NextAppPr.BackColor = System.Drawing.Color.Transparent;
            this.NextAppPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.NextAppPr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextAppPr.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NextAppPr.InnerMargin = 2;
            this.NextAppPr.InnerWidth = -1;
            this.NextAppPr.Location = new System.Drawing.Point(487, 472);
            this.NextAppPr.MarqueeAnimationSpeed = 2000;
            this.NextAppPr.Name = "NextAppPr";
            this.NextAppPr.OuterColor = System.Drawing.Color.Gray;
            this.NextAppPr.OuterMargin = -25;
            this.NextAppPr.OuterWidth = 26;
            this.NextAppPr.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NextAppPr.ProgressWidth = 20;
            this.NextAppPr.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.NextAppPr.Size = new System.Drawing.Size(193, 190);
            this.NextAppPr.StartAngle = 270;
            this.NextAppPr.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NextAppPr.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.NextAppPr.SubscriptText = ".23";
            this.NextAppPr.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NextAppPr.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.NextAppPr.SuperscriptText = "°C";
            this.NextAppPr.TabIndex = 25;
            this.NextAppPr.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.NextAppPr.Value = 68;
            // 
            // PatientsProg
            // 
            this.PatientsProg.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PatientsProg.AnimationSpeed = 500;
            this.PatientsProg.BackColor = System.Drawing.Color.Transparent;
            this.PatientsProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.PatientsProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatientsProg.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PatientsProg.InnerMargin = 2;
            this.PatientsProg.InnerWidth = -1;
            this.PatientsProg.Location = new System.Drawing.Point(487, 208);
            this.PatientsProg.MarqueeAnimationSpeed = 2000;
            this.PatientsProg.Name = "PatientsProg";
            this.PatientsProg.OuterColor = System.Drawing.Color.Gray;
            this.PatientsProg.OuterMargin = -25;
            this.PatientsProg.OuterWidth = 26;
            this.PatientsProg.ProgressColor = System.Drawing.Color.Red;
            this.PatientsProg.ProgressWidth = 20;
            this.PatientsProg.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PatientsProg.Size = new System.Drawing.Size(193, 190);
            this.PatientsProg.StartAngle = 270;
            this.PatientsProg.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PatientsProg.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PatientsProg.SubscriptText = ".23";
            this.PatientsProg.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PatientsProg.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PatientsProg.SuperscriptText = "°C";
            this.PatientsProg.TabIndex = 26;
            this.PatientsProg.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PatientsProg.Value = 68;
            // 
            // UserProgressBar
            // 
            this.UserProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.UserProgressBar.AnimationSpeed = 500;
            this.UserProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.UserProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.UserProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserProgressBar.InnerMargin = 2;
            this.UserProgressBar.InnerWidth = -1;
            this.UserProgressBar.Location = new System.Drawing.Point(69, 455);
            this.UserProgressBar.MarqueeAnimationSpeed = 2000;
            this.UserProgressBar.Name = "UserProgressBar";
            this.UserProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.UserProgressBar.OuterMargin = -25;
            this.UserProgressBar.OuterWidth = 26;
            this.UserProgressBar.ProgressColor = System.Drawing.Color.Navy;
            this.UserProgressBar.ProgressWidth = 20;
            this.UserProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.UserProgressBar.Size = new System.Drawing.Size(193, 190);
            this.UserProgressBar.StartAngle = 270;
            this.UserProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UserProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.UserProgressBar.SubscriptText = ".23";
            this.UserProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UserProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.UserProgressBar.SuperscriptText = "°C";
            this.UserProgressBar.TabIndex = 27;
            this.UserProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.UserProgressBar.Value = 68;
            // 
            // Pendinglbl
            // 
            this.Pendinglbl.AutoSize = true;
            this.Pendinglbl.BackColor = System.Drawing.Color.White;
            this.Pendinglbl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendinglbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Pendinglbl.Location = new System.Drawing.Point(133, 275);
            this.Pendinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pendinglbl.Name = "Pendinglbl";
            this.Pendinglbl.Size = new System.Drawing.Size(82, 40);
            this.Pendinglbl.TabIndex = 28;
            this.Pendinglbl.Text = "Num";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.BackColor = System.Drawing.Color.White;
            this.Datelbl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Datelbl.Location = new System.Drawing.Point(547, 551);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(82, 40);
            this.Datelbl.TabIndex = 29;
            this.Datelbl.Text = "Num";
            // 
            // Patientlbl
            // 
            this.Patientlbl.AutoSize = true;
            this.Patientlbl.BackColor = System.Drawing.Color.White;
            this.Patientlbl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientlbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Patientlbl.Location = new System.Drawing.Point(547, 275);
            this.Patientlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patientlbl.Name = "Patientlbl";
            this.Patientlbl.Size = new System.Drawing.Size(82, 40);
            this.Patientlbl.TabIndex = 30;
            this.Patientlbl.Text = "Num";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.White;
            this.Userlbl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Userlbl.Location = new System.Drawing.Point(133, 525);
            this.Userlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(82, 40);
            this.Userlbl.TabIndex = 31;
            this.Userlbl.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(334, 657);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 36);
            this.label2.TabIndex = 32;
            this.label2.Text = "Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Patientlbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.Pendinglbl);
            this.Controls.Add(this.UserProgressBar);
            this.Controls.Add(this.PatientsProg);
            this.Controls.Add(this.NextAppPr);
            this.Controls.Add(this.PendingAppProgress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DasBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar PendingAppProgress;
        private CircularProgressBar.CircularProgressBar NextAppPr;
        private CircularProgressBar.CircularProgressBar PatientsProg;
        private CircularProgressBar.CircularProgressBar UserProgressBar;
        private System.Windows.Forms.Label Pendinglbl;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label label2;
    }
}