using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int width = 100;
                    int height = 30;
                    var button = new Button()
                        {
                            Text = k.ToString(),
                            Width = width,
                            Height = height,
                            Left = 20+j*width,
                            Top = 100+i*height,
                            Tag = i,
                            Parent = this

                        };
                    k++;
                    button.Click += button_Click;
                }
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            var b = (sender as Button);
            b.BackColor = Color.Red;
            Text = b.Tag.ToString() + " " + DateTime.Now.ToString();
        }
    }
}
