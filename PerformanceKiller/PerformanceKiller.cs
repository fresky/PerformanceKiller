using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Management;

namespace PerformanceKiller
{
    public partial class PerformanceKiller : Form
    {
        public delegate void UpdateLabelDelegate(string text, Label label);

        private static volatile bool m_ThreadFlag;
        private readonly List<Process> m_Processes = new List<Process>();

        public PerformanceKiller()
        {
            InitializeComponent();
            var processorCount = Environment.ProcessorCount;
            label_Info.Text = "(You have " + processorCount + " CPU cores!)";

            numericUpDown_Cores.Maximum = 0;
            numericUpDown_Cores.Maximum = processorCount;

            backgroundWorker1.RunWorkerAsync();
        }

        private string RefreshCPUFrequency()
        {
            uint currentClock;
            uint maxClock;

            using (ManagementObject mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'"))
            {
                currentClock = (uint)mo["CurrentClockSpeed"];
                maxClock = (uint)mo["MaxClockSpeed"];
            }
            return "Current Frequency: " + (currentClock / 1000.0).ToString("F2") + "G" +
                                   Environment.NewLine +
                                   "Max Frequency: " + (maxClock / 1000.0).ToString("F2") + "G" +
                                   Environment.NewLine +
                                   "Percentage: " + (currentClock * 1.0 / maxClock).ToString("P2");

        }

        private string RefreshMemory()
        {
            var curentProcess = Process.GetCurrentProcess();
            long workingSet = curentProcess.WorkingSet64;
            long virtualMemory = curentProcess.VirtualMemorySize64;

            foreach (var p in m_Processes)
            {
                p.Refresh();
                workingSet += p.WorkingSet64;
                virtualMemory += p.VirtualMemorySize64;

            }
            return "Working Set: " + FormatMemoryString(workingSet) +
                                Environment.NewLine
                                + "Virtual Memory: " + FormatMemoryString(virtualMemory);
        }

        private object FormatMemoryString(long memoryBytes)
        {
            long kb = 1024;
            long mb = 1024 * kb;
            long gb = 1024 * mb;
            if (memoryBytes / gb > 0)
            {
                return (memoryBytes * 1.0 / gb).ToString("F2") + " G";
            }
            if (memoryBytes / mb > 0)
            {
                return (memoryBytes * 1.0 / mb).ToString("F2") + " M";
            }

            return (memoryBytes * 1.0 / kb).ToString("F2") + " K";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            m_ThreadFlag = false;
            foreach (var p in m_Processes)
            {
                p.Kill();
            }
            base.OnFormClosing(e);
        }

        private void button_Occupy_Click(object sender, EventArgs e)
        {
            m_ThreadFlag = false;
            Thread.Sleep(100);
            m_ThreadFlag = true;
            for (int i = 0; i < numericUpDown_Cores.Value; i++)
            {
                Thread t = new Thread(start);
                t.Start();
            }
        }

        private void start()
        {
            while (m_ThreadFlag)
            {
            }
        }

        private void button_Free_Click(object sender, EventArgs e)
        {
            m_ThreadFlag = false;
            numericUpDown_Cores.Value = 0;
        }

        private void button_add500_Click(object sender, EventArgs e)
        {
            m_Processes.Add(Process.Start("HalfGMemory.exe"));
        }

        private void button_free500_Click(object sender, EventArgs e)
        {
            if (m_Processes.Count == 0)
            {
                return;
            }
            var p = m_Processes[0];
            p.Kill();
            m_Processes.RemoveAt(0);
        }

        private void button_FreeAllMemory_Click(object sender, EventArgs e)
        {
            foreach (var p in m_Processes)
            {
                p.Kill();
            }
            m_Processes.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                string memory = RefreshMemory();
                string cpu = RefreshCPUFrequency();
                UpdateLable(memory, label_memory);
                UpdateLable(cpu, label_CPU_Frequency);
                Thread.Sleep(1000);
            }
        }

        private void UpdateLable(string text, Label label)
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateLabelDelegate(UpdateLable), text, label);
                return;
            }
            label.Text = text;
        }
    }
}
