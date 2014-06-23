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

        private void Optiones(bool a, bool b, bool c, bool d)
        {
            BuyObject.Visible = a;
            BuyHotel.Visible = b;
            BuyHouse.Visible = c;
            DoNothing.Visible = d;
        }

        private void NextPlayer()
        {
             if (Gracze[actualnygracz].CashState() <= 0 )
             {
                 foreach (var item in Gracze[actualnygracz].Wposiadaniu)
	            {
                        Pola[item].NewOwner(9);
                 }
                 MessageBox.Show("GAME OVER!! ");
                 Gracze.RemoveAt(actualnygracz);
                 List<Gracz> temperta = Gracze.OrderBy(o => o.ID).ToList();
                 Gracze = temperta;
             }
            if (actualnygracz == Gracze.Count - 1) actualnygracz = 0;
                else if (actualnygracz < Gracze.Count - 1) actualnygracz++;
            label3.Text = Gracze[actualnygracz].Name;
            if (Gracze[actualnygracz].Wiezienie != 0)
            {
                MessageBox.Show("Aktualnie mija twoja kolejka.");
                Gracze[actualnygracz].Wiezienie -= 1;
                Optiones(false, false, false, true);
            }
            
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
                        if (Pol.whoisowner() == 9)
                        {
                            Optiones(true, false, false, true);
                        }
                        else if (Pol.whoisowner() == actualnygracz)
                        {
                            if (Pol.HowHouse() == 4)
                            Optiones(false, true, false, true);
                            else Optiones(false, false, true, true);
                        }
                        else if (Pol.whoisowner() != actualnygracz && Pol.whoisowner() != 9)
                        {
                            int t = 0;
                            t = Pol.HowHouse() * 100;
                            t += Pol.HowHotel() * 400;
                            Gracze[actualnygracz].TakeMoney((Pol.HowPrice() / 2) + t);
                            Gracze[Pol.whoisowner()].GiveMoney((Pol.HowPrice() / 2) + t);
                            MessageBox.Show("Straciłeś właśnie: " + ((Pol.HowPrice() / 2) + t).ToString() + "$");
                            Optiones(false, false, false, true);
                        }
                        break;
                    };
                case "Quest":
                    {
                        if (Pol.WhitchPosition() == 3 || Pol.WhitchPosition() == 18 || Pol.WhitchPosition() == 34)
                        {
                            Random rnd = new Random();
                            int t = rnd.Next(0, Niebieskie.Lines.Count());
                            MessageBox.Show(Niebieskie.Lines[t]);
                            switch (t)
                            {
                                case 0:
                                    {
                                        Gracze[actualnygracz].TakeMoney(400);
                                        break;
                                    }
                                case 1:
                                    {
                                        Gracze[actualnygracz].GiveMoney(200);
                                        break;
                                    }
                                case 2:
                                    {
                                        foreach (var a in Gracze)
                                        {
                                            a.TakeMoney(20);
                                        }
                                        Gracze[actualnygracz].GiveMoney(Gracze.Count * 20 - 20);
                                        break;
                                    }
                                case 3:
                                    {
                                        if (Gracze[actualnygracz].ActualPosition <= 31)
                                        {
                                            Gracze[actualnygracz].ActualPosition = 31;
                                        }
                                        else
                                        {
                                            Gracze[actualnygracz].GiveMoney(400);
                                            Gracze[actualnygracz].ActualPosition = 31;
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Gracze[actualnygracz].GiveMoney(400);
                                        break;
                                    }
                                case 5:
                                    {
                                        Gracze[actualnygracz].TakeMoney(20);
                                        break;
                                    }
                                case 6:
                                    {
                                        Gracze[actualnygracz].FreeWiezenie = true;
                                        break;
                                    }
                                case 7:
                                    {
                                        Gracze[actualnygracz].ActualPosition = 0;
                                        break;
                                    }
                                case 8:
                                    {
                                        Gracze[actualnygracz].GiveMoney(20);
                                        break;
                                    }
                                case 9:
                                    {
                                        Gracze[actualnygracz].GiveMoney(200);
                                        break;
                                    }
                                case 10:
                                    {
                                        Gracze[actualnygracz].ActualPosition = 39;
                                        break;
                                    }
                                case 11:
                                    {
                                        Gracze[actualnygracz].TakeMoney(20);
                                        break;
                                    }
                                case 12:
                                    {
                                        Gracze[actualnygracz].GiveMoney(200);
                                        break;
                                    }
                                case 13:
                                    {
                                        Gracze[actualnygracz].GiveMoney(40);
                                        break;
                                    }
                                case 14:
                                    {
                                        Gracze[actualnygracz].GiveMoney(50);
                                        break;
                                    }
                                case 15:
                                    {
                                        Gracze[actualnygracz].TakeMoney(20);
                                        break;
                                    }
                            }

                        }
                        
                        if (Pol.WhitchPosition() == 8 || Pol.WhitchPosition() == 23 || Pol.WhitchPosition() == 37)
                        {
                            Random rnd = new Random();
                            int t = rnd.Next(0, Czerwone.Lines.Count());
                            MessageBox.Show(Czerwone.Lines[t]);
                            switch (t)
                            {
                                case 0:
                                    {
                                        Gracze[actualnygracz].TakeMoney((Gracze[actualnygracz].HotelNumber * 230) + (Gracze[actualnygracz].HouseNumber * 80));
                                        break;
                                    }
                                case 1:
                                    {
                                        Gracze[actualnygracz].TakeMoney((Gracze[actualnygracz].HotelNumber * 200) + (Gracze[actualnygracz].HouseNumber * 50));
                                        break;
                                    }
                                case 2:
                                    {
                                        Gracze[actualnygracz].ActualPosition = 15;
                                        break;
                                    }
                                case 3:
                                    {
                                        Gracze[actualnygracz].TakeMoney(30);
                                        break;
                                    }
                                case 4:
                                    {   
                                        Gracze[actualnygracz].ActualPosition -= 3;
                                        if (Gracze[actualnygracz].ActualPosition < 0) Gracze[actualnygracz].ActualPosition += 40;
                                        break;
                                    }
                                case 5:
                                    {
                                        Gracze[actualnygracz].ActualPosition = 1;
                                        break;
                                    }
                                case 6:
                                    {
                                        Gracze[actualnygracz].GiveMoney(200);
                                        break;
                                    }
                                case 7:
                                    {
                                        if (Gracze[actualnygracz].ActualPosition <= 31)
                                        {
                                            Gracze[actualnygracz].ActualPosition = 30;
                                        }
                                        else
                                        {
                                            Gracze[actualnygracz].GiveMoney(400);
                                            Gracze[actualnygracz].ActualPosition = 30;
                                        }
                                        break;
                                    }
                                case 8:
                                    {
                                        Gracze[actualnygracz].TakeMoney(300);
                                        break;
                                    }
                                case 9:
                                    {   
                                        if (Gracze[actualnygracz].ActualPosition < 7)
                                        {
                                            Gracze[actualnygracz].ActualPosition = 6;
                                        }
                                        else
                                        {
                                            Gracze[actualnygracz].GiveMoney(400);
                                            Gracze[actualnygracz].ActualPosition = 6;
                                        }
                                        break;
                                    }
                                case 10:
                                    {
                                        Gracze[actualnygracz].TakeMoney(40);
                                        break;
                                    }
                                case 11:
                                    {
                                        if (Gracze[actualnygracz].ActualPosition <= 24)
                                        {
                                            Gracze[actualnygracz].ActualPosition = 23;
                                        }
                                        else
                                        {
                                            Gracze[actualnygracz].GiveMoney(400);
                                            Gracze[actualnygracz].ActualPosition = 23;
                                        }
                                        break;
                                    }
                                case 12:
                                    {
                                        Gracze[actualnygracz].GiveMoney(100);
                                        break;
                                    }
                                case 13:
                                    {
                                        if (Gracze[actualnygracz].ActualPosition <= 36)
                                        {
                                            Gracze[actualnygracz].ActualPosition = 35;
                                        }
                                        else
                                        {
                                            Gracze[actualnygracz].GiveMoney(400);
                                            Gracze[actualnygracz].ActualPosition = 35;
                                        }
                                        break;
                                    }
                                case 14:
                                    {
                                        Gracze[actualnygracz].GiveMoney(300);
                                        break;
                                    }
                                case 15:
                                    {
                                        Gracze[actualnygracz].FreeWiezenie = true;
                                        break;
                                    }
                            }
                        }
                        Optiones(false, false, false, true);
                        break;
                    }
                case "Spec":
                    {
                        if ((Pol.WhitchPosition() == 6 || Pol.WhitchPosition() == 16 || Pol.WhitchPosition() == 26 || Pol.WhitchPosition() == 36) && Pol.whoisowner() == 9)
                        {
                            Optiones(true, false, false, true);
                        }
                        if ((Pol.WhitchPosition() == 6 || Pol.WhitchPosition() == 16 || Pol.WhitchPosition() == 26 || Pol.WhitchPosition() == 36) && Pol.whoisowner() != 9 && Pol.whoisowner() != actualnygracz)
                        {
                            int i = 0;
                            if (Pola[5].whoisowner() == Pol.whoisowner()) i++;
                            if (Pola[15].whoisowner() == Pol.whoisowner()) i++;
                            if (Pola[25].whoisowner() == Pol.whoisowner()) i++;
                            if (Pola[35].whoisowner() == Pol.whoisowner()) i++;
                            Gracze[actualnygracz].TakeMoney(200 + i * 50);
                            MessageBox.Show("Zapłaciłeś właśnie: " + (200 + i * 50).ToString() + "$.");
                            Optiones(true, false, false, true);
                        }
                        if ((Pol.WhitchPosition() == 13 || Pol.WhitchPosition() == 29) && Pol.whoisowner() == 9)
                        {
                            Optiones(true, false, false, true);
                        }
                        if ((Pol.WhitchPosition() == 13 || Pol.WhitchPosition() == 29) && Pol.whoisowner() != 9 && Pol.whoisowner() != actualnygracz)
                        {
                            int o = 0;
                            if (Pola[12].whoisowner() == Pol.whoisowner()) o++;
                            if (Pola[28].whoisowner() == Pol.whoisowner()) o++;
                            Gracze[actualnygracz].TakeMoney(200 + o * 100);
                            Optiones(false, false, false, false);
                            MessageBox.Show("Zapłaciłeś właśnie: " + (200 + o * 100).ToString() + "$.");
                        }

                        if (Pol.WhitchPosition() == 31 )
                        {
                            if (Gracze[actualnygracz].FreeWiezenie == true)
                            {
                                MessageBox.Show("Wychodzisz wolny z wiezenia, tracisz karte.");
                                Optiones(false, false, false, true);
                            }
                            else
                            {
                                Gracze[actualnygracz].Wiezienie = 2;
                                MessageBox.Show("Jesteś jeszcze w wiezieniu.");
                                Optiones(false, false, false, true);
                            }
                        }
                        if (Pol.WhitchPosition() == 11)
                        {
                            MessageBox.Show("Odwiedziny znajomego w areszcie.");
                            Optiones(false, false, false, true);
                        }

                        if (Pol.WhitchPosition() == 39)
                        {
                            MessageBox.Show("Płacisz podatek w wysokości 300$.");
                            Gracze[actualnygracz].TakeMoney(300);
                            Optiones(false, false, false, true);
                        }
                        break;
                    }

                default: 
                    {
                        Optiones(false, false, false, true);
                        break;
                    }
                case "Parking":
                    {
                        MessageBox.Show("Płacisz za parking 400$.");
                        Gracze[actualnygracz].TakeMoney(400);
                        Optiones(false, false, false, true);
                        break;
                    }
                case "ParkingFree":
                    {
                        Optiones(false, false, false, true);
                        break;
                    }
                    
            }
            MooveHorse(actualnygracz, 0);
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
            MooveHorse(actualnygracz, Convert.ToInt32(label1.Text));
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Gracze.Count <= 7)
            {
                textBox1.Text = "";
                pictureBox9.Image = imageList1.Images[0];
                groupBox1.Visible = true;
                textBox1.Focus();
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
            if (Gracze[id].ActualPosition >= 40)
            { 
                Gracze[id].ActualPosition -= 40;
                Gracze[id].GiveMoney(400);
            }
            Gracze[id].Pionek.Parent = Pola[Gracze[id].ActualPosition].Panelek;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Gracze.Add(new Gracz(textBox1.Text, 2000, temp1, Gracze.Count));
            imageList2.Images.Add(imageList1.Images[Someint]);
            imageList1.Images.RemoveAt(Someint);
            Gracze[Gracze.Count-1].Pionek.Image = imageList2.Images[Gracze[Gracze.Count-1].Figure];
            Gracze[Gracze.Count-1].Pionek.Visible = true;
            groupBox1.Visible = false;
            ListViewItem item = new ListViewItem(Gracze[temp1].Name);
            item.SubItems.Add(Gracze[temp1].CashState().ToString());
            item.SubItems.Add(0.ToString());
            item.SubItems.Add(0.ToString());
            item.SubItems.Add(0.ToString());
            listView1.Items.Add(item);
            temp1++;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Gracze.Count; i++)
            {
                MooveHorse(i, 0);
            }
            label3.Text = Gracze[0].Name;
            groupBox2.Visible = true;
            AddPlayer.Visible = false;
            button2.Visible = false;

        }

        public void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (var item in Gracze)
            {
                ListViewItem dane = new ListViewItem(item.Name);
                dane.SubItems.Add(item.CashState().ToString());
                dane.SubItems.Add(item.HowObject().ToString());
                dane.SubItems.Add(item.HouseNumber.ToString());
                dane.SubItems.Add(item.HotelNumber.ToString());
                listView1.Items.Add(dane);
            }
        }
        private void OwnerChange(int w, int r)
        {
            Label owner = new Label()
            {
                Text = Gracze[w].Name,
                Top = 70,
                Left = 5,
                AutoSize = true,
                Visible = true
            };
            Pola[r-1].Panelek.Controls.Add(owner);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Pola[Gracze[actualnygracz].ActualPosition].NewOwner(actualnygracz);
            Gracze[actualnygracz].BuyObject(Pola[Gracze[actualnygracz].ActualPosition].WhitchPosition(), Pola[Gracze[actualnygracz].ActualPosition].HowPrice());
            OwnerChange(actualnygracz, Pola[Gracze[actualnygracz].ActualPosition].WhitchPosition());
            Optiones(false, false, false, true);
            UpdateListView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pola[Gracze[actualnygracz].ActualPosition].NewHouse();
            Gracze[actualnygracz].BuyHouse();
            Optiones(false, false, false, true);
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoNothing_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Optiones(false, false, false, false);
            NextPlayer();
            UpdateListView();
        }

        private void BuyHotel_Click(object sender, EventArgs e)
        {
            Pola[Gracze[actualnygracz].ActualPosition].NewHouse();
            Gracze[actualnygracz].BuyHotel(Pola[Gracze[actualnygracz].ActualPosition].HowHotel());
            Optiones(false, false, false, true);
            UpdateListView();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) AddPlayer.PerformClick();
        }

      
        
    }
}
