﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public class Pole
    {
        public enum Types {City, Quest, Start, Parking, ParkingFree, Spec}
        private int Position { get; set; }
        private int Price { get; set; }
        private string ImgFIle { get; set; }
        private int OwnerId { get; set; }
        private int HouseNum { get; set; }
        private int HotelNum { get; set; }
        private Types Type { get; set; }

      
        public Panel Panelek;
        public int x { get; set; }
        public int y { get; set; }
        public int HotelPrice { get; set; }
        public string Name { get; set; }
        public Pole(int a, int b, string c, Types d, string e, int f)
        {
            Position = a;
            Price = b;
            ImgFIle = c;
            Type = d;
            Name = e;
            OwnerId = 9;
            HotelPrice = f;
        }
        public void NewOwner(int a)
        {
            HouseNum = 0;
            HotelNum = 0;
            OwnerId = a;
            
        }
        public void NewHouse()
        {
            
            HouseNum++;
        }
        public void NewHotel()
        {
            HouseNum = 0;
            HotelNum++;
        }

        public int HowPrice()
        {
            return Price;
        }
        public int HowHotel()
        {
            return HotelNum;
        }
        public int HowHouse()
        {
            return HouseNum;
        }
        public int whoisowner()
        {
            return OwnerId;
        }
        public int WhitchPosition()
        {
            return Position;
        }

        public string WhatType()
        {
            return Type.ToString();
        }

    }
}
