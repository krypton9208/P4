using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2.Class
{
    class Player: IActions
    {
        
        private int Money;
        private int ActualPosition;
        private string Name;
        private Guid ID;
        private int CounterID;

        public Player (string name, int counterid)
        {
            Money = 5000;
            ActualPosition = 1;
            Name = name;
            ID = Guid.NewGuid();
            CounterID = counterid;
        }

        public int NextStep()
        {
            int a, b, suma = 0;
            do
            {

                Random t = new Random();
                a = t.Next(0, 7);
                System.Threading.Thread.Sleep(200);
                Random y = new Random();
                b = y.Next(0, 7);
                suma += a + b;
            }
            while (a == b);
            return suma;

        }
        public void NewPosition(int x)
        {
            if (ActualPosition + x >= 40)
            {
                ActualPosition += x - 40;
            }
            else
                ActualPosition += x;
        }
        public bool GetMoneyFromAccount(int Fine)
        {
            if (Fine < Money)
            {
                Money -= Fine;
                return true;
            }
            else
            {
                Money -= Fine;
                return false;
            }
        }
        public void GetMoneyToAccount( int Pewter)
        {
            Money += Math.Abs(Pewter);
        }
        public int GetAccountInfo
        {
            get
            {
                return Money;
            }
        }
        public string GetPlayerName
        {
            get
            {
                return Name;
            }
        }
        public Guid GetPlayerID
        {
            get
            {
                return ID;
            }
        }
        public int GetPlayerCounterID
        {
            get
            {
                return CounterID;
            }
        }
    }
}
