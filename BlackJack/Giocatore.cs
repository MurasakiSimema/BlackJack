using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Giocatore
    {
        public List<Carta> Cards { get; set; }
        public int Value;
        public Giocatore()
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

            if (Value <= 11)
                next = true;
            else if (Value <= 15)
                next = random.Next(0, 100) < 60;
            else if (Value <= 17)
                next = random.Next(0, 100) < 35;
            else if (Value <= 18)
                next = random.Next(0, 100) < 20;
            else if (Value <= 20)
                next = random.Next(0, 100) < 10;
            else if (Value < 20)
                next = random.Next(0, 100) < 1;
            else
                next = false;


            return next;
        }
    }
}
