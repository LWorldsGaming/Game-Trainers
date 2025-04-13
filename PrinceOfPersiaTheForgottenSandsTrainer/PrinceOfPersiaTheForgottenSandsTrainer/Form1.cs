using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace PrinceOfPersiaTheForgottenSandsTrainer
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
            Int32 proc = Process.GetProcessesByName("Prince of Persia")[0].Id;
            ProcOpen = m.OpenProcess(proc);
            if (!ProcOpen)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
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
        private void InfHealthToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (InfHealthToggle.Checked)
            {
                m.WriteMemory("base+13FBBA", "bytes", "E9 41 04 3B 01 66 90");
            }
            else
            {
                m.WriteMemory("base+13FBBA", "bytes", "89 7B 18 56 8B 73 08");
            }
        }

        private void InfRewindToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (InfRewindToggle.Checked)
            {
                m.FreezeValue("base+00DA5358,70", "int", "2147483647");
            }
            else
            {
                m.UnfreezeValue("base+00DA5358,70");
            }
        }

        private void InfFreezeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (InfFreezeToggle.Checked)
            {
                m.FreezeValue("base+00DA54C8,1C8", "int", "1098907648");
            }
            else
            {
                m.UnfreezeValue("base+00DA54C8,1C8");
            }
        }

        private void OneHitKillsToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (OneHitKillsToggle.Checked)
            {
                m.WriteMemory("base+13FBBA", "bytes", "E9 41 04 5F 01 66 90");
            }
            else
            {
                m.WriteMemory("base+13FBBA", "bytes", "89 7B 18 56 8B 73 08");
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to enable Unlimited Energy if you're using Infinite Health", "Note", MessageBoxButtons.OK);
        }
    }
}
