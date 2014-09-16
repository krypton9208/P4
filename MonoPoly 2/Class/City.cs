using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2
{
    class City : Pole
    {
        protected int HouseCost { get; set; }
        protected int HotelCost { get; set; }
        protected int HotelNumber { get; set; }
        protected int HouseNumber { get; set; }
        protected string Country { get; set; }
        protected Player Owner { get; set; }
        public City(string name,int pos, int cost, int housecost, int hotelcost, string country, string img)
        {
            Name = name;
            Pos = pos;
            Cost = cost;
            HouseCost = housecost;
            HotelCost = hotelcost;
            Country = country;
            ImgString = img;
        }

        public int GetHouseCost { get { return HotelCost; } }
        public int GetHotelCost { get { return HotelCost; } }
        public int GetHouseNumber { get { return HouseNumber; } }
        public int GetHotelNumber { get { return HotelNumber; } }
    }

}
