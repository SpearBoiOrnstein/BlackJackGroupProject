namespace BlackJack
{
    partial class frmNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsernameJoin = new System.Windows.Forms.TextBox();
            this.txtPasswordJoin = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblUsernameJoin = new System.Windows.Forms.Label();
            this.lblPasswordJoin = new System.Windows.Forms.Label();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDifferentSame = new System.Windows.Forms.Label();
            this.lblFirstNameValid = new System.Windows.Forms.Label();
            this.lblLastNameValid = new System.Windows.Forms.Label();
            this.lblPhoneValid = new System.Windows.Forms.Label();
            this.lblCreditCardValid = new System.Windows.Forms.Label();
            this.lblCVVValid = new System.Windows.Forms.Label();
            this.lblUsernameValid = new System.Windows.Forms.Label();
            this.lblPasswordValid = new System.Windows.Forms.Label();
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblExpireValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsernameJoin
            // 
            this.txtUsernameJoin.Location = new System.Drawing.Point(134, 25);
            this.txtUsernameJoin.Name = "txtUsernameJoin";
            this.txtUsernameJoin.Size = new System.Drawing.Size(134, 22);
            this.txtUsernameJoin.TabIndex = 0;
            this.txtUsernameJoin.TextChanged += new System.EventHandler(this.txtUsernameJoin_TextChanged);
            // 
            // txtPasswordJoin
            // 
            this.txtPasswordJoin.Location = new System.Drawing.Point(134, 75);
            this.txtPasswordJoin.Name = "txtPasswordJoin";
            this.txtPasswordJoin.PasswordChar = '*';
            this.txtPasswordJoin.Size = new System.Drawing.Size(134, 22);
            this.txtPasswordJoin.TabIndex = 1;
            this.txtPasswordJoin.TextChanged += new System.EventHandler(this.txtPasswordJoin_TextChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(134, 124);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(134, 22);
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(134, 174);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(134, 22);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblUsernameJoin
            // 
            this.lblUsernameJoin.AutoSize = true;
            this.lblUsernameJoin.Location = new System.Drawing.Point(34, 25);
            this.lblUsernameJoin.Name = "lblUsernameJoin";
            this.lblUsernameJoin.Size = new System.Drawing.Size(77, 17);
            this.lblUsernameJoin.TabIndex = 4;
            this.lblUsernameJoin.Text = "Username:";
            // 
            // lblPasswordJoin
            // 
            this.lblPasswordJoin.AutoSize = true;
            this.lblPasswordJoin.Location = new System.Drawing.Point(34, 75);
            this.lblPasswordJoin.Name = "lblPasswordJoin";
            this.lblPasswordJoin.Size = new System.Drawing.Size(73, 17);
            this.lblPasswordJoin.TabIndex = 5;
            this.lblPasswordJoin.Text = "Password:";
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(34, 127);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(95, 17);
            this.lblPasswordConfirm.TabIndex = 6;
            this.lblPasswordConfirm.Text = "Confirm Pass:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(34, 174);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(34, 368);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(39, 17);
            this.lblCVV.TabIndex = 15;
            this.lblCVV.Text = "CVV:";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(33, 323);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(83, 17);
            this.lblCreditCard.TabIndex = 14;
            this.lblCreditCard.Text = "Credit Card:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(34, 274);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(53, 17);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(34, 221);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(134, 365);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(134, 22);
            this.txtCVV.TabIndex = 11;
            this.txtCVV.TextChanged += new System.EventHandler(this.txtCVV_TextChanged);
            this.txtCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVV_KeyPress);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(134, 320);
            this.txtCreditCard.MaxLength = 16;
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(134, 22);
            this.txtCreditCard.TabIndex = 10;
            this.txtCreditCard.TextChanged += new System.EventHandler(this.txtCreditCard_TextChanged);
            this.txtCreditCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCard_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(134, 271);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 22);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(134, 221);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(134, 22);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(134, 448);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 47);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDifferentSame
            // 
            this.lblDifferentSame.AutoSize = true;
            this.lblDifferentSame.Location = new System.Drawing.Point(283, 127);
            this.lblDifferentSame.Name = "lblDifferentSame";
            this.lblDifferentSame.Size = new System.Drawing.Size(62, 17);
            this.lblDifferentSame.TabIndex = 18;
            this.lblDifferentSame.Text = "Different";
            // 
            // lblFirstNameValid
            // 
            this.lblFirstNameValid.AutoSize = true;
            this.lblFirstNameValid.Location = new System.Drawing.Point(282, 177);
            this.lblFirstNameValid.Name = "lblFirstNameValid";
            this.lblFirstNameValid.Size = new System.Drawing.Size(48, 17);
            this.lblFirstNameValid.TabIndex = 19;
            this.lblFirstNameValid.Text = "Invalid";
            // 
            // lblLastNameValid
            // 
            this.lblLastNameValid.AutoSize = true;
            this.lblLastNameValid.Location = new System.Drawing.Point(282, 224);
            this.lblLastNameValid.Name = "lblLastNameValid";
            this.lblLastNameValid.Size = new System.Drawing.Size(48, 17);
            this.lblLastNameValid.TabIndex = 20;
            this.lblLastNameValid.Text = "Invalid";
            // 
            // lblPhoneValid
            // 
            this.lblPhoneValid.AutoSize = true;
            this.lblPhoneValid.Location = new System.Drawing.Point(282, 274);
            this.lblPhoneValid.Name = "lblPhoneValid";
            this.lblPhoneValid.Size = new System.Drawing.Size(48, 17);
            this.lblPhoneValid.TabIndex = 21;
            this.lblPhoneValid.Text = "Invalid";
            // 
            // lblCreditCardValid
            // 
            this.lblCreditCardValid.AutoSize = true;
            this.lblCreditCardValid.Location = new System.Drawing.Point(282, 323);
            this.lblCreditCardValid.Name = "lblCreditCardValid";
            this.lblCreditCardValid.Size = new System.Drawing.Size(48, 17);
            this.lblCreditCardValid.TabIndex = 22;
            this.lblCreditCardValid.Text = "Invalid";
            // 
            // lblCVVValid
            // 
            this.lblCVVValid.AutoSize = true;
            this.lblCVVValid.Location = new System.Drawing.Point(282, 365);
            this.lblCVVValid.Name = "lblCVVValid";
            this.lblCVVValid.Size = new System.Drawing.Size(48, 17);
            this.lblCVVValid.TabIndex = 23;
            this.lblCVVValid.Text = "Invalid";
            // 
            // lblUsernameValid
            // 
            this.lblUsernameValid.AutoSize = true;
            this.lblUsernameValid.Location = new System.Drawing.Point(282, 28);
            this.lblUsernameValid.Name = "lblUsernameValid";
            this.lblUsernameValid.Size = new System.Drawing.Size(48, 17);
            this.lblUsernameValid.TabIndex = 24;
            this.lblUsernameValid.Text = "Invalid";
            // 
            // lblPasswordValid
            // 
            this.lblPasswordValid.AutoSize = true;
            this.lblPasswordValid.Location = new System.Drawing.Point(283, 80);
            this.lblPasswordValid.Name = "lblPasswordValid";
            this.lblPasswordValid.Size = new System.Drawing.Size(48, 17);
            this.lblPasswordValid.TabIndex = 25;
            this.lblPasswordValid.Text = "Invalid";
            // 
            // dateExpiration
            // 
            this.dateExpiration.CustomFormat = "MM/dd/yyyy";
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpiration.Location = new System.Drawing.Point(134, 402);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(134, 22);
            this.dateExpiration.TabIndex = 26;
            this.dateExpiration.Value = new System.DateTime(2019, 11, 20, 20, 0, 52, 0);
            this.dateExpiration.ValueChanged += new System.EventHandler(this.dateExpiration_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Experation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(134, 448);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 47);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblExpireValid
            // 
            this.lblExpireValid.AutoSize = true;
            this.lblExpireValid.Location = new System.Drawing.Point(281, 402);
            this.lblExpireValid.Name = "lblExpireValid";
            this.lblExpireValid.Size = new System.Drawing.Size(48, 17);
            this.lblExpireValid.TabIndex = 29;
            this.lblExpireValid.Text = "Invalid";
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 507);
            this.Controls.Add(this.lblExpireValid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.lblPasswordValid);
            this.Controls.Add(this.lblUsernameValid);
            this.Controls.Add(this.lblCVVValid);
            this.Controls.Add(this.lblCreditCardValid);
            this.Controls.Add(this.lblPhoneValid);
            this.Controls.Add(this.lblLastNameValid);
            this.Controls.Add(this.lblFirstNameValid);
            this.Controls.Add(this.lblDifferentSame);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.lblPasswordJoin);
            this.Controls.Add(this.lblUsernameJoin);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPasswordJoin);
            this.Controls.Add(this.txtUsernameJoin);
            this.Name = "frmNewUser";
            this.Text = "Join Black Jack";
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernameJoin;
        private System.Windows.Forms.TextBox txtPasswordJoin;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblUsernameJoin;
        private System.Windows.Forms.Label lblPasswordJoin;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblDifferentSame;
        private System.Windows.Forms.Label lblFirstNameValid;
        private System.Windows.Forms.Label lblLastNameValid;
        private System.Windows.Forms.Label lblPhoneValid;
        private System.Windows.Forms.Label lblCreditCardValid;
        private System.Windows.Forms.Label lblCVVValid;
        private System.Windows.Forms.Label lblUsernameValid;
        private System.Windows.Forms.Label lblPasswordValid;
        private System.Windows.Forms.DateTimePicker dateExpiration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblExpireValid;
    }
}