using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace BlackJack
{
    public partial class BlackJack : Form
    {
        public Game game;
        public Point PlayerPoint;
        public Point DealerPoint;
        public static BlackJack blackJack;
        public BlackJack nonstatic;
        public List<PictureBox> dealerPics;
        public List<PictureBox> playerPics;
        public const int cardXchange = 18;

        public BlackJack()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
            blackJack = this;
            nonstatic = this;
            //btnBet.Enabled = false;
            //Load the login forms

            //btnBet.Enabled = true;
            game = new Game();
            PlayerPoint.X = picPlayerHand.Location.X;
            PlayerPoint.Y = picPlayerHand.Location.Y;
            DealerPoint.X = picDealerHand.Location.X;
            DealerPoint.Y = picDealerHand.Location.Y;
            dealerPics = new List<PictureBox>();
            playerPics = new List<PictureBox>();

            this.FormClosing += fileTypeDialog_FormClosing;

            disableInsurance();
            disableSplit();
            initRiggingComboBoxes();
            disableRigging();
            disableHitStand();
            lblDealerRig.Visible = false;
            lblPlayerRig.Visible = false;
        }
        private void fileTypeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (lblUser1.Text != "Username")
            {
                string path = game.playerList[0].Username + ".xml";
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Game));
                TextWriter textWriter = new StreamWriter(path);
                xmlSerializer.Serialize(textWriter, game);
            }
            
        }
         private bool SavedState(string name)
        {
            string path = name + ".xml";
            if (File.Exists(path))
            {
                 XmlSerializer xmlSerializer = new XmlSerializer(typeof(Game));

                 using (var sr = new StreamReader(path))
                 {
                     Game g = (Game)xmlSerializer.Deserialize(sr);
                    //close this form
                    game = g;


                    //If there are any cards display them
                    displayCards();

                    //Figure out which buttons need to be enabled or disabled
                    SetState();

                    //Possibly need to check for insurance or split pairs

                    //File.Delete(path);
                 }
                return true;
            }
            return false;
        }

        private void SetState()
        {
            //lblPlayerMoney.Text = game.player.money.ToString();
            updateMoneyLabels(game.playerList[game.currentHand - 1]);
            if(game.currentHand-1==0)
            {
                if(game.playerList[game.currentHand-1].hand.Count==0)
                {
                    if(game.playerList.Count==2)
                    {
                        game.playerList.RemoveAt(0);
                    }
                }
            }
            if (game.playerList[game.currentHand - 1].hand.Count>0)
            {
                enableHitStand();
            }
            else
            {
                enableBetting();
            }
            updateMoneyLabels(game.playerList[0]);
            lblUser1.Text = game.playerList[0].Username;
        }
        private void Close_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        public void resetPictures()
        {
            PlayerPoint.X = picPlayerHand.Location.X;
            PlayerPoint.Y = picPlayerHand.Location.Y;
            DealerPoint.X = picDealerHand.Location.X;
            DealerPoint.Y = picDealerHand.Location.Y;
            dealerPics.Clear();

            ClearPictureBoxes(this);
            //       Controls.
            //      ClearPictureBoxes(BlackJack.blackJack);
            //      ClearPictureBoxes(BlackJack.blackJack);
        }
        public void resetPlayerPoints()
        {
            PlayerPoint.X = picPlayerHand.Location.X;
            PlayerPoint.Y = picPlayerHand.Location.Y;
        }
        private void ClearPictureBoxes(Control parent)
        {

            for (int count = this.Controls.Count - 1; count >= 0; count--)
            {
                if (parent.Controls[count] is PictureBox)
                {
                    Controls.Remove(parent.Controls[count]);
                }
            }

        }
        private void displayCards()
        {
            for (int i = 0; i < game.playerList.Count(); i++)
            {
                for (int a = 0; a < game.playerList[i].hand.Count(); a++)
                    AddCard(game.playerList[i].hand[a], false);
                //resetPictures();
            }
            for (int a = 0; a < game.dealer.hand.Count(); a++)
                AddCard(game.dealer.hand[a], true);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            
            if (game.playerList.Count() > game.currentHand)
            {
                game.currentHand++;
                //game.player = game.playerList[1];
                PlayerPoint.X = picPlayerHand.Location.X + 100 + cardXchange*3;
                PlayerPoint.Y = picPlayerHand.Location.Y + 8*3;
            }
            else
            {
                disableHitStand();
                //Check if hit split pairs
                //have dealers turn. dealer always hits, until 17

                lblDealerHandScore.Visible = true;
                game.dealer.updateScore();
                lblDealerHandScore.Text = game.dealer.score.ToString();
                showDealerCards();
                lblDealerHandScore.Update();

                Thread.Sleep(1000);
                while (game.dealer.score < 17)
                {
                    Card card = game.dealer.Hit();
                    AddCard(card, true);
                    game.dealer.BustCheck();
                    Thread.Sleep(500);
                }

                if (game.dealer.BustCheck())
                {
                    for (int i = 0; i < game.playerList.Count(); i++)
                        PlayerWin(game.playerList[i]);
                }
                else
                    CheckWinner(false);

                Thread.Sleep(500);
                lblDealerHandScore.Visible = false;
            }
        }

        internal void AddCard(Card card, bool isDealer)
        {//display the card

            //Add Picture box with new card, 
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = card.GetImage();
            //pictureBox.Image = Images.ace_of_clubs;
            if (!isDealer)
            {
                PlayerPoint.X += cardXchange;
                PlayerPoint.Y += 8;
                pictureBox.Location = PlayerPoint;

                //ADD FUNCTION HERE
               // lblPlayerHandScore.Text = game.player.score.ToString();
                updatePlayerHandScoreLabel(game.playerList[game.currentHand - 1]);
                playerPics.Add(pictureBox);
            }
            else
            {
                DealerPoint.X += cardXchange;
                DealerPoint.Y += 8;
                pictureBox.Location = DealerPoint;
                lblDealerHandScore.Text = game.dealer.score.ToString();
                if (dealerPics.Count() == 1)
                    pictureBox.Image = Images.back;
                dealerPics.Add(pictureBox);
            }
            pictureBox.Size = new Size(80, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.White;
            Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Card card = game.playerList[game.currentHand-1].Hit();
            AddCard(card, false);
            if (game.playerList[game.currentHand - 1].BustCheck() == true)    //If player busts
            {
                blackJack.disableHit();
                if (game.playerList.Count() > 1)    //Handle Split Pairs Exception
                {
                    //Move to next hand if you bust, display on "current hand" bust
                    string displayMsg = "Sorry you busted on hand " + game.currentHand.ToString() + ".";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(displayMsg, "Sorry pal!", buttons);
                    game.currentHand++;     //Move to next hand
                    Thread.Sleep(1500);

                }

                else
                { 
                //Lose
                // display bust pop up (form)
                    showDealerCards();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Sorry you've busted!", "You Lose!", buttons);
                // display dealer hand, then reset reset hand 
                    Thread.Sleep(1500);
                // if not bust move to dealer bust
                    PlayerLose(game.playerList[0]);

                    
                }
            }

            //lblPlayerHandScore.Text = game.player.score.ToString();
            try
            {
                updatePlayerHandScoreLabel(game.playerList[game.currentHand - 1]);
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void disableHit()
        {
            blackJack.btnHit.Enabled = false;
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            int settingBet = Convert.ToInt32(lblPreviousBet.Text);
            settingBet += 10;
            if (settingBet > Convert.ToInt32(lblPlayerMoney.Text))
                settingBet = Convert.ToInt32(lblPlayerMoney.Text);
            lblPreviousBet.Text = settingBet.ToString();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            int settingBet = Convert.ToInt32(lblPreviousBet.Text);
            settingBet -= 10;
            if (settingBet < 0)
                settingBet = 0;
            lblPreviousBet.Text = settingBet.ToString();
        }

        private void btnAdd10_Click(object sender, EventArgs e)
        {
            int settingBet = Convert.ToInt32(lblPreviousBet.Text);
            settingBet += 100;
            if (settingBet > Convert.ToInt32(lblPlayerMoney.Text))
                settingBet = Convert.ToInt32(lblPlayerMoney.Text);
            lblPreviousBet.Text = settingBet.ToString();
        }

        private void btnSub10_Click(object sender, EventArgs e)
        {
            int settingBet = Convert.ToInt32(lblPreviousBet.Text);
            settingBet -= 100;
            if (settingBet < 0)
                settingBet = 0;
            lblPreviousBet.Text = settingBet.ToString();
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            int settingBet = Convert.ToInt32(lblPreviousBet.Text);
            settingBet += 1000;
            if (settingBet > Convert.ToInt32(lblPlayerMoney.Text))
                settingBet = Convert.ToInt32(lblPlayerMoney.Text);
            lblPreviousBet.Text = settingBet.ToString();
        }

        private void btnSub100_Click(object sender, EventArgs e)
        {
            int settingBet = Convert.ToInt32(lblPreviousBet.Text);
            settingBet -= 1000;
            if (settingBet < 0)
                settingBet = 0;
            lblPreviousBet.Text = settingBet.ToString();
        }

        public void betAgain()
        {
            btnBet_Click(null, null);
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            game.playerList[game.currentHand - 1] = game.playerList[0];
            if (game.playerList.Count() > 1)
                game.playerList.RemoveAt(1);
            disableBetting();
            int bet = Convert.ToInt32(lblPreviousBet.Text);
            if (bet > game.playerList[game.currentHand - 1].money)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("You must have the amount you are trying to bet", "Betting Error", button);
                enableBetting();
            }
            else if ( bet < 1 )
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("You must bet a value greater than that.", "Betting Error", button);
                enableBetting();
            }
            else
            {
                game.playerList[game.currentHand - 1].doBet(bet);
                game.playerList[game.currentHand - 1].previousBet = bet;
                lblPlayerBetUser1.Text = bet.ToString();
                UpdatePlayerMoney(game.playerList[game.currentHand - 1]);
                //lblPlayerMoney.Text = game.player.money.ToString();
                updateMoneyLabels(game.playerList[game.currentHand - 1]);
                updateMoneyLabels(game.playerList[game.currentHand - 1]);
                game.Deal(false);
                displayCards();
                if ( game.playerList[game.currentHand - 1].score == 21 )
                    PlayerBlackJack(game.playerList[game.currentHand - 1]);
                else
                    enableHitStand();
            }
        }

        public static void newHandLabelReset()
        {
            blackJack.lblPlayerBetUser1.Text = "0";
            blackJack.lblPlayerHandScore.Text = "0";
            blackJack.lblDealerHandScore.Text = "0";
        }

        public void showDealerCards()
        {
            for (int i = 0; i < dealerPics.Count(); i++)
            {
                dealerPics[i].Image = game.dealer.hand[i].GetImage();
                dealerPics[i].Update();
            }

        }
        public static void disableHitStand()
        {
            blackJack.btnHit.Enabled = false;
            blackJack.btnStand.Enabled = false;
        }
        public static void enableHitStand()
        {
            blackJack.btnHit.Enabled = true;
            blackJack.btnStand.Enabled = true;
        }
        public static void disableBetting()
        {
            blackJack.btnBet.Enabled = false;
            blackJack.btnAdd10.Enabled = false;
            blackJack.btnAdd100.Enabled = false;
            blackJack.btnAdd1000.Enabled = false;
            blackJack.btnSub10.Enabled = false;
            blackJack.btnSub100.Enabled = false;
            blackJack.btnSub1000.Enabled = false;
            blackJack.cmbAddMoney.Enabled = false;
            blackJack.btnAddMoney.Enabled = false;
        }
        public static void enableBetting()
        {
            blackJack.btnBet.Enabled = true;
            blackJack.btnAdd10.Enabled = true;
            blackJack.btnAdd100.Enabled = true;
            blackJack.btnAdd1000.Enabled = true;
            blackJack.btnSub10.Enabled = true;
            blackJack.btnSub100.Enabled = true;
            blackJack.btnSub1000.Enabled = true;
            blackJack.cmbAddMoney.Enabled = true;
            blackJack.btnAddMoney.Enabled = true;
            disableHitStand();
        }
        internal void PlayerWin(Player player)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("You Win " + player.name.ToString() + "!", "YAAAAAY!!!", button);
            player.addMoney(player.previousBet * 2);
            UpdatePlayerMoney(player);
            resetPictures();
            game.newHand();
        }
        internal void PlayerLose(Player player)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("You lose this hand" , "You lose " + player.name.ToString(), button);
            resetPictures();
            game.newHand();
        }
        internal void PlayerTie(Player player)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("You Tied.", "Not a win, not a loss", button);
            resetPictures();
            player.addMoney(player.previousBet);
            //UpdatePlayerMoney(player);
            //game.newHand();
        }
        internal void PlayerBlackJack(Player player)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("You Got a Black Jack " + player.name.ToString() + "!", "Woot Woot!", button);
            player.addMoney( Convert.ToInt32(Math.Floor((Convert.ToDecimal(player.previousBet) * Convert.ToDecimal(2.5)))));
            BlackJack.blackJack.UpdatePlayerMoney(player);
            //resetPictures();
            //BlackJack.blackJack.game.newHand();
        }
        internal void CheckWinner(bool DealerBust)
        {
            bool playerWin = false;
            if (DealerBust)
            {
                for (int i = 0; i < game.playerList.Count(); i++)
                {
                    PlayerWin(game.playerList[i]);
                }            
            }
            else
            {
                for (int i = 0; i < game.playerList.Count(); i++)
                {
                    if (game.playerList[i].score > game.dealer.score)
                    {
                        PlayerWin(game.playerList[i]);
                    }
                    else if (game.playerList[i].score == game.dealer.score)
                    {
                        PlayerTie(game.playerList[i]);
                    }
                    else
                    {
                        PlayerLose(game.playerList[i]);
                    }
                }
            }
            resetPictures();
            game.newHand();
            //Clear cards


        }

        internal void UpdatePlayerMoney( Player player)
        {
            lblPlayerMoney.Text = player.money.ToString();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //            game.player.AddUser(txtUsername.Text, txtPassword.Text, "Player", "Last", "6056056055", new CreditCard("1234567890123456", "123", DateTime.Now));
            frmNewUser frmNewUser = new frmNewUser(txtUsername,txtPassword);
            frmNewUser.StartPosition = FormStartPosition.CenterScreen;
            frmNewUser.Show();
//            enableBetting();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check if user entered a value for username/password display message box if they didn't
            if(game.playerList[game.currentHand-1].isUser(txtUsername.Text, txtPassword.Text))
            {
                if (!SavedState(game.playerList[game.currentHand - 1].Username))
                {
                    enableBetting();
                    lblUser1.Text = game.playerList[game.currentHand - 1].name;

                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Invalid Login", "Login Failed", button);
            }
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            try
            {
                game.playerList[game.currentHand - 1].MakePayment(Convert.ToInt32(cmbAddMoney.Items[cmbAddMoney.SelectedIndex]));
            }
            catch
            {

            }
            //game.player.addMoney();
            //lblPlayerMoney.Text = game.player.money.ToString();
            //lblPlayerMoney.Text = game.player.money.ToString();
            updateMoneyLabels(game.playerList[game.currentHand - 1]);
            
        }

        public static void initAddMoneyCmbBox()
        {
            BlackJack.blackJack.cmbAddMoney.Items.Add(500);
            BlackJack.blackJack.cmbAddMoney.Items.Add(1000);
            BlackJack.blackJack.cmbAddMoney.Items.Add(5000);
            BlackJack.blackJack.cmbAddMoney.Items.Add(10000);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateInfo_Click_1(object sender, EventArgs e)
        {
            if (game.playerList[game.currentHand - 1].isUser(txtUsername.Text, txtPassword.Text)) //Check if username and password are valid before opening form
            { 
            frmNewUser frmNewUser = new frmNewUser(txtUsername, txtPassword, game.playerList[game.currentHand-1]);
            frmNewUser.StartPosition = FormStartPosition.CenterScreen;
            frmNewUser.Show();
            }
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            game.playerList[game.currentHand - 1].doInsurance(Convert.ToInt32(Math.Floor(Convert.ToDouble(game.playerList[game.currentHand - 1].previousBet) / 2)));
            BlackJack.disableInsurance();
            game.dealerBlackJack();
            btnHit.Show();
            btnStand.Show();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            game.split();
            btnSplit.Visible = false;
            btnNoSplit.Visible = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnHit.Show();
            btnStand.Show();
        }

        public static void enableInsurance()
        {
            BlackJack.blackJack.btnInsurance.Enabled = true;
            BlackJack.blackJack.btnInsurance.Visible = true;
            BlackJack.blackJack.btnNoInsurance.Enabled = true;
            BlackJack.blackJack.btnNoInsurance.Visible = true;
            BlackJack.disableHitStand();
            BlackJack.blackJack.btnHit.Hide();
            BlackJack.blackJack.btnStand.Hide();
        }

        public static void disableInsurance()
        {
            BlackJack.blackJack.btnInsurance.Enabled = false;
            BlackJack.blackJack.btnInsurance.Visible = false;
            BlackJack.blackJack.btnNoInsurance.Enabled = false;
            BlackJack.blackJack.btnNoInsurance.Visible = false;
            BlackJack.enableHitStand();
        }
        public static void enableSplit()
        {
            BlackJack.blackJack.btnSplit.Enabled = true;
            BlackJack.blackJack.btnSplit.Visible = true;
            BlackJack.blackJack.btnNoSplit.Enabled = true;
            BlackJack.blackJack.btnNoSplit.Visible = true;

            BlackJack.blackJack.btnHit.Hide();
            BlackJack.blackJack.btnStand.Hide();
            BlackJack.disableHitStand();
            //          BlackJack.convertSplitToInsurance();
        }

        public static void disableSplit()
        {
            BlackJack.blackJack.btnSplit.Enabled = false;
            BlackJack.blackJack.btnSplit.Visible = false;
            BlackJack.blackJack.btnNoSplit.Enabled = false;
            BlackJack.blackJack.btnNoSplit.Visible = false;

            BlackJack.blackJack.btnStand.Show();
            BlackJack.blackJack.btnHit.Show();
            BlackJack.enableHitStand();
        }
       
        private void btnNoInsurance_Click(object sender, EventArgs e)
        {
            BlackJack.disableInsurance();
            game.dealerBlackJack();
            btnHit.Show();
            btnStand.Show();
        }

        private void btnNoSplit_Click(object sender, EventArgs e)
        {
            btnSplit.Visible = false;
            btnNoSplit.Visible = false;
            btnHit.Show();
            btnStand.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            BlackJack.disableInsurance();
            game.dealerBlackJack();
        }

        private void btnRigHands_Click(object sender, EventArgs e)
        {
            //disableRigging();
            game.playerList[game.currentHand-1] = game.playerList[0];
            if (game.playerList.Count() > 1)
                game.playerList.RemoveAt(1);
            game.riggedHand(Convert.ToInt32(cmbPlayerCard1.SelectedItem), Convert.ToInt32(cmbPlayerCard2.SelectedItem), Convert.ToInt32(cmbDealerCard1.SelectedItem), Convert.ToInt32(cmbDealerCard2.SelectedItem));

            disableBetting();
            int bet = Convert.ToInt32(lblPreviousBet.Text);
            if (bet > game.playerList[game.currentHand - 1].money)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("You must have the amount you are trying to bet", "Betting Error", button);
                enableBetting();
            }
            else if (bet < 1)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("You must bet a value greater than that.", "Betting Error", button);
                enableBetting();
            }
            else
            {
                game.playerList[game.currentHand - 1].doBet(bet);
                game.playerList[game.currentHand - 1].previousBet = bet;
                lblPlayerBetUser1.Text = bet.ToString();
                //lblPlayerMoney.Text = game.player.money.ToString();
                updateMoneyLabels(game.playerList[game.currentHand - 1]);
                UpdatePlayerMoney(game.playerList[game.currentHand - 1]);
                game.Deal(true);
                displayCards();
                if (game.playerList[game.currentHand - 1].score == 21)
                    PlayerBlackJack(game.playerList[game.currentHand - 1]);
                else
                    enableHitStand();
            }

            

        }
        private void enableRigging()
        {
            btnRigHands.Enabled = true;
            btnRigHands.Visible = true;


            lblDealerRig.Visible = true;
            lblPlayerRig.Visible = true;

            cmbDealerCard1.Enabled = true;
            cmbDealerCard2.Enabled = true;
            cmbPlayerCard1.Enabled = true;
            cmbPlayerCard2.Enabled = true;

            cmbDealerCard1.Visible = true;
            cmbDealerCard2.Visible = true;
            cmbPlayerCard1.Visible = true;
            cmbPlayerCard2.Visible = true;
        }

        private void disableRigging()
        {
            btnRigHands.Enabled = false;
            btnRigHands.Visible = false;

            cmbDealerCard1.Enabled = false;
            cmbDealerCard2.Enabled = false;
            cmbPlayerCard1.Enabled = false;
            cmbPlayerCard2.Enabled = false;

            cmbDealerCard1.Visible = false;
            cmbDealerCard2.Visible = false;
            cmbPlayerCard1.Visible = false;
            cmbPlayerCard2.Visible = false;
        }

        private void initRiggingComboBoxes()
        {
            for ( int i = 2; i <= 11; i++ )
            {
                cmbDealerCard1.Items.Add(i);
                cmbDealerCard2.Items.Add(i);
                cmbPlayerCard1.Items.Add(i);
                cmbPlayerCard2.Items.Add(i);
            }
        }

        private void btnEnableRigging_Click(object sender, EventArgs e)
        {
            btnEnableRigging.Visible = false;
            btnEnableRigging.Enabled = false;
            enableRigging();
        }

        private void cmbDealerCard1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlayerCard1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDealerRig_Click(object sender, EventArgs e)
        {

        }

        private void cmbPlayerCard2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void updateMoneyLabels(Player player)
        {
            lblPlayerMoney.Text = player.money.ToString();
            lblPlayerMoneyUser1.Text = player.money.ToString();
        }

        public void updateDealerHandScoreLabel()
        {
            game.dealer.updateScore();
            lblDealerHandScore.Text = game.dealer.score.ToString();
            lblDealerHandScore.Update();
        }
        public void updatePlayerHandScoreLabel(Player player)
        {
            player.updateScore();
            lblPlayerHandScore.Text = player.score.ToString();
            lblPlayerHandScore.Update();
        }
    }

}
