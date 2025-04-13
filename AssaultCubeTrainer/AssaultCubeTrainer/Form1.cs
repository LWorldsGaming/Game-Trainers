using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaultCubeTrainer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();
        bool ProcOpen = false;

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Int32 Proc = Process.GetProcessesByName("ac_client")[0].Id;
            ProcOpen = m.OpenProcess(Proc);
            if (!ProcOpen)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!ProcOpen)
            {
                ProcLabel.Text = "N/A";
            }
            else
            {
                ProcLabel.Text = "Game Found!";
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
            // MessageBox.Show("Sniper ammo & AR ammo are same!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #region DllImports
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, uint vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion
        #region SendBtn
        private void HealthBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Health.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+0017E0A8, EC", "int", Health.Text);
            }
        }

        private void ArmorBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Armor.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+0017E0A8, F0", "int", Armor.Text);
            }
        }

        private void ARAmmoBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(ARAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+00183828, 8, 88C, 9C, 64, 30, 98, 38C", "int", ARAmmo.Text);
            }
        }

        private void SMGAmmoBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(SMGAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+0017E0A8, 138", "int", SMGAmmo.Text);
            }
        }

        private void PistolAmmoBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(PistolAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+00183828, 8, DFC, 30, 30, 20C", "int", PistolAmmo.Text);
            }
        }

        private void DPistolAmmoBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(DPistolAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+00183828, 8, 58, 34, 64, 1C0", "int", DPistolAmmo.Text);
            }
        }

        private void SniperAmmoBtn_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(SniperAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+00183828, 8, BB8, 64, 64, 64, 9C, 48C", "int", SniperAmmo.Text);
            }
        }
        #endregion
        #region Freeze
        private void FreezeHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeHealth.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(Health.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeHealth.Checked = false;
            }
            else
            {
                if (FreezeHealth.Checked)
                    m.FreezeValue("base+0017E0A8, EC", "int", Health.Text);
                else
                    m.UnfreezeValue("base+0017E0A8, EC");
            }
        }

        private void FreezeArmor_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeArmor.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(Armor.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeArmor.Checked = false;
            }
            else
            {
                if (FreezeArmor.Checked)
                    m.FreezeValue("base+0017E0A8, F0", "int", Armor.Text);
                else
                    m.UnfreezeValue("base+0017E0A8, F0");
            }
        }

        private void FreezeARAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeARAmmo.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(ARAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeARAmmo.Checked = false;
            }
            else
            {
                if (FreezeARAmmo.Checked)
                    m.FreezeValue("base+00183828, 8, 88C, 9C, 64, 30, 98, 38C", "int", ARAmmo.Text);
                else
                    m.UnfreezeValue("base+00183828, 8, 88C, 9C, 64, 30, 98, 38C");
            }
        }

        private void FreezeSMGAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeSMGAmmo.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(SMGAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeSMGAmmo.Checked = false;
            }
            else
            {
                if (FreezeSMGAmmo.Checked)
                    m.FreezeValue("base+0017E0A8, 138", "int", SMGAmmo.Text);
                else
                    m.UnfreezeValue("base+0017E0A8, 138");
            }
        }

        private void FreezePistolAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezePistolAmmo.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(PistolAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezePistolAmmo.Checked = false;
            }
            else
            {
                if (FreezePistolAmmo.Checked)
                    m.FreezeValue("base+00183828, 8, DFC, 30, 30, 20C", "int", PistolAmmo.Text);
                else
                    m.UnfreezeValue("base+00183828, 8, DFC, 30, 30, 20C");
            }
        }

        private void FreezeDPistolAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeDPistolAmmo.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(DPistolAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeDPistolAmmo.Checked = false;
            }
            else
            {
                if (FreezeDPistolAmmo.Checked)
                    m.FreezeValue("base+0017D848, 94, 38, 148", "int", DPistolAmmo.Text);
                else
                    m.UnfreezeValue("base+0017D848, 94, 38, 148");
            }
        }
        
        private void FreezeSniperAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeSniperAmmo.Checked = false;
            }
            else if (string.IsNullOrWhiteSpace(SniperAmmo.Text))
            {
                MessageBox.Show("Input cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FreezeSniperAmmo.Checked = false;
            }
            else
            {
                if (FreezeSniperAmmo.Checked)
                    m.FreezeValue("base+00183828, 8, BB8, 64, 64, 64, 9C, 48C", "int", SniperAmmo.Text);
                else
                    m.UnfreezeValue("base+00183828, 8, BB8, 64, 64, 64, 9C, 48C");
            }
        }
        #endregion
    }
}
