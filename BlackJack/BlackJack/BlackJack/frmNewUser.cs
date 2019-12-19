using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        public frmNewUser(TextBox username, TextBox password )
        {
            InitializeComponent();
            usernamestr = username.Text.ToString();
            passwordstr = password.Text.ToString();
            txtUsernameJoin.Text = usernamestr;
            txtPasswordJoin.Text = passwordstr;
            lblLastNameValid.ForeColor = System.Drawing.Color.Red;
            lblFirstNameValid.ForeColor = System.Drawing.Color.Red;
            lblCreditCardValid.ForeColor = System.Drawing.Color.Red;
            lblCVVValid.ForeColor = System.Drawing.Color.Red;
            lblPhoneValid.ForeColor = System.Drawing.Color.Red;
            lblDifferentSame.ForeColor = System.Drawing.Color.Red;
            lblExpireValid.ForeColor = System.Drawing.Color.Red;
            if ( txtUsernameJoin.Text == "" )
                lblUsernameValid.ForeColor = System.Drawing.Color.Red;
            if ( txtPasswordJoin.Text == "" )
                lblPasswordValid.ForeColor = System.Drawing.Color.Red;
            dateExpiration.CustomFormat = "MM/dd/yyyy";

            //Make username label visible 
            lblUsernameValid.Visible = true;
            //Make update button invisible
            btnUpdate.Visible = false;
        }

        public frmNewUser(TextBox username, TextBox password, Player player)
        {
            //Edit user data form call
            InitializeComponent();
            
            //Autofill Textboxes
            txtFirstName.Text = player.Fname;
            txtLastName.Text = player.Lname;
            txtUsernameJoin.Text = player.Username;
            txtPhone.Text = player.Phonenumber;
            txtPasswordJoin.Text = password.Text;
            txtCreditCard.Text = player.creditCard._CreditCardNumber;
            txtCVV.Text = player.creditCard._cvv2.ToString();
            dateExpiration.CustomFormat = "MM/dd/yyyy";
            dateExpiration.Value = player.creditCard._expirationDate;

        //Disable Username join box and username label valid and register button invisible
        txtUsernameJoin.Enabled = false;
        lblUsernameValid.Visible = false;
        btnRegister.Visible = false;
        }

        private SaveData data = new SaveData("Users.txt");
        public string usernamestr;
        public string passwordstr;
        private void frmNewUser_Load(object sender, EventArgs e)
        {
            
            //txtUsernameJoin.Text = usernamestr;
            //txtPasswordJoin.Text = passwordstr;
            txtConfirmPass.Select();
            lblDifferentSame.Text = "Different";
            lblDifferentSame.ForeColor = System.Drawing.Color.Red;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == txtPasswordJoin.Text)
            {
                lblDifferentSame.Text = "Same";
                lblDifferentSame.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblDifferentSame.Text = "Different";
                lblDifferentSame.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 10)
            {
                lblPhoneValid.Text = "Valid";
                lblPhoneValid.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblPhoneValid.Text = "Invalid";
                lblPhoneValid.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtCreditCard_TextChanged(object sender, EventArgs e)
        {
            if (txtCreditCard.Text.Length == 16)
            {
                lblCreditCardValid.Text = "Valid";
                lblCreditCardValid.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblCreditCardValid.Text = "Invalid";
                lblCreditCardValid.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            if (txtCVV.Text.Length == 3)
            {
                lblCVVValid.Text = "Valid";
                lblCVVValid.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblCVVValid.Text = "Invalid";
                lblCVVValid.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            txtPhone.MaxLength = 10;
        }

        private void txtCreditCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            txtPhone.MaxLength = 16;
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            txtPhone.MaxLength = 3;
        }

        private void txtUsernameJoin_TextChanged(object sender, EventArgs e)
        {
            if ( txtUsernameJoin.Text == "" )
            {
                lblUsernameValid.Text = "Invalid";
                lblUsernameValid.ForeColor = System.Drawing.Color.Red;
            }
            else if (data.verify(txtUsernameJoin.Text.ToString()))
            {
                lblUsernameValid.Text = "Name Taken";
                lblUsernameValid.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblUsernameValid.Text = "Valid";
                lblUsernameValid.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txtPasswordJoin_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordJoin.Text == "")
            {
                lblPasswordValid.Text = "Invalid";
                lblPasswordValid.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPasswordValid.Text = "Valid";
                lblPasswordValid.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if ( txtFirstName.Text == "" )
            {
                lblFirstNameValid.Text = "Invalid";
                lblFirstNameValid.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblFirstNameValid.Text = "Valid";
                lblFirstNameValid.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                lblLastNameValid.Text = "Invalid";
                lblLastNameValid.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblLastNameValid.Text = "Valid";
                lblLastNameValid.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            if ( lblUsernameValid.ForeColor == System.Drawing.Color.Green &&
                 lblPasswordValid.ForeColor == System.Drawing.Color.Green &&
                 lblDifferentSame.ForeColor == System.Drawing.Color.Green &&
                 lblCreditCardValid.ForeColor == System.Drawing.Color.Green &&
                 lblPhoneValid.ForeColor == System.Drawing.Color.Green &&
                 lblCVVValid.ForeColor == System.Drawing.Color.Green &&
                 lblFirstNameValid.ForeColor == System.Drawing.Color.Green &&
                 lblLastNameValid.ForeColor == System.Drawing.Color.Green &&
                 lblExpireValid.ForeColor == System.Drawing.Color.Green )
            {
                BlackJack.blackJack.game.playerList[BlackJack.blackJack.game.currentHand -1].AddUser(txtUsernameJoin.Text, txtPasswordJoin.Text, txtFirstName.Text, txtLastName.Text, txtPhone.Text, new CreditCard(txtCreditCard.Text, txtCVV.Text, dateExpiration.Value));
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Welcome to BlackJack " + txtUsernameJoin.Text.ToString() + "!", "Account Created Successfully", button);
                this.Close();
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Some Value is Invalid", "Account Error", button);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateExpiration_ValueChanged(object sender, EventArgs e)
        {
            lblExpireValid.Text = "Valid";
            lblExpireValid.ForeColor = System.Drawing.Color.Green;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //If all labels are not red and if userdata is different then textboxes then update
            if (
                 lblPasswordValid.ForeColor == System.Drawing.Color.Green &&
                 lblDifferentSame.ForeColor == System.Drawing.Color.Green &&
                 lblCreditCardValid.ForeColor == System.Drawing.Color.Green &&
                 lblPhoneValid.ForeColor == System.Drawing.Color.Green &&
                 lblCVVValid.ForeColor == System.Drawing.Color.Green &&
                 lblFirstNameValid.ForeColor == System.Drawing.Color.Green &&
                 lblLastNameValid.ForeColor == System.Drawing.Color.Green &&
                 lblExpireValid.ForeColor == System.Drawing.Color.Green)
            {
                //Change Values in player data
                BlackJack.blackJack.game.playerList[BlackJack.blackJack.game.currentHand - 1].RemoveThisUser();
                BlackJack.blackJack.game.playerList[BlackJack.blackJack.game.currentHand - 1].AddUser(txtUsernameJoin.Text, txtPasswordJoin.Text, txtFirstName.Text, txtLastName.Text, txtPhone.Text, new CreditCard(txtCreditCard.Text, txtCVV.Text, dateExpiration.Value));
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Welcome to BlackJack " + txtUsernameJoin.Text.ToString() + "!", "Account Succesfully Changed", button);
                this.Close();
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Some Value is Invalid", "Account Error", button);
            }
        }
    }
}
