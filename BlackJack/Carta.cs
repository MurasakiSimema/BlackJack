using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Carta
    {
        public Image Image { get; set; }
        public int Value { get; set; }
        public Carta()
        {

        }
        public Carta(Image i, int v)
        {
            Image = i;
            Value = v;
        }
    }
}
