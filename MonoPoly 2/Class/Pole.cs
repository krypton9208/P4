using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2
{
    class Pole : Player
    {
        public enum QuestType { PayFor, Cash, FreePrison, GoTo }

        protected string Name { get; set; }
        protected int Pos { get; set; }
        protected int Cost { get; set; }

        protected string ImgString { get; set; }

        public string GetImgString { get { return ImgString; } }
    }
}
