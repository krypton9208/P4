using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2.Class
{
    class BlueQuest : Pole
    {
        
        private string Text { get; set; }
        private QuestType Type { get; set; }
        private int Param { get; set; }
        public BlueQuest (string text, QuestType type, int param, string name, int pos)
        {
            Text = text;
            Type = type;
            Param = param;
            Name = name;
            Cost = 0;
            Pos = pos;
        }

    }
}
