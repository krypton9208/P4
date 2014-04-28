using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int result = 0;
            int n = 20;
            for (int i = 0; i < n; i++)
            {
                Thread.Sleep((int)TimeSpan.FromSeconds(0.5).TotalMilliseconds);
                result += i;
                backgroundWorker1.ReportProgress((i+1) * 100 / n, i);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
            e.Result = result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            { 
                label1.Text = e.Result.ToString(); 
            }
            else
            {
                label1.Text = "canceled";
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = e.UserState.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
