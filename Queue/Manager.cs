using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Manager
    {
        Queue<Card> cards = new Queue<Card>();

        public Manager()
        {
            Card card1 = new Card("Card1");
            Card card2 = new Card("Card2");
            Card card3 = new Card("Card3");
            Card card4 = new Card("Card4");
            Card card5 = new Card("Card5");

            cards.Enqueue(card1);
            cards.Enqueue(card2);
            cards.Enqueue(card3);
            cards.Enqueue(card4);
            cards.Enqueue(card5);
        }

        public void EnqueueCard(string add)
        {
            cards.Enqueue(new Card(add));
        }

        public void DequeueCard()
        {
            cards.Dequeue();
        }

        public int NumberOfItems()
        {
            return cards.Count;
        }

        public string MinMaxItems()
        {
            List<Card> card = cards.ToList();

            Card max = card[card.Count() - 1]; 

            Card min =  cards.Peek();
                

            return $"{min}{max}";
        }
        
        public string FindItem(string cardname)
        {
            string temp = " ";
            List<Card> card = cards.Where(x => x.CardName.Contains(cardname)).ToList();

            if (card.Count() != 0)
            {
                foreach (Card i in card)
                {
                     
                    temp = temp + i.CardName;

                }

            }

            return temp;
        }

        public string PrintAll()
        {
            string temp = "";

            foreach (Card i in cards)
            {
                temp += i.CardName + "\n";
                
            }

            return temp;
        }



        

    }
}
