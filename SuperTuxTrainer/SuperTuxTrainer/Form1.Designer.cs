namespace SuperTuxTrainer
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
            this.ProcLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CoinsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FireAmmoTextBox = new System.Windows.Forms.TextBox();
            this.SendCoins = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SendFireAmmo = new System.Windows.Forms.Button();
            this.CharacterStateSelect = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.InvincibilityToggle = new System.Windows.Forms.CheckBox();
            this.FreezeFireAmmo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel.Location = new System.Drawing.Point(69, 9);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(30, 16);
            this.ProcLabel.TabIndex = 1;
            this.ProcLabel.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process:";
            // 
            // CoinsTextBox
            // 
            this.CoinsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoinsTextBox.Location = new System.Drawing.Point(162, 80);
            this.CoinsTextBox.Name = "CoinsTextBox";
            this.CoinsTextBox.Size = new System.Drawing.Size(166, 22);
            this.CoinsTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fire Ammo";
            // 
            // FireAmmoTextBox
            // 
            this.FireAmmoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FireAmmoTextBox.Location = new System.Drawing.Point(162, 119);
            this.FireAmmoTextBox.Name = "FireAmmoTextBox";
            this.FireAmmoTextBox.Size = new System.Drawing.Size(166, 22);
            this.FireAmmoTextBox.TabIndex = 3;
            // 
            // SendCoins
            // 
            this.SendCoins.Location = new System.Drawing.Point(334, 75);
            this.SendCoins.Name = "SendCoins";
            this.SendCoins.Size = new System.Drawing.Size(69, 33);
            this.SendCoins.TabIndex = 4;
            this.SendCoins.Text = "Send";
            this.SendCoins.UseVisualStyleBackColor = true;
            this.SendCoins.Click += new System.EventHandler(this.SendCoins_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SendFireAmmo
            // 
            this.SendFireAmmo.Location = new System.Drawing.Point(334, 114);
            this.SendFireAmmo.Name = "SendFireAmmo";
            this.SendFireAmmo.Size = new System.Drawing.Size(69, 33);
            this.SendFireAmmo.TabIndex = 4;
            this.SendFireAmmo.Text = "Send";
            this.SendFireAmmo.UseVisualStyleBackColor = true;
            this.SendFireAmmo.Click += new System.EventHandler(this.SendFireAmmo_Click);
            // 
            // CharacterStateSelect
            // 
            this.CharacterStateSelect.BackColor = System.Drawing.Color.White;
            this.CharacterStateSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharacterStateSelect.Items.Add("Small");
            this.CharacterStateSelect.Items.Add("Big");
            this.CharacterStateSelect.Items.Add("Firepower");
            this.CharacterStateSelect.Location = new System.Drawing.Point(162, 159);
            this.CharacterStateSelect.Name = "CharacterStateSelect";
            this.CharacterStateSelect.ReadOnly = true;
            this.CharacterStateSelect.Size = new System.Drawing.Size(166, 22);
            this.CharacterStateSelect.TabIndex = 5;
            this.CharacterStateSelect.Text = "Small";
            this.CharacterStateSelect.SelectedItemChanged += new System.EventHandler(this.CharacterStateSelect_SelectedItemChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Character State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Log:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Location = new System.Drawing.Point(43, 213);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(30, 16);
            this.Status.TabIndex = 1;
            this.Status.Text = "N/A";
            // 
            // InvincibilityToggle
            // 
            this.InvincibilityToggle.AutoSize = true;
            this.InvincibilityToggle.Location = new System.Drawing.Point(334, 160);
            this.InvincibilityToggle.Name = "InvincibilityToggle";
            this.InvincibilityToggle.Size = new System.Drawing.Size(93, 20);
            this.InvincibilityToggle.TabIndex = 6;
            this.InvincibilityToggle.Text = "Invincibility";
            this.InvincibilityToggle.UseVisualStyleBackColor = true;
            this.InvincibilityToggle.CheckedChanged += new System.EventHandler(this.InvincibilityToggle_CheckedChanged);
            // 
            // FreezeFireAmmo
            // 
            this.FreezeFireAmmo.AutoSize = true;
            this.FreezeFireAmmo.Location = new System.Drawing.Point(409, 120);
            this.FreezeFireAmmo.Name = "FreezeFireAmmo";
            this.FreezeFireAmmo.Size = new System.Drawing.Size(71, 20);
            this.FreezeFireAmmo.TabIndex = 6;
            this.FreezeFireAmmo.Text = "Freeze";
            this.FreezeFireAmmo.UseVisualStyleBackColor = true;
            this.FreezeFireAmmo.CheckedChanged += new System.EventHandler(this.FreezeFireAmmo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 238);
            this.Controls.Add(this.FreezeFireAmmo);
            this.Controls.Add(this.InvincibilityToggle);
            this.Controls.Add(this.CharacterStateSelect);
            this.Controls.Add(this.SendFireAmmo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendCoins);
            this.Controls.Add(this.FireAmmoTextBox);
            this.Controls.Add(this.CoinsTextBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ProcLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SuperTux Trainer x64 v0.6.7";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoinsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FireAmmoTextBox;
        private System.Windows.Forms.Button SendCoins;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SendFireAmmo;
        private System.Windows.Forms.DomainUpDown CharacterStateSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.CheckBox InvincibilityToggle;
        private System.Windows.Forms.CheckBox FreezeFireAmmo;
    }
}

