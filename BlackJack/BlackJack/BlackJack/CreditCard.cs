using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class CreditCard
    {
        public CreditCard()
        {
            _CreditCardNumber = "xxxxxxxxxxxxxxxx";
            _cvv2 = 000;
            _expirationDate = DateTime.Now;
        }
        public CreditCard(string CrediCardNumber, string cvv2, DateTime expirationDate)
        {
            _CreditCardNumber = CrediCardNumber;
            _cvv2 = Convert.ToInt32(cvv2);
            _expirationDate = expirationDate;
        }
        public string _CreditCardNumber;
        public int _cvv2;
        public DateTime _expirationDate;

        public bool MakePayment(double total)
        {
            if (_expirationDate > DateTime.Now && _CreditCardNumber.Length == 16)
            {
                MessageBox.Show(("Payment made on: xxxxxxxxxxxx" + _CreditCardNumber[12].ToString() + _CreditCardNumber[13].ToString() + _CreditCardNumber[14].ToString() + _CreditCardNumber[15].ToString() + Environment.NewLine + "Total of: $" + total));
                return true;
            }
            else if (_expirationDate < DateTime.Now)
            {
                MessageBox.Show("Credit Card Expired");
                return false;
            }
            else
            {
                MessageBox.Show("Invalid Credit Card Number");
                return false;
            }
        }
    }
}
