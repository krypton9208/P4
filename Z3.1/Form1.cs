using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace Ini
{
    /// <summary>
    /// Create a New INI file to store or load data
    /// </summary>
    public class IniFile
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        /// <PARAM name="INIPath"></PARAM>
        public IniFile(string INIPath)
        {
            path = INIPath;
        }
        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// Section name
        /// <PARAM name="Key"></PARAM>
        /// Key Name
        /// <PARAM name="Value"></PARAM>
        /// Value Name
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, this.path);
            return temp.ToString();

        }
    }
}

namespace Z3._1
{
    public partial class Form1 : Form
    {
        public int[] stacja = new int[6];
        public int stacjaw = 1;
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int FlushPrivateProfileString(int lpApplicationName, int lpKeyName, int lpString, string lpFileName);

        string strFilename; 
        private void iniFile(string Filename) 
        {
            strFilename = Filename;
        }
        private string FileName 
        {
          get
             {
              return strFilename;
             }
        }//Tworzymy funkcje odczytu i zapisu informacji w pliku:

        private string GetString(string Section, string Key, string @Default)
        {
           string returnValue = ""; // Odczyt tekstu z pliku ini
           int intCharCount;
           System.Text.StringBuilder objResult = new System.Text.StringBuilder(256);
           intCharCount = GetPrivateProfileString(Section, Key, @Default, objResult, objResult.Capacity, strFilename);
           if (intCharCount > 0)
           {
               returnValue = objResult.ToString().Substring(0, intCharCount);
           } 
           return returnValue;
        } 

        private bool GetBoolean(string Section, string Key, bool @Default)
        { // Odczyt boolean z pliku ini
           return (GetPrivateProfileInt(Section, Key, System.Convert.ToInt32(@Default), strFilename) == 1);
        } 

        private void WriteString(string Section, string Key, string Value)
        {// Zapis tekstu do pliku ini
           WritePrivateProfileString(Section, Key, Value, strFilename);
           Flush();
        } 

        private void WriteInteger(string Section, string Key, int Value)
        {// Zapis liczby do pliku ini
           WriteString(Section, Key, Value.ToString());
           Flush();
        } 

        private void WriteBoolean(string Section, string Key, bool Value)
        {// Zapis boolean do pliku ini
           WriteString(Section, Key, System.Convert.ToInt32(Value).ToString());
           Flush();
        } 

        private void Flush()
        {
           FlushPrivateProfileString(0, 0, 0, strFilename);
        }
        public Form1()
        {
            InitializeComponent();
            //var rand = new Random();
            iniFile(".\\stacje.ini");
            for (int i = 0; i < stacja.Count(); i++)
            {
            //    stacja[i] = Convert.ToInt32((87.0 + rand.Next(1, 20))*100);
                stacja[i] = Convert.ToInt32(GetString("Stacje", ("Radio" + i), "8700"));
            };
            panel1.Enabled = false;
            iniFile(".\\stacje.ini");
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Włącz radio")
            {
                button1.Text = "Wyłącz radio";
                panel1.Enabled = true;
                SetRadio(stacjaw);
                
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) if (trackBar1.Value != trackBar1.Maximum)  trackBar1.Value += 5;  
            if (e.KeyCode == Keys.Left)  if (trackBar1.Value != trackBar1.Minimum)  trackBar1.Value -= 5;
            
            label1.Text = Convert.ToString((trackBar1.Value));
            label1.Text = label1.Text.Insert(label1.Text.Length - 2, ",");
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value % 5 != 0) trackBar1.Value = RoundTo(trackBar1.Value);
            label1.Text = Convert.ToString(trackBar1.Value);
            label1.Text = label1.Text.Insert(label1.Text.Length - 2, ",");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            SetRadio(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            SetRadio(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            SetRadio(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = true;
            SetRadio(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = true;
            SetRadio(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = false;
            SetRadio(6);
        }

        public void SetRadio(int x)
        {
            switch (x)
            {
                case (1):
                    {
                        trackBar1.Value = Convert.ToInt32(stacja[0]);
                        stacjaw = 1;
                        break;
                    }
                case (2):
                    {
                        trackBar1.Value = Convert.ToInt32(stacja[1]);
                        stacjaw = 2;
                        break;
                    }
                case (3):
                    {
                        trackBar1.Value = Convert.ToInt32(stacja[2]);
                        stacjaw = 3;
                        break;
                    }
                case (4):
                    {
                        trackBar1.Value = Convert.ToInt32(stacja[3]);
                        stacjaw = 4;
                        break;
                    }
                case (5):
                    {
                        trackBar1.Value = Convert.ToInt32(stacja[4]);
                        stacjaw = 5;
                        break;
                    }
                case (6):
                    {
                        trackBar1.Value = Convert.ToInt32(stacja[5]);
                        stacjaw = 6;
                        break;
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stacja[stacjaw-1] = trackBar1.Value;
        }
    }
}
