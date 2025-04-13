namespace PrinceOfPersiaTheForgottenSandsTrainer
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
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcLabel = new System.Windows.Forms.Label();
            this.InfHealthToggle = new System.Windows.Forms.CheckBox();
            this.InfRewindToggle = new System.Windows.Forms.CheckBox();
            this.InfFreezeToggle = new System.Windows.Forms.CheckBox();
            this.OneHitKillsToggle = new System.Windows.Forms.CheckBox();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel.Location = new System.Drawing.Point(69, 9);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(30, 16);
            this.ProcLabel.TabIndex = 0;
            this.ProcLabel.Text = "N/A";
            // 
            // InfHealthToggle
            // 
            this.InfHealthToggle.AutoSize = true;
            this.InfHealthToggle.Location = new System.Drawing.Point(172, 91);
            this.InfHealthToggle.Name = "InfHealthToggle";
            this.InfHealthToggle.Size = new System.Drawing.Size(281, 20);
            this.InfHealthToggle.TabIndex = 1;
            this.InfHealthToggle.Text = "GodMode (Infinite Health and One-Hit Kills)";
            this.InfHealthToggle.UseVisualStyleBackColor = true;
            this.InfHealthToggle.CheckedChanged += new System.EventHandler(this.InfHealthToggle_CheckedChanged);
            // 
            // InfRewindToggle
            // 
            this.InfRewindToggle.AutoSize = true;
            this.InfRewindToggle.Location = new System.Drawing.Point(172, 131);
            this.InfRewindToggle.Name = "InfRewindToggle";
            this.InfRewindToggle.Size = new System.Drawing.Size(173, 20);
            this.InfRewindToggle.TabIndex = 1;
            this.InfRewindToggle.Text = "Unlimited Rewind Points";
            this.InfRewindToggle.UseVisualStyleBackColor = true;
            this.InfRewindToggle.CheckedChanged += new System.EventHandler(this.InfRewindToggle_CheckedChanged);
            // 
            // InfFreezeToggle
            // 
            this.InfFreezeToggle.AutoSize = true;
            this.InfFreezeToggle.Location = new System.Drawing.Point(172, 168);
            this.InfFreezeToggle.Name = "InfFreezeToggle";
            this.InfFreezeToggle.Size = new System.Drawing.Size(202, 20);
            this.InfFreezeToggle.TabIndex = 1;
            this.InfFreezeToggle.Text = "Freeze Time Never Runs Out";
            this.InfFreezeToggle.UseVisualStyleBackColor = true;
            this.InfFreezeToggle.CheckedChanged += new System.EventHandler(this.InfFreezeToggle_CheckedChanged);
            // 
            // OneHitKillsToggle
            // 
            this.OneHitKillsToggle.AutoSize = true;
            this.OneHitKillsToggle.Location = new System.Drawing.Point(172, 208);
            this.OneHitKillsToggle.Name = "OneHitKillsToggle";
            this.OneHitKillsToggle.Size = new System.Drawing.Size(101, 20);
            this.OneHitKillsToggle.TabIndex = 1;
            this.OneHitKillsToggle.Text = "One-Hit Kills";
            this.OneHitKillsToggle.UseVisualStyleBackColor = true;
            this.OneHitKillsToggle.CheckedChanged += new System.EventHandler(this.OneHitKillsToggle_CheckedChanged);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(13, 293);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(86, 23);
            this.InfoBtn.TabIndex = 2;
            this.InfoBtn.Text = "View Note";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 328);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.OneHitKillsToggle);
            this.Controls.Add(this.InfFreezeToggle);
            this.Controls.Add(this.InfRewindToggle);
            this.Controls.Add(this.InfHealthToggle);
            this.Controls.Add(this.ProcLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 375);
            this.MinimumSize = new System.Drawing.Size(550, 375);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Prince of Persia: The Forgotten Sands Trainer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.CheckBox InfHealthToggle;
        private System.Windows.Forms.CheckBox InfRewindToggle;
        private System.Windows.Forms.CheckBox InfFreezeToggle;
        private System.Windows.Forms.CheckBox OneHitKillsToggle;
        private System.Windows.Forms.Button InfoBtn;
    }
}

