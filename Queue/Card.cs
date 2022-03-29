using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Card
    {
        private string cardName;

        public string CardName { get => cardName; set => cardName = value; }


        public Card(string cardName)
        {
            CardName = cardName;
        }
    }
}
