using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class Player : Users
    {
        public long money { get; set; }
        public int bet { get; set; }
        public int previousBet;
        public SaveData data;
        public CreditCard creditCard;
        public string Username;
        public string Password;
        public string Fname;
        public string Lname;
        public string Phonenumber;
        public bool isInsured = false;
        public bool gameEndHandled = false;
        public int amountInsured = 0;
        public CreditCard Creditcard;



        public Player()
        {
            money = 10000;
            bet = 0;
            data = new SaveData("Users.txt");
            score = 0;
        }

        public void addMoney(int moneyToAdd)
        {
            money += moneyToAdd;
        }
        public void MakePayment(int moneyToAdd)
        {
            if (creditCard.MakePayment(moneyToAdd))
                addMoney(moneyToAdd);
        }
        public bool doBet(int amountToBet)
        {
            if (money >= amountToBet && amountToBet > 0)
            {
                money -= amountToBet;
                bet = amountToBet;
                previousBet = amountToBet;
                return true;
            }
            return false;
        }
        public void doInsurance(int amountToInsure)
        {
            money -= amountToInsure;
            amountInsured = amountToInsure * 3;
            isInsured = true;
        }

        public override void reset()
        {
            base.reset();
            bet = 0;
        }
        public void AddCreditCard(string creditCardNumber, string experationDate, string ccv2)
        {
            DateTime date;
            try
            {

                date = Convert.ToDateTime(experationDate);

                creditCard = new CreditCard(creditCardNumber, ccv2, date);
            }
            catch
            {
                MessageBox.Show("Not a valid date");
            }
        }
        public bool isUser(string username, string password)
        {
            bool VerUser = data.VerifyUser(username, password);
            if(VerUser)
            {
                string userfields = data.VerifiedData(username, password);
                string[] DataFields = userfields.Split('\u00BB');
                Username = DataFields[0];
                Password = DataFields[1];
                Fname = DataFields[2];
                name = Username;
                Lname = DataFields[3];
                Phonenumber = DataFields[4];
                creditCard = new CreditCard(DataFields[5], DataFields[6], Convert.ToDateTime(DataFields[7]));
            }
            return VerUser;

        }
        public bool AddUser(string username, string password, string fname, string lname, string phonenumber, CreditCard creditcard)
        {
            if (!isUser(username, password))
            {
                Username = username;
                Password = password;
                Fname = fname;
                name = username;
                Lname = lname;
                Phonenumber = phonenumber;
                Creditcard = creditCard;
                return data.save(username, password, fname, lname, phonenumber, creditcard._CreditCardNumber, creditcard._cvv2.ToString(), creditcard._expirationDate.ToShortDateString());
            }
            return true;
        }
        public bool RemoveThisUser()
        {
            return data.remove(Username, Password);
        }
        public void payInsurance()
        {
            money += amountInsured;
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show("Insurance Saved You!", "That's a Relief", button);
            amountInsured = 0;
        }

        public void flipGameEndHandled()
        {
            if (gameEndHandled)
                gameEndHandled = false;
            else
                gameEndHandled = true;
        }
     }


}
