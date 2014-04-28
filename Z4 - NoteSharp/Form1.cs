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
        Boolean RTF = false;
        public Form1()
        {
            InitializeComponent();
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
        

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, false, Encoding.Default))
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
            FilePath = openFileDialog1.FileName;
            if (FilePath.Substring(FilePath.Length - 3, 3) != "rtf")
            {
                StreamReader sr = new StreamReader(FilePath, Encoding.Default);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                RTF = false;
            }
            else
            {
                richTextBox1.LoadFile(FilePath);
                RTF = true;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveFileDialog1.FileName;
            if (FilePath.Substring(FilePath.Length - 3, 3) == "rtf") RTF = true; else RTF = false;
            if (RTF)
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.Default))
                {
                    foreach (string line in richTextBox1.Lines)
                        writer.WriteLine(line);
                }
            }
            else
            {
                richTextBox1.SaveFile(FilePath);
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePath = "";
            openFileDialog1.FileName = "";
            saveFileDialog1.FileName = "";
            richTextBox1.Clear();
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            
        }
    }
}
