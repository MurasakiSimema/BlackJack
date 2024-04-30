using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Banco
    {
        public List<Carta> Cards { get; set; }
        public int Value;
        public Banco()
        {
            Value = 0;
            Cards = new List<Carta>();
        }
        public void Add(Carta c)
        {
            Cards.Add(c);
            Value += c.Value;
        }
        public bool Next(Random random)
        {
            bool next;

            ////Per regole del banco
            if (Value < 17)
                next = true;
            else
                next = false;


            return next;
        }
    }
}
