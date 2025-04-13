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
using System.Runtime.InteropServices;
using System.Media;

namespace GodOfWarRagnarokTrainer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 1, 0x0000, Keys.F5);
            RegisterHotKey(this.Handle, 2, 0x0002, Keys.F5);

            RegisterHotKey(this.Handle, 3, 0x0000, Keys.F6);
            RegisterHotKey(this.Handle, 4, 0x0002, Keys.F6);

            RegisterHotKey(this.Handle, 5, 0x0000, Keys.F7);
            RegisterHotKey(this.Handle, 6, 0x0002, Keys.F7);
        }

        public Mem m = new Mem();
        bool ProcOpen = false;

        #region Hotkeys

        #region DllImports
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, uint vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion

        #region WndProc
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x0312)
            {
                int id = msg.WParam.ToInt32();
                if (id == 1)
                {
                    IncreaseX();
                }
                if (id == 2)
                { 
                    DecreaseX();
                }
                if (id == 3)
                {
                    IncreaseY();
                }
                if (id == 4)
                {
                    DecreaseY();
                }
                if (id == 5)
                {
                    IncreaseZ();
                }
                if (id == 6)
                {
                    DecreaseZ();
                }
            }
            base.WndProc(ref msg);
        }
        #endregion

        #region Functions
        void IncreaseX()
        {
            float LocationX = m.ReadFloat("base+05D0A478,2A0,650");
            float IncreasedLocationX = LocationX + 2.0f;
            m.WriteMemory("base+05D0A478,2A0,650", "float", IncreasedLocationX.ToString());
        }
        void DecreaseX()
        {
            float LocationX = m.ReadFloat("base+05D0A478,2A0,650");
            float DecreasedLocationX = LocationX - 2.0f;
            m.WriteMemory("base+05D0A478,2A0,650", "float", DecreasedLocationX.ToString());
        }
        void IncreaseY()
        {
            float LocationY = m.ReadFloat("base+05D0A488,2A0,4B4");
            float IncreasedLocationY = LocationY + 2.0f;
            m.WriteMemory("base+05D0A488,2A0,4B4", "float", IncreasedLocationY.ToString());
        }
        void DecreaseY()
        {
            float LocationY = m.ReadFloat("base+05D0A488,2A0,4B4");
            float DecreasedLocationY = LocationY - 2.0f;
            m.WriteMemory("base+05D0A488,2A0,4B4", "float", DecreasedLocationY.ToString());
        }
        void IncreaseZ()
        {
            float LocationZ = m.ReadFloat("base+05D0A438,2A0,CD8");
            float IncreasedLocationZ = LocationZ + 2.0f;
            m.WriteMemory("base+05D0A438,2A0,CD8", "float", IncreasedLocationZ.ToString());
        }
        void DecreaseZ()
        {
            float LocationZ = m.ReadFloat("base+05D0A438,2A0,CD8");
            float DecreasedLocationZ = LocationZ - 2.0f;
            m.WriteMemory("base+05D0A438,2A0,CD8", "float", DecreasedLocationZ.ToString());
        }
        #endregion

        #endregion

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Int32 proc = Process.GetProcessesByName("GoWR")[0].Id;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("F5 - Increase X coordinates\nCTRL+F5 - Decrease X coordinates\n\nF6 - Increase Y coordinates\nCTRL+F6 - Decrease Y coordinates\n\nF7 - Increase Z coordinates\nCTRL+F7 - Decrease Z coordinates", "Controls");
        }
    }
}
