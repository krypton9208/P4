using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.IO;
using System.Text;

namespace Z4___NoteSharp
{
    public partial class Form1 : Form
    {
        string FilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateLocal = DateTime.Now;
            toolStripStatusLabel2.Text = dateLocal.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        
        private void AW(int x)
        {
            toolStripStatusLabel3.Text = "Linia: " + Convert.ToString(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            AW(richTextBox1.GetLineFromCharIndex(index)+1);
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }
        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.GetEncoding(1251)))
            {
                foreach (string line in richTextBox1.Lines)
                    writer.WriteLine(line);
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            //openFileDialog1.OpenFile();
            FilePath = openFileDialog1.FileName;
            StreamReader sr = new StreamReader(FilePath, Encoding.GetEncoding(1251));
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


            using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.GetEncoding(1251)))
            {
                foreach (string line in richTextBox1.Lines)
                    writer.WriteLine(line);
            }
        }
    }
}
