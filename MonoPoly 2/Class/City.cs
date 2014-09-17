using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonoPoly_2.Class
{
    class City : Pole
    {
        //protected int Number;
        //protected string Name;
        //protected string ImgString;
        protected Guid OwnerID;
        protected int Cost;
        protected int HouseCost;
        protected int HotelCost;
        protected int HouseNumber;
        protected int HotelNumber;

        public City(int number, string name, string img, int cost, int hotelcost, int housecost)
        {
            Number = number;
            Name = name;
            ImgString = img;
            OwnerID = Guid.Empty;
            Cost = cost;
            HotelCost = housecost;
            HouseCost = housecost;
            HouseNumber = 0;
            HotelNumber = 0;
        }

        public void BuyCity(Guid owner)
        {
            OwnerID = owner;
        }

        public int BuyHouse
        {
            get
            {
                HouseNumber++;
                return HouseCost;
            }
        }
        public int BuyHotel
        {
            get
            {
                HotelNumber++;
                return HotelCost;
            }
        }
        public int GetHouseNumber { get { return HouseNumber; } }
        public int GetHotelNumber { get { return HotelNumber; } }
        public int GetHouseCost { get { return HouseCost; } }
        public int GetHotalCost { get { return HotelCost; } }

        public MonoPoly_2.Class.IActions.Actions[] Visit(Guid Guest)
        {
            MonoPoly_2.Class.IActions.Actions[] temp = new IActions.Actions[4];
            if (Guest == OwnerID)
            {
                if (GetHouseNumber < 4) temp[0] = IActions.Actions.BuyHouse;
                if (GetHouseNumber == 4  &&  GetHotelNumber < 4) temp[0] = IActions.Actions.BuyHotel;
            }
            if (Guest != OwnerID)
            {
                if (OwnerID == Guid.Empty) temp[1] = IActions.Actions.BuyThisThink;
                if (OwnerID == Guid.Empty) temp[2] = IActions.Actions.NextPlayer;
                if (OwnerID == Guid.Empty) temp[3] = IActions.Actions.FreeVisit;
                if (OwnerID != Guid.Empty) temp[1] = IActions.Actions.PayForVisit;
                
            }
            Array.Sort(temp);
            return temp; 
        }
    }
}
