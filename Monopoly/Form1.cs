using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        public string myXmlString { get; set; }
        public List<Pole> Pola = new List<Pole>();
        public List<Gracz> Gracze = new List<Gracz>();
        public int temp1 = 0;
        public int Someint = 0;
        public int actualnygracz = 0;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            List<Pole> PolaSort = Pola.OrderBy(o=>o.WhitchPosition()).ToList();
            Pola = PolaSort;
            DrawGame();
        }
        private void LoadData()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("baza.xml");
            XmlNodeList xnList = xml.SelectNodes("/Plansza/Panstwa/Panstwo/Miasto");
            foreach (XmlNode xn in xnList)
            {
                Pola.Add(new Pole(
                    Convert.ToInt32(xn["Value4"].InnerText),
                    Convert.ToInt32(xn["Value1"].InnerText),
                    xn["Value2"].InnerText,
                    Pole.Types.City,
                    xn["Nazwa"].InnerText));
            }
            XmlNodeList xnList2 = xml.SelectNodes("/Plansza/Atrakcje/Niebieskie");
            foreach (XmlNode xn in xnList2)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                0,
                "",
                Pole.Types.Quest,
                "Niebieskie"));
            }
            XmlNodeList xnList3 = xml.SelectNodes("/Plansza/Atrakcje/Czerwone");
            foreach (XmlNode xn in xnList3)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                0,
                "",
                Pole.Types.Quest,
                "Czerwone"));
            }
            XmlNodeList xnList4 = xml.SelectNodes("/Plansza/Atrakcje/Kolej");
            foreach (XmlNode xn in xnList4)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                0,
                "",
                Pole.Types.Spec,
                "Kolej"));
            }
            XmlNodeList xnList5 = xml.SelectNodes("/Plansza/Atrakcje/Start");
            foreach (XmlNode xn in xnList5)
            {
                Pola.Add(new Pole(
                0,
                Convert.ToInt32(xn["Value1"].InnerText),
                "",
                Pole.Types.Start,
                "Punkt Startowy!"));
            }
            XmlNodeList xnList6 = xml.SelectNodes("/Plansza/Atrakcje/Wodociagi");
            foreach (XmlNode xn in xnList6)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                Convert.ToInt32(xn["Value2"].InnerText),
                "",
                Pole.Types.Spec,
                "Wodociagi"));
            };
            XmlNodeList xnList7 = xml.SelectNodes("/Plansza/Atrakcje/Elektrownia");
            foreach (XmlNode xn in xnList7)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                Convert.ToInt32(xn["Value2"].InnerText),
                "",
                Pole.Types.Spec,
                "Elektrownia"));
            }
            XmlNodeList xnList8 = xml.SelectNodes("/Plansza/Atrakcje/Podatek");
            foreach (XmlNode xn in xnList8)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                Convert.ToInt32(xn["Value2"].InnerText),
                "",
                Pole.Types.Spec,
                "Podatek"));
            }
            XmlNodeList xnList9 = xml.SelectNodes("/Plansza/Atrakcje/Parking");
            foreach (XmlNode xn in xnList9)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                Convert.ToInt32(xn["Value2"].InnerText),
                "",
                Pole.Types.Parking,
                "Parking Płatny"));
            }
            XmlNodeList xnList10 = xml.SelectNodes("/Plansza/Atrakcje/Parkingfree");
            foreach (XmlNode xn in xnList10)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                Convert.ToInt32(xn["Value2"].InnerText),
                "",
                Pole.Types.ParkingFree,
                "Parking darmowy"));
            }
            XmlNodeList xnList11 = xml.SelectNodes("/Plansza/Atrakcje/Wizyta");
            foreach (XmlNode xn in xnList11)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                0,
                "",
                Pole.Types.Spec,
                "Wizyta w areszcie"));
            }
            XmlNodeList xnList12 = xml.SelectNodes("/Plansza/Atrakcje/Areszt");
            foreach (XmlNode xn in xnList12)
            {
                Pola.Add(new Pole(
                Convert.ToInt32(xn["Value1"].InnerText),
                0,
                "",
                Pole.Types.Spec,
                "Witaj w areszcie"));
            }
           
        }
        private void DrawGame()
        {
             int temp = 0, temp2=0, nr = 1, p = 0;
            for (int i = 0; i <= 10; i++)
            {
                    int width = 100;
                    int height = 100;
                    Pola[p].Panelek = new Panel()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Width = width,
                        Height = height,
                        Left = 20 + i * width,
                        Top = 20,
                        Tag = p,
                        Parent = this
                    };
                    Pola[p].x = Pola[p].Panelek.Margin.Left;
                    Pola[p].y = Pola[p].Panelek.Margin.Top;
                    Label Napis = new Label()
                    {
                        Text = Pola[p].Name,
                        Top = 1,
                        Left = 1,
                        AutoSize = true,
                        Name = i.ToString(),
                        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                        BackColor = Color.Transparent,
                        ForeColor = Color.Black,
                        Visible = true
                    };
                    Pola[p].Panelek.Controls.Add(Napis);
                    
                    this.Controls.Add(Pola[p].Panelek);
                    Pola[p].Panelek.Click += panel_click;
                    Pola[p].Panelek.ControlAdded += Panelek_ControlAdded;
                    temp = Pola[p].Panelek.Left;
                    nr++;
                    p++;
            }
            for (int i = 0; i < 10; i++)
            {
                int width = 100;
                int height = 100;
                Pola[p].Panelek= new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = width,
                    Height = height,
                    Left = temp,
                    Top = 120 + i * height,
                    Tag = p,
                    Parent = this
                };
                Pola[p].x = Pola[p].Panelek.Margin.Left;
                Pola[p].y = Pola[p].Panelek.Margin.Top;
                Label Napis = new Label()
                {
                    Text = Pola[p].Name,
                    Top = 1,
                    Left = 1,
                    AutoSize = true,
                    Name = i.ToString(),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Visible = true
                };
                
                Pola[p].Panelek.Controls.Add(Napis);
                this.Controls.Add(Pola[p].Panelek);
                Pola[p].Panelek.Click += panel_click;
                Pola[p].Panelek.ControlAdded += Panelek_ControlAdded;
                temp2 = Pola[p].Panelek.Top;
                temp = Pola[p].Panelek.Left;
                nr++;
                p++;
            }

            for (int i = 1; i <= 10; i++)
            {
                int width = 100;
                int height = 100;
                Pola[p].Panelek = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new System.Windows.Forms.Padding(100, 100, 100,100),
                    Width = width,
                    Height = height,
                    Left = temp - i * width,
                    Top = temp2,
                    Tag = p,
                    Parent = this
                };
                Pola[p].x = Pola[p].Panelek.Margin.Left;
                Pola[p].y = Pola[p].Panelek.Margin.Top;
                Label Napis = new Label()
                {
                    Text = Pola[p].Name,
                    Top = 1,
                    Left = 1,
                    AutoSize = true,
                    Name = i.ToString(),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Visible = true
                };
                
                Pola[p].Panelek.Controls.Add(Napis);
                this.Controls.Add(Pola[p].Panelek);
                Pola[p].Panelek.Click += panel_click;
                Pola[p].Panelek.ControlAdded += Panelek_ControlAdded;
                temp2 = Pola[p].Panelek.Top;
                nr++;
                p++;
            }
            for (int i = 1; i < 10; i++)
            {
                int width = 100;
                int height = 100;
                Pola[p].Panelek = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = width,
                    Height = height,
                    Left = 20,
                    Top = temp2 - i * height,
                    Tag = p,
                    Parent = this                   
                };
                Pola[p].x = Pola[p].Panelek.Margin.Left;
                Pola[p].y = Pola[p].Panelek.Margin.Top;
                Label Napis = new Label()
                {
                    Text = Pola[p].Name,
                    Top = 1,
                    Left = 1,
                    AutoSize = true,
                    Name = i.ToString(),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Visible = true
                };
                
                Pola[p].Panelek.Controls.Add(Napis);
                this.Controls.Add(Pola[p].Panelek);
                Pola[p].Panelek.Click += panel_click;
                Pola[p].Panelek.ControlAdded += Panelek_ControlAdded;
                nr++;
                p++;
            };
        }

        void Panelek_ControlAdded(object sender, ControlEventArgs e)
        {
            var item = (sender as Panel);
            string temp = Convert.ToString(Pola[Convert.ToInt32(item.Tag)].WhatType());
            var Pol = Pola[Convert.ToInt32(item.Tag)];
            switch (temp)
            {
                case "City" :
                    {
                        if (Pol.whoisowner() == actualnygracz || Pol.whoisowner() == null) GiveChoose(Pol.WhitchPosition()) ;
                        break;
                    }
            }
            
        }

        private void GiveChoose(int x)
        {
            var button = new Button()
            {
                Text = "Kup miasto",
                Parent = panel2,
                Left = 5,
                Top = 10
            };
        }

        private void panel_click(object sender, EventArgs e)
        {
            var item = (sender as Panel);
            MessageBox.Show(item.Tag.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = Convert.ToString(rnd.Next(1, 13));
            
            if (actualnygracz == Gracze.Count-1) actualnygracz = 0;
            else actualnygracz++;
            MooveHorse(actualnygracz, Convert.ToInt32(label1.Text));

            
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Gracze.Count <= 7)
            {
                textBox1.Text = "";
                textBox1.Visible = true;
                pictureBox9.Visible = true;
                pictureBox9.Image = imageList1.Images[0];
                button3.Visible = true;
            }
            else MessageBox.Show("Maksymalna liczba graczy.");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var item = (sender as PictureBox);
            Someint++;
            if (Someint == imageList1.Images.Count) Someint = 0;
            item.Image = imageList1.Images[Someint];
        }
        private void MooveHorse(int id, int x)
        {
            Gracze[id].ActualPosition += x;
            if (Gracze[id].ActualPosition >= 40) Gracze[id].ActualPosition -= 40;
            Gracze[id].Pionek.Parent = Pola[Gracze[id].ActualPosition].Panelek;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Gracze.Add(new Gracz(textBox1.Text, 2000, temp1, Gracze.Count));
            textBox1.Visible = false;
            imageList2.Images.Add(imageList1.Images[Someint]);
            imageList1.Images.RemoveAt(Someint);
            Gracze[Gracze.Count-1].Pionek.Image = imageList2.Images[Gracze[Gracze.Count-1].Figure];
            Gracze[Gracze.Count-1].Pionek.Visible = true;
            pictureBox9.Visible = false;
            button3.Visible = false;
            temp1++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MooveHorse(actualnygracz, Convert.ToInt32(label1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Gracze.Count; i++)
            {
                MooveHorse(i, 0);
            }
        }

      
        
    }
}
