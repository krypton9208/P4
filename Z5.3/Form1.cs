using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z5._3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) <=103)
            {
                int n = Convert.ToInt32(textBox1.Text);
                Int64 a = 0;
                Int64 b = 1;
                for (int i = 0; i < n; i++)
                {
                    Int64 temp = a;
                    a = b;
                    b = temp + b;
                    backgroundWorker1.ReportProgress((i + 1) * 100 / n);
                }
                e.Result = a;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label2.Text = e.Result.ToString();
        }
    }
}
