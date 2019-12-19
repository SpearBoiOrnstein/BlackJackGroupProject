using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    [System.Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Card))]
    public class Deck
    {
        public List<Card> cardList = new List<Card>();
        public Random random;
        public Deck()
        {
            //do nothing constructor
        }

        public Deck(int numDecks)
        {
            cardList.Clear();
            for (int j = 0; j < numDecks; j++)
                fillDeck();
            random = new Random();
        }

        public void fillDeck()
        {
            cardList.Clear();   
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 13; j++)
                {
                    cardList.Add(new Card(i, j));
                }
            }
        }
        public Card GetCard()
        {
            int id = random.Next(0, cardList.Count());
            Card c = cardList[id];
            cardList.RemoveAt(id);
            return c;
        }
        public Card RigDeck(int faceValue)
        {
            int q = 0;
            Card card = cardList[q];
            for (int i = 0; i < cardList.Count(); i++)
            {
                if(cardList[i].CardValue == faceValue)
                {
                    card = cardList[i];
                    q = i;
                }
            }
            cardList.RemoveAt(q);
            return card;
        }
    }
}
