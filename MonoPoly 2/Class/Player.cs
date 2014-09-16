using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2
{
   
    public class Player
    {
         private string Name {get;set;}
         private Guid ID { get; set; }
         private int ActPos { get; set; }
         private int Cash { get; set; }
         public Player(string name, int id)
         {
             Name = name;
             ID = Guid.NewGuid();
             ActPos = 0;
             Cash = 5000;
         }

        public Player()
         {
             ID = Guid.Empty;
         }

         public string GetPlayerName() { return Name; }
         public int GetPlayerPos() { return ActPos; }
         public int CashState() { return Cash; }
         protected int RailwaysNumber { get; set; }
         public int GetRailwaysNumber
         {
             set
             {
                 RailwaysNumber += value;
             }
             get
             {
                 return RailwaysNumber;
             }
         }
         public Guid GetPlayerID { get { return ID; } }
         public void GivePlayerMoney(int c) { Cash += c; }
         public Boolean TakePlayerMoney(int d) 
         {
             if (Cash - d <= 0)
             {
                 Cash -= d;
                 return false;

             }
             Cash -= d;
             return true;
         }
         public void MovePlayer(int t)
         {
             if (ActPos + t >= 40)
             {
                 ActPos += t - 40;
             }
             else
             {
                 ActPos += t;
             }
         }
         public int RollTheDice()
         {
             Random rnd = new Random();
             MovePlayer(rnd.Next(1, 13));
             return Convert.ToInt32(rnd);
         }
         
    }
}
