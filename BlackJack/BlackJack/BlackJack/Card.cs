using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum name
    {
        _ace = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _jack = 11,
        _queen = 12,
        _king = 13

    };
    public enum suit
    {
        spades = 1,
        diamonds = 2,
        hearts = 3,
        clubs = 4
    };
    public class Card
    {
        public int CardValue;
        public name Name { get; set; }
        public suit Suit { get; set; }
        public string imagestring { get; set;}
        public Card()
        {
                
        }
        public Card(int s, int v)
        {
            this.Suit = (suit)s;
            this.Name = (name)v;
            if (v >= 11)
                this.CardValue = 10;
            else if (v == 1)
                this.CardValue = 11;
            else
                this.CardValue = v;
            
        }
        public Image GetImage()
        {
            Image ImageFromString;
            ResourceManager rm = Images.ResourceManager;
            string i = Name.ToString().Replace("_", "").ToLower() + "_of_" + Suit.ToString().ToLower() + "";
            Bitmap bitmap = new Bitmap((Bitmap)rm.GetObject(i));
            ImageFromString = (Image)bitmap;
            return ImageFromString;
        }
    }
   
}
