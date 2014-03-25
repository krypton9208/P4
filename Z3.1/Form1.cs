using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Resize(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Włącz radio")
            {
                button1.Text = "Wyłącz radio";
                panel1.Enabled = true;
            }
            else 
            {
                panel1.Enabled = false;
                button1.Text = "Włącz radio"; 
            }
        }

        private int RoundTo(int x)
        {
            double k = 0;
            if (x % 10 < 5)
            {
                k = (Math.Round((x) /10.0)) * 10;
                if (k > trackBar1.Maximum) k = trackBar1.Maximum;
            }
            else if (x % 10 >= 5)
            {
                k = (Math.Round((x + 10) /10.0)) * 10;
                if (k > trackBar1.Maximum) k = trackBar1.Maximum;
            }
            return Convert.ToInt32(k);
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) if (trackBar1.Value != trackBar1.Maximum)  trackBar1.Value += 5;  
            if (e.KeyCode == Keys.Left)  if (trackBar1.Value != trackBar1.Minimum)  trackBar1.Value -= 5;
            
            label1.Text = Convert.ToString((trackBar1.Value));
            label1.Text = label1.Text.Insert(label1.Text.Length - 2, ",");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void trackBar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value % 5 != 0) trackBar1.Value = RoundTo(trackBar1.Value);
            label1.Text = Convert.ToString(trackBar1.Value);
            label1.Text = label1.Text.Insert(label1.Text.Length - 2, ",");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }
    }
}
