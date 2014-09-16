using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoPoly_2.Class
{
    class RedQuest : Pole
    {
        private string Text { get; set; }
        public QuestType Type { get; set; }
        private int Param;
        public RedQuest (string text, QuestType type, int param, string name, int pos)
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
