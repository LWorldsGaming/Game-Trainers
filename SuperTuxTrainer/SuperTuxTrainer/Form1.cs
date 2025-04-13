using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace SuperTuxTrainer
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
            Int32 proc = Process.GetProcessesByName("supertux2")[0].Id;
            ProcOpen = m.OpenProcess(proc);
            if (!ProcOpen)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);

            if (ProcOpen)
            {
                Int32 CharacterStateValue = m.ReadInt("base+002F0AC0,B0,38,8,8,18,78,4");
                string CharacterState = "";
                if (CharacterStateValue == 0)
                {
                    CharacterState = "Small";
                }
                if (CharacterStateValue == 1)
                {
                    CharacterState = "Big";
                }
                if (CharacterStateValue == 2)
                {
                    CharacterState = "Firepower";
                }
                CharacterStateSelect.SelectedItem = CharacterState;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
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

        private void SendCoins_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(CoinsTextBox.Text))
            {
                MessageBox.Show("Input box cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+002F0AC0,B0,38,8,18,110,130,0", "int", CoinsTextBox.Text);
                Status.Text = $"Set coins to {CoinsTextBox.Text}";
            }
        }

        private void SendFireAmmo_Click(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(FireAmmoTextBox.Text))
            {
                MessageBox.Show("Input box cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.WriteMemory("base+002F0AC0,B0,38,8,8,18,78,8", "int", FireAmmoTextBox.Text);
                Status.Text = $"Set fire ammo to {FireAmmoTextBox.Text}";
            }
        }

        private void CharacterStateSelect_SelectedItemChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CharacterStateSelect.SelectedItem.ToString() == "Small")
                {
                    m.WriteMemory("base+002F0AC0,B0,38,8,8,18,78,4", "int", "0");
                    Status.Text = $"Set character state to {CharacterStateSelect.SelectedItem}";
                }
                else if (CharacterStateSelect.SelectedItem.ToString() == "Big")
                {
                    m.WriteMemory("base+002F0AC0,B0,38,8,8,18,78,4", "int", "1");
                    Status.Text = $"Set character state to {CharacterStateSelect.SelectedItem}";
                }
                else
                {
                    m.WriteMemory("base+002F0AC0,B0,38,8,8,18,78,4", "int", "2");
                    Status.Text = $"Set character state to {CharacterStateSelect.SelectedItem}";
                }
            }
        }

        private void InvincibilityToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (InvincibilityToggle.Checked)
                {
                    Int32 CharacterStateValue = m.ReadInt("base+002F0AC0,B0,38,8,8,18,78,4");
                    m.FreezeValue("base+002F0AC0,B0,38,8,8,18,78,4", "int", CharacterStateValue.ToString());
                    Status.Text = "Set invincibility to enabled";
                }
                else
                {
                    m.UnfreezeValue("base+002F0AC0,B0,38,8,8,18,78,4");
                    Status.Text = "Set invincibility to disabled";
                }
            }
        }

        private void FreezeFireAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProcOpen)
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Int32 FireAmmo = m.ReadInt("base+002F0AC0,B0,38,8,8,18,78,8");
                if (FreezeFireAmmo.Checked)
                {
                    if (FireAmmo == 0)
                    {
                        m.FreezeValue("base+002F0AC0,B0,38,8,8,18,78,8", "int", "9999");
                        MessageBox.Show("Your ammo was 0, so it was set to 9999.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        m.FreezeValue("base+002F0AC0,B0,38,8,8,18,78,8", "int", FireAmmo.ToString());
                        Status.Text = $"Set fire ammo to frozen";
                    }
                }
                else
                {
                    m.UnfreezeValue("base+002F0AC0,B0,38,8,8,18,78,8");
                }
            }
        }
    }
}
