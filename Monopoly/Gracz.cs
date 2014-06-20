﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Monopoly
{
    public class Gracz
    {
        public string Name { get; set; }
        private  int[] Wposiadaniu = new int[35];
        private double Cash { get; set; }
        public int Figure { get; set; }

        public PictureBox Pionek;
        public int ActualPosition { get; set; }

        private int SetLeftToPionek(int x)
        {
            if (x % 2 != 0) return 50;
            else return 10;
        }
        private int SetTopToPionek(int x)
        {
            if (x < 2) return 10;
            else if (x < 4) return 30;
            else if (x < 6) return 60;
            else return 70;
        }
        public void GiveMoney(int ile)
        {
            Cash += ile;
        }
        public double CashState()
        {
            return Cash;
        }
        public Gracz(string x, double k, int f, int nrGracza)
        {
            Name = x;
            Cash = k;
            Figure = f;
            Pionek = new PictureBox()
            {
                Left = SetLeftToPionek(nrGracza),
                Top = SetTopToPionek(nrGracza),
                Width = 28,
                Height = 30,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
                
        }


      


    }
}