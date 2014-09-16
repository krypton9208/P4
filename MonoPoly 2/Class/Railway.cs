using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2.Class
{
    class Railway : Pole
    {
        private Player Owner { get; set; }
        public Railway (string name, int cost, int pos, string img)
        {
            Name = name;
            Cost = cost;
            Pos = pos;
            ImgString = img;
        }

        public void OwnerChange(Player newowner)
        {
            if (newowner.GetPlayerID != Guid.Empty)
            {
                Owner = newowner;
                Owner.GetRailwaysNumber += 1;
            }
        }

        public int Visit(Player visitor)
        {
            if (this.Owner.GetPlayerID == visitor.GetPlayerID) return 0;
            else
            {
                return this.Owner.GetRailwaysNumber * Cost;
            }
        }
    }
}
