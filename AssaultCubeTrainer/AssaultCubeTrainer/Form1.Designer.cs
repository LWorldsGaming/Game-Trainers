namespace AssaultCubeTrainer
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
            this.Health = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HealthBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Armor = new System.Windows.Forms.TextBox();
            this.ArmorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ARAmmo = new System.Windows.Forms.TextBox();
            this.ARAmmoBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SMGAmmo = new System.Windows.Forms.TextBox();
            this.SMGAmmoBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PistolAmmo = new System.Windows.Forms.TextBox();
            this.PistolAmmoBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DPistolAmmo = new System.Windows.Forms.TextBox();
            this.DPistolAmmoBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SniperAmmo = new System.Windows.Forms.TextBox();
            this.SniperAmmoBtn = new System.Windows.Forms.Button();
            this.FreezeHealth = new System.Windows.Forms.CheckBox();
            this.FreezeArmor = new System.Windows.Forms.CheckBox();
            this.FreezeARAmmo = new System.Windows.Forms.CheckBox();
            this.FreezeSMGAmmo = new System.Windows.Forms.CheckBox();
            this.FreezePistolAmmo = new System.Windows.Forms.CheckBox();
            this.FreezeDPistolAmmo = new System.Windows.Forms.CheckBox();
            this.FreezeSniperAmmo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.Location = new System.Drawing.Point(71, 13);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(30, 16);
            this.ProcLabel.TabIndex = 1;
            this.ProcLabel.Text = "N/A";
            // 
            // Health
            // 
            this.Health.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Health.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Health.Location = new System.Drawing.Point(154, 67);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(198, 22);
            this.Health.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health";
            // 
            // HealthBtn
            // 
            this.HealthBtn.Location = new System.Drawing.Point(359, 58);
            this.HealthBtn.Name = "HealthBtn";
            this.HealthBtn.Size = new System.Drawing.Size(65, 44);
            this.HealthBtn.TabIndex = 3;
            this.HealthBtn.Text = "Send";
            this.HealthBtn.UseVisualStyleBackColor = true;
            this.HealthBtn.Click += new System.EventHandler(this.HealthBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Armor";
            // 
            // Armor
            // 
            this.Armor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Armor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Armor.Location = new System.Drawing.Point(154, 123);
            this.Armor.Name = "Armor";
            this.Armor.Size = new System.Drawing.Size(198, 22);
            this.Armor.TabIndex = 2;
            // 
            // ArmorBtn
            // 
            this.ArmorBtn.Location = new System.Drawing.Point(359, 114);
            this.ArmorBtn.Name = "ArmorBtn";
            this.ArmorBtn.Size = new System.Drawing.Size(65, 44);
            this.ArmorBtn.TabIndex = 3;
            this.ArmorBtn.Text = "Send";
            this.ArmorBtn.UseVisualStyleBackColor = true;
            this.ArmorBtn.Click += new System.EventHandler(this.ArmorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "AR Ammo";
            // 
            // ARAmmo
            // 
            this.ARAmmo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ARAmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ARAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ARAmmo.Location = new System.Drawing.Point(154, 179);
            this.ARAmmo.Name = "ARAmmo";
            this.ARAmmo.Size = new System.Drawing.Size(198, 22);
            this.ARAmmo.TabIndex = 2;
            // 
            // ARAmmoBtn
            // 
            this.ARAmmoBtn.Location = new System.Drawing.Point(359, 170);
            this.ARAmmoBtn.Name = "ARAmmoBtn";
            this.ARAmmoBtn.Size = new System.Drawing.Size(65, 44);
            this.ARAmmoBtn.TabIndex = 3;
            this.ARAmmoBtn.Text = "Send";
            this.ARAmmoBtn.UseVisualStyleBackColor = true;
            this.ARAmmoBtn.Click += new System.EventHandler(this.ARAmmoBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "SMG Ammo";
            // 
            // SMGAmmo
            // 
            this.SMGAmmo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SMGAmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SMGAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SMGAmmo.Location = new System.Drawing.Point(154, 232);
            this.SMGAmmo.Name = "SMGAmmo";
            this.SMGAmmo.Size = new System.Drawing.Size(198, 22);
            this.SMGAmmo.TabIndex = 2;
            // 
            // SMGAmmoBtn
            // 
            this.SMGAmmoBtn.Location = new System.Drawing.Point(359, 223);
            this.SMGAmmoBtn.Name = "SMGAmmoBtn";
            this.SMGAmmoBtn.Size = new System.Drawing.Size(65, 44);
            this.SMGAmmoBtn.TabIndex = 3;
            this.SMGAmmoBtn.Text = "Send";
            this.SMGAmmoBtn.UseVisualStyleBackColor = true;
            this.SMGAmmoBtn.Click += new System.EventHandler(this.SMGAmmoBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pistol Ammo";
            // 
            // PistolAmmo
            // 
            this.PistolAmmo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PistolAmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PistolAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.PistolAmmo.Location = new System.Drawing.Point(154, 285);
            this.PistolAmmo.Name = "PistolAmmo";
            this.PistolAmmo.Size = new System.Drawing.Size(198, 22);
            this.PistolAmmo.TabIndex = 2;
            // 
            // PistolAmmoBtn
            // 
            this.PistolAmmoBtn.Location = new System.Drawing.Point(359, 276);
            this.PistolAmmoBtn.Name = "PistolAmmoBtn";
            this.PistolAmmoBtn.Size = new System.Drawing.Size(65, 44);
            this.PistolAmmoBtn.TabIndex = 3;
            this.PistolAmmoBtn.Text = "Send";
            this.PistolAmmoBtn.UseVisualStyleBackColor = true;
            this.PistolAmmoBtn.Click += new System.EventHandler(this.PistolAmmoBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dual-Pistol Ammo";
            // 
            // DPistolAmmo
            // 
            this.DPistolAmmo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DPistolAmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DPistolAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DPistolAmmo.Location = new System.Drawing.Point(154, 336);
            this.DPistolAmmo.Name = "DPistolAmmo";
            this.DPistolAmmo.Size = new System.Drawing.Size(198, 22);
            this.DPistolAmmo.TabIndex = 2;
            // 
            // DPistolAmmoBtn
            // 
            this.DPistolAmmoBtn.Location = new System.Drawing.Point(359, 327);
            this.DPistolAmmoBtn.Name = "DPistolAmmoBtn";
            this.DPistolAmmoBtn.Size = new System.Drawing.Size(65, 44);
            this.DPistolAmmoBtn.TabIndex = 3;
            this.DPistolAmmoBtn.Text = "Send";
            this.DPistolAmmoBtn.UseVisualStyleBackColor = true;
            this.DPistolAmmoBtn.Click += new System.EventHandler(this.DPistolAmmoBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sniper Ammo";
            // 
            // SniperAmmo
            // 
            this.SniperAmmo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SniperAmmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SniperAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SniperAmmo.Location = new System.Drawing.Point(154, 387);
            this.SniperAmmo.Name = "SniperAmmo";
            this.SniperAmmo.Size = new System.Drawing.Size(198, 22);
            this.SniperAmmo.TabIndex = 2;
            // 
            // SniperAmmoBtn
            // 
            this.SniperAmmoBtn.Location = new System.Drawing.Point(359, 378);
            this.SniperAmmoBtn.Name = "SniperAmmoBtn";
            this.SniperAmmoBtn.Size = new System.Drawing.Size(65, 44);
            this.SniperAmmoBtn.TabIndex = 3;
            this.SniperAmmoBtn.Text = "Send";
            this.SniperAmmoBtn.UseVisualStyleBackColor = true;
            this.SniperAmmoBtn.Click += new System.EventHandler(this.SniperAmmoBtn_Click);
            // 
            // FreezeHealth
            // 
            this.FreezeHealth.AutoSize = true;
            this.FreezeHealth.Location = new System.Drawing.Point(439, 69);
            this.FreezeHealth.Name = "FreezeHealth";
            this.FreezeHealth.Size = new System.Drawing.Size(71, 20);
            this.FreezeHealth.TabIndex = 5;
            this.FreezeHealth.Text = "Freeze";
            this.FreezeHealth.UseVisualStyleBackColor = true;
            this.FreezeHealth.CheckedChanged += new System.EventHandler(this.FreezeHealth_CheckedChanged);
            // 
            // FreezeArmor
            // 
            this.FreezeArmor.AutoSize = true;
            this.FreezeArmor.Location = new System.Drawing.Point(439, 124);
            this.FreezeArmor.Name = "FreezeArmor";
            this.FreezeArmor.Size = new System.Drawing.Size(71, 20);
            this.FreezeArmor.TabIndex = 5;
            this.FreezeArmor.Text = "Freeze";
            this.FreezeArmor.UseVisualStyleBackColor = true;
            this.FreezeArmor.CheckedChanged += new System.EventHandler(this.FreezeArmor_CheckedChanged);
            // 
            // FreezeARAmmo
            // 
            this.FreezeARAmmo.AutoSize = true;
            this.FreezeARAmmo.Location = new System.Drawing.Point(439, 183);
            this.FreezeARAmmo.Name = "FreezeARAmmo";
            this.FreezeARAmmo.Size = new System.Drawing.Size(71, 20);
            this.FreezeARAmmo.TabIndex = 5;
            this.FreezeARAmmo.Text = "Freeze";
            this.FreezeARAmmo.UseVisualStyleBackColor = true;
            this.FreezeARAmmo.CheckedChanged += new System.EventHandler(this.FreezeARAmmo_CheckedChanged);
            // 
            // FreezeSMGAmmo
            // 
            this.FreezeSMGAmmo.AutoSize = true;
            this.FreezeSMGAmmo.Location = new System.Drawing.Point(439, 237);
            this.FreezeSMGAmmo.Name = "FreezeSMGAmmo";
            this.FreezeSMGAmmo.Size = new System.Drawing.Size(71, 20);
            this.FreezeSMGAmmo.TabIndex = 5;
            this.FreezeSMGAmmo.Text = "Freeze";
            this.FreezeSMGAmmo.UseVisualStyleBackColor = true;
            this.FreezeSMGAmmo.CheckedChanged += new System.EventHandler(this.FreezeSMGAmmo_CheckedChanged);
            // 
            // FreezePistolAmmo
            // 
            this.FreezePistolAmmo.AutoSize = true;
            this.FreezePistolAmmo.Location = new System.Drawing.Point(439, 287);
            this.FreezePistolAmmo.Name = "FreezePistolAmmo";
            this.FreezePistolAmmo.Size = new System.Drawing.Size(71, 20);
            this.FreezePistolAmmo.TabIndex = 5;
            this.FreezePistolAmmo.Text = "Freeze";
            this.FreezePistolAmmo.UseVisualStyleBackColor = true;
            this.FreezePistolAmmo.CheckedChanged += new System.EventHandler(this.FreezePistolAmmo_CheckedChanged);
            // 
            // FreezeDPistolAmmo
            // 
            this.FreezeDPistolAmmo.AutoSize = true;
            this.FreezeDPistolAmmo.Location = new System.Drawing.Point(439, 341);
            this.FreezeDPistolAmmo.Name = "FreezeDPistolAmmo";
            this.FreezeDPistolAmmo.Size = new System.Drawing.Size(71, 20);
            this.FreezeDPistolAmmo.TabIndex = 5;
            this.FreezeDPistolAmmo.Text = "Freeze";
            this.FreezeDPistolAmmo.UseVisualStyleBackColor = true;
            this.FreezeDPistolAmmo.CheckedChanged += new System.EventHandler(this.FreezeDPistolAmmo_CheckedChanged);
            // 
            // FreezeSniperAmmo
            // 
            this.FreezeSniperAmmo.AutoSize = true;
            this.FreezeSniperAmmo.Location = new System.Drawing.Point(439, 388);
            this.FreezeSniperAmmo.Name = "FreezeSniperAmmo";
            this.FreezeSniperAmmo.Size = new System.Drawing.Size(71, 20);
            this.FreezeSniperAmmo.TabIndex = 5;
            this.FreezeSniperAmmo.Text = "Freeze";
            this.FreezeSniperAmmo.UseVisualStyleBackColor = true;
            this.FreezeSniperAmmo.CheckedChanged += new System.EventHandler(this.FreezeSniperAmmo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 441);
            this.Controls.Add(this.FreezeSniperAmmo);
            this.Controls.Add(this.FreezeDPistolAmmo);
            this.Controls.Add(this.FreezePistolAmmo);
            this.Controls.Add(this.FreezeSMGAmmo);
            this.Controls.Add(this.FreezeARAmmo);
            this.Controls.Add(this.FreezeArmor);
            this.Controls.Add(this.FreezeHealth);
            this.Controls.Add(this.SniperAmmoBtn);
            this.Controls.Add(this.DPistolAmmoBtn);
            this.Controls.Add(this.PistolAmmoBtn);
            this.Controls.Add(this.SMGAmmoBtn);
            this.Controls.Add(this.ARAmmoBtn);
            this.Controls.Add(this.ArmorBtn);
            this.Controls.Add(this.HealthBtn);
            this.Controls.Add(this.SniperAmmo);
            this.Controls.Add(this.DPistolAmmo);
            this.Controls.Add(this.PistolAmmo);
            this.Controls.Add(this.SMGAmmo);
            this.Controls.Add(this.ARAmmo);
            this.Controls.Add(this.Armor);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.ProcLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssaultCube Trainer v1.3.0.2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.TextBox Health;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HealthBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Armor;
        private System.Windows.Forms.Button ArmorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ARAmmo;
        private System.Windows.Forms.Button ARAmmoBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SMGAmmo;
        private System.Windows.Forms.Button SMGAmmoBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PistolAmmo;
        private System.Windows.Forms.Button PistolAmmoBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DPistolAmmo;
        private System.Windows.Forms.Button DPistolAmmoBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SniperAmmo;
        private System.Windows.Forms.Button SniperAmmoBtn;
        private System.Windows.Forms.CheckBox FreezeHealth;
        private System.Windows.Forms.CheckBox FreezeArmor;
        private System.Windows.Forms.CheckBox FreezeARAmmo;
        private System.Windows.Forms.CheckBox FreezeSMGAmmo;
        private System.Windows.Forms.CheckBox FreezePistolAmmo;
        private System.Windows.Forms.CheckBox FreezeDPistolAmmo;
        private System.Windows.Forms.CheckBox FreezeSniperAmmo;
    }
}

