using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace BlackJack
{
    [System.Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Player))]
    public class Game
    {
        public static Deck deck;
        //public Player player;
        public Dealer dealer;
        public int numHands;
        public int currentHand;
        public List<Player> playerList;

        public Game()
        {
            StartUp();
        }

        //public Deck GetDeck()
        //{
        //    return deck;
        //}

        public void StartUp()
        {
            numHands = 1;
            currentHand = 1;
            deck = new Deck(1);
            //player = new Player();
            playerList = new List<Player>();
            playerList.Add(new Player());
            dealer = new Dealer();
            //intialize money, start with two cards for player and 2 cards with dealer with one face down
            // User can hit until satisfied or busts
            // Dealer then hits until satisfied or busts

            //create instace of deck class and call the shuffle method
            BlackJack.disableHitStand();
            BlackJack.disableBetting();
            BlackJack.initAddMoneyCmbBox();
            //Intilaize money


            //Intialize cards in dealer's and player's hands
            //Deal();
        }


        public void Deal(bool isRigged)
        {
            if (!isRigged)
            {
                for (int x = 0; x < 2; x++)
                {
                    playerList[currentHand -1].Hit();
                    dealer.Hit();
                }
            }

            if ( dealer.hand[0].CardValue == 11 )
            {//able to have insurance
                insuranceCheck();
            }

            else if( playerList[currentHand-1].hand[0].Name == playerList[0].hand[1].Name)
            { //able to split pairs
                if(playerList[currentHand -1].money >= playerList[currentHand-1].bet)
                {
                    BlackJack.enableSplit();
                    //BlackJack.blackJack.disableHitStand();
                }
            }
        }

        public void newHand()
        {
            BlackJack.newHandLabelReset();

            if(playerList.Count() >= 2)
            {
                playerList.RemoveAt(1);
            }
            try
            {
                playerList[currentHand - 1].reset();
            }
            catch { }//Might have to handle exception of replacing other hands
            dealer.reset();
            deck.fillDeck();
            BlackJack.blackJack.resetPictures();
            BlackJack.enableBetting();
        }

        public void riggedHand( int player1, int player2, int dealer1, int dealer2 )
        {
            BlackJack.newHandLabelReset();
            playerList[currentHand-1].reset();
            dealer.reset();
            deck.fillDeck();

            playerList[currentHand-1].hand.Add(deck.RigDeck(player1));
            playerList[currentHand-1].hand.Add(deck.RigDeck(player2));
            dealer.hand.Add(deck.RigDeck(dealer1));
            dealer.hand.Add(deck.RigDeck(dealer2));
        
        }

        private void insuranceCheck()
        {
            BlackJack.enableInsurance();
        }

        public void dealerBlackJack()
        {
            dealer.updateScore();
            if ( dealer.score == 21 )
            {
                BlackJack.blackJack.showDealerCards();

                for ( int i = 0; i < playerList.Count(); i++ )
                {
                    if ( playerList[i].isInsured )
                    {
                        playerList[i].payInsurance();
                        playerList[i].isInsured = false;
                        // BlackJack.blackJack.PlayerWin(playerList[i]);
                        newHand();
                        BlackJack.blackJack.resetPictures();
                        BlackJack.blackJack.updateMoneyLabels(playerList[i]);
                    }
                    else
                    {
                        BlackJack.blackJack.PlayerLose(playerList[i]);
                        BlackJack.blackJack.updateMoneyLabels(playerList[i]);
                    }
                }
            }
        }

        public void split()
        {
            Player playerSplit = new Player();
            playerSplit.name = playerList[currentHand-1].name;
            playerList.Add(playerSplit);
//            playerList[1].name = playerList[0].name.ToString() + " hand 2";

            playerList[1].hand.Add(playerList[0].hand[1]);
            playerList[0].hand.RemoveAt(1);
            playerList[0].doBet(playerList[0].previousBet);
            //BlackJack.blackJack.betAgain();
            numHands += 1;
            
            //move second card to right hand
            BlackJack.blackJack.PlayerPoint.X += 100;
            BlackJack.blackJack.PlayerPoint.Y -= 8;
            BlackJack.blackJack.playerPics[1].Location = BlackJack.blackJack.PlayerPoint;
            BlackJack.blackJack.playerPics[1].Update();

            //Set position to second hand, second card and add card
            BlackJack.blackJack.resetPlayerPoints();
            BlackJack.blackJack.PlayerPoint.X += BlackJack.cardXchange + 118;
            BlackJack.blackJack.PlayerPoint.Y += 8;
            //Add card to second hand and display
            //player = playerList[1];
            currentHand = 2;
            BlackJack.blackJack.AddCard(playerList[1].Hit(), false);

            //Set position to first hand, second card and add card
            currentHand = 1;
            BlackJack.blackJack.resetPlayerPoints();
            BlackJack.blackJack.PlayerPoint.X += BlackJack.cardXchange;
            BlackJack.blackJack.PlayerPoint.Y += 8;
            BlackJack.blackJack.AddCard(playerList[0].Hit(), false);

            //set position to first hand, third card
            //player = playerList[0];
            currentHand = 1;
            BlackJack.blackJack.resetPlayerPoints();
            BlackJack.blackJack.PlayerPoint.X += BlackJack.cardXchange * 2;
            BlackJack.blackJack.PlayerPoint.Y += 8 * 2;
        }
    }
}
