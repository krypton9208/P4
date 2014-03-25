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
            string t = Convert.ToString(x);
            char[] tab = new char[t.Length];
            if (Convert.ToInt32(t[t.Length - 1]) < 5) 
            { 
                tab[t.Length - 1] = '0'; 
            }
            if (Convert.ToInt32(t[t.Length - 1]) >= 5) 
            {
                int y = Convert.ToInt32(t[t.Length - 2]);
                y += 1;
                string j = Convert.ToString(y);
                char r = Convert.ToChar(j);
                tab[t.Length - 2] = r;
                tab[t.Length-1] = '0';
            }
            t = "";
            return Convert.ToInt32(tab);

        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (trackBar1.Value % 5 != 0) RoundTo(trackBar1.Value);
           
            label1.Text = Convert.ToString(trackBar1.Value);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Right : trackBar1.Value += 5; break;
                case Keys.Left : trackBar1.Value -= 5;break;
            };
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
            label1.Text = label1.Text.Insert(label1.Text.Length - 2, ",");
        }
    }
}
