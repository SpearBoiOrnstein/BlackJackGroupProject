using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlackJack
{
    [System.Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Card))]
    public class Users
    {
        public string name { get; set; }
        public List<Card> hand { get; set; }
        public int score { get; set; }
        //public Deck deck = { get; set; }//Game.deck;

        public Users()
        {
            hand = new List<Card>();
        }

        public Card Hit()
        {
            Card card = GetCard();
            updateScore();
            return card;
        }
        public Card GetCard()
        {
            Card c = Game.deck.GetCard();
            //Card c = Game.deck.RigDeck(3);
            hand.Add(c);
            return c;
        }

        public Boolean BustCheck()
        {
            if (score >= 22)
            {
                for (int x = 0; x < hand.Count(); x++)
                    if (hand[x].CardValue == 11)
                    {
                        hand[x].CardValue = 1;  //If above 21 and has Ace make the Ace worth 1 instead of 11
                        this.updateScore();
                        return BustCheck();
                    }
                return true;
            }
            else
                return false;
        }

        public void updateScore()
        {
            score = 0;
            for(int i = 0; i < hand.Count; i++)
            {
                score += hand[i].CardValue;
            }
        }

        public virtual void reset()
        {
            score = 0;
            hand.Clear();
        }

    }

}
