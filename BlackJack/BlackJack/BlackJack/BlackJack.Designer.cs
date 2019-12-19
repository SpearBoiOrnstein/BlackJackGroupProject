namespace BlackJack
{
    partial class BlackJack
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
            this.components = new System.ComponentModel.Container();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.picPlayerHand = new System.Windows.Forms.PictureBox();
            this.picDealerHand = new System.Windows.Forms.PictureBox();
            this.lblHand = new System.Windows.Forms.Label();
            this.lblPlayerHandScore = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblYourMoney = new System.Windows.Forms.Label();
            this.lblPlayerMoney = new System.Windows.Forms.Label();
            this.lblYourBet = new System.Windows.Forms.Label();
            this.lblPlayerBetUser1 = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblDealerHandScore = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnAdd10 = new System.Windows.Forms.Button();
            this.btnSub1000 = new System.Windows.Forms.Button();
            this.btnSub100 = new System.Windows.Forms.Button();
            this.btnSub10 = new System.Windows.Forms.Button();
            this.btnAdd1000 = new System.Windows.Forms.Button();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.lblPreviousBet = new System.Windows.Forms.Label();
            this.lblSetBet = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblPlayerMoneyUser1 = new System.Windows.Forms.Label();
            this.lblYourMoneyUser1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.cmbAddMoney = new System.Windows.Forms.ComboBox();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnNoSplit = new System.Windows.Forms.Button();
            this.btnNoInsurance = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnRigHands = new System.Windows.Forms.Button();
            this.cmbPlayerCard2 = new System.Windows.Forms.ComboBox();
            this.cmbDealerCard2 = new System.Windows.Forms.ComboBox();
            this.cmbPlayerCard1 = new System.Windows.Forms.ComboBox();
            this.cmbDealerCard1 = new System.Windows.Forms.ComboBox();
            this.lblDealerRig = new System.Windows.Forms.Label();
            this.lblPlayerRig = new System.Windows.Forms.Label();
            this.btnEnableRigging = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerHand)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(437, 491);
            this.btnHit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(109, 44);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(552, 491);
            this.btnStand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(109, 44);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // picPlayerHand
            // 
            this.picPlayerHand.Location = new System.Drawing.Point(499, 276);
            this.picPlayerHand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlayerHand.Name = "picPlayerHand";
            this.picPlayerHand.Size = new System.Drawing.Size(123, 122);
            this.picPlayerHand.TabIndex = 2;
            this.picPlayerHand.TabStop = false;
            // 
            // picDealerHand
            // 
            this.picDealerHand.Location = new System.Drawing.Point(499, 55);
            this.picDealerHand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDealerHand.Name = "picDealerHand";
            this.picDealerHand.Size = new System.Drawing.Size(100, 50);
            this.picDealerHand.TabIndex = 3;
            this.picDealerHand.TabStop = false;
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Location = new System.Drawing.Point(496, 244);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(83, 17);
            this.lblHand.TabIndex = 4;
            this.lblHand.Text = "Your Score:";
            // 
            // lblPlayerHandScore
            // 
            this.lblPlayerHandScore.AutoSize = true;
            this.lblPlayerHandScore.Location = new System.Drawing.Point(595, 244);
            this.lblPlayerHandScore.Name = "lblPlayerHandScore";
            this.lblPlayerHandScore.Size = new System.Drawing.Size(16, 17);
            this.lblPlayerHandScore.TabIndex = 5;
            this.lblPlayerHandScore.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblYourMoney
            // 
            this.lblYourMoney.AutoSize = true;
            this.lblYourMoney.Location = new System.Drawing.Point(16, 382);
            this.lblYourMoney.Name = "lblYourMoney";
            this.lblYourMoney.Size = new System.Drawing.Size(88, 17);
            this.lblYourMoney.TabIndex = 7;
            this.lblYourMoney.Text = "Your Money:";
            // 
            // lblPlayerMoney
            // 
            this.lblPlayerMoney.AutoSize = true;
            this.lblPlayerMoney.Location = new System.Drawing.Point(139, 382);
            this.lblPlayerMoney.Name = "lblPlayerMoney";
            this.lblPlayerMoney.Size = new System.Drawing.Size(48, 17);
            this.lblPlayerMoney.TabIndex = 8;
            this.lblPlayerMoney.Text = "10000";
            this.lblPlayerMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblYourBet
            // 
            this.lblYourBet.AutoSize = true;
            this.lblYourBet.Location = new System.Drawing.Point(435, 441);
            this.lblYourBet.Name = "lblYourBet";
            this.lblYourBet.Size = new System.Drawing.Size(67, 17);
            this.lblYourBet.TabIndex = 9;
            this.lblYourBet.Text = "Your Bet:";
            // 
            // lblPlayerBetUser1
            // 
            this.lblPlayerBetUser1.AutoSize = true;
            this.lblPlayerBetUser1.Location = new System.Drawing.Point(551, 441);
            this.lblPlayerBetUser1.Name = "lblPlayerBetUser1";
            this.lblPlayerBetUser1.Size = new System.Drawing.Size(24, 17);
            this.lblPlayerBetUser1.TabIndex = 10;
            this.lblPlayerBetUser1.Text = "10";
            this.lblPlayerBetUser1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(496, 28);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(50, 17);
            this.lblDealer.TabIndex = 11;
            this.lblDealer.Text = "Dealer";
            // 
            // lblDealerHandScore
            // 
            this.lblDealerHandScore.AutoSize = true;
            this.lblDealerHandScore.Location = new System.Drawing.Point(595, 28);
            this.lblDealerHandScore.Name = "lblDealerHandScore";
            this.lblDealerHandScore.Size = new System.Drawing.Size(16, 17);
            this.lblDealerHandScore.TabIndex = 12;
            this.lblDealerHandScore.Text = "0";
            this.lblDealerHandScore.Visible = false;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(197, 431);
            this.btnBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(84, 76);
            this.btnBet.TabIndex = 13;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnAdd10
            // 
            this.btnAdd10.Location = new System.Drawing.Point(19, 431);
            this.btnAdd10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd10.Name = "btnAdd10";
            this.btnAdd10.Size = new System.Drawing.Size(49, 37);
            this.btnAdd10.TabIndex = 14;
            this.btnAdd10.Text = "+10";
            this.btnAdd10.UseVisualStyleBackColor = true;
            this.btnAdd10.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnSub1000
            // 
            this.btnSub1000.Location = new System.Drawing.Point(125, 469);
            this.btnSub1000.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSub1000.Name = "btnSub1000";
            this.btnSub1000.Size = new System.Drawing.Size(65, 37);
            this.btnSub1000.TabIndex = 15;
            this.btnSub1000.Text = "-1000";
            this.btnSub1000.UseVisualStyleBackColor = true;
            this.btnSub1000.Click += new System.EventHandler(this.btnSub100_Click);
            // 
            // btnSub100
            // 
            this.btnSub100.Location = new System.Drawing.Point(69, 469);
            this.btnSub100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSub100.Name = "btnSub100";
            this.btnSub100.Size = new System.Drawing.Size(56, 37);
            this.btnSub100.TabIndex = 16;
            this.btnSub100.Text = "-100";
            this.btnSub100.UseVisualStyleBackColor = true;
            this.btnSub100.Click += new System.EventHandler(this.btnSub10_Click);
            // 
            // btnSub10
            // 
            this.btnSub10.Location = new System.Drawing.Point(19, 470);
            this.btnSub10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSub10.Name = "btnSub10";
            this.btnSub10.Size = new System.Drawing.Size(49, 37);
            this.btnSub10.TabIndex = 17;
            this.btnSub10.Text = "-10";
            this.btnSub10.UseVisualStyleBackColor = true;
            this.btnSub10.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnAdd1000
            // 
            this.btnAdd1000.Location = new System.Drawing.Point(125, 431);
            this.btnAdd1000.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd1000.Name = "btnAdd1000";
            this.btnAdd1000.Size = new System.Drawing.Size(65, 37);
            this.btnAdd1000.TabIndex = 18;
            this.btnAdd1000.Text = "+1000";
            this.btnAdd1000.UseVisualStyleBackColor = true;
            this.btnAdd1000.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // btnAdd100
            // 
            this.btnAdd100.Location = new System.Drawing.Point(69, 431);
            this.btnAdd100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(56, 37);
            this.btnAdd100.TabIndex = 19;
            this.btnAdd100.Text = "+100";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd10_Click);
            // 
            // lblPreviousBet
            // 
            this.lblPreviousBet.AutoSize = true;
            this.lblPreviousBet.Location = new System.Drawing.Point(139, 407);
            this.lblPreviousBet.Name = "lblPreviousBet";
            this.lblPreviousBet.Size = new System.Drawing.Size(40, 17);
            this.lblPreviousBet.TabIndex = 21;
            this.lblPreviousBet.Text = "1000";
            this.lblPreviousBet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPreviousBet.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSetBet
            // 
            this.lblSetBet.AutoSize = true;
            this.lblSetBet.Location = new System.Drawing.Point(16, 407);
            this.lblSetBet.Name = "lblSetBet";
            this.lblSetBet.Size = new System.Drawing.Size(92, 17);
            this.lblSetBet.TabIndex = 20;
            this.lblSetBet.Text = "Set Your Bet:";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Location = new System.Drawing.Point(19, 350);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(56, 17);
            this.lblPlayerTurn.TabIndex = 22;
            this.lblPlayerTurn.Text = "Player: ";
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Location = new System.Drawing.Point(435, 421);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(73, 17);
            this.lblUser1.TabIndex = 23;
            this.lblUser1.Text = "Username";
            // 
            // lblPlayerMoneyUser1
            // 
            this.lblPlayerMoneyUser1.AutoSize = true;
            this.lblPlayerMoneyUser1.Location = new System.Drawing.Point(551, 462);
            this.lblPlayerMoneyUser1.Name = "lblPlayerMoneyUser1";
            this.lblPlayerMoneyUser1.Size = new System.Drawing.Size(48, 17);
            this.lblPlayerMoneyUser1.TabIndex = 25;
            this.lblPlayerMoneyUser1.Text = "10000";
            this.lblPlayerMoneyUser1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblYourMoneyUser1
            // 
            this.lblYourMoneyUser1.AutoSize = true;
            this.lblYourMoneyUser1.Location = new System.Drawing.Point(435, 462);
            this.lblYourMoneyUser1.Name = "lblYourMoneyUser1";
            this.lblYourMoneyUser1.Size = new System.Drawing.Size(88, 17);
            this.lblYourMoneyUser1.TabIndex = 24;
            this.lblYourMoneyUser1.Text = "Your Money:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 41);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 22);
            this.txtUsername.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 70);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '?';
            this.txtPassword.Size = new System.Drawing.Size(124, 22);
            this.txtPassword.TabIndex = 27;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(103, 98);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(64, 32);
            this.btnNewUser.TabIndex = 29;
            this.btnNewUser.Text = "Join";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(39, 98);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(61, 32);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Password:";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(125, 511);
            this.btnAddMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(155, 26);
            this.btnAddMoney.TabIndex = 32;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // cmbAddMoney
            // 
            this.cmbAddMoney.FormattingEnabled = true;
            this.cmbAddMoney.Location = new System.Drawing.Point(20, 511);
            this.cmbAddMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddMoney.Name = "cmbAddMoney";
            this.cmbAddMoney.Size = new System.Drawing.Size(99, 24);
            this.cmbAddMoney.TabIndex = 33;
            // 
            // btnInsurance
            // 
            this.btnInsurance.Location = new System.Drawing.Point(438, 540);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(108, 43);
            this.btnInsurance.TabIndex = 34;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.UseVisualStyleBackColor = true;
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(437, 540);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(109, 43);
            this.btnSplit.TabIndex = 35;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnNoSplit
            // 
            this.btnNoSplit.Location = new System.Drawing.Point(554, 541);
            this.btnNoSplit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoSplit.Name = "btnNoSplit";
            this.btnNoSplit.Size = new System.Drawing.Size(109, 44);
            this.btnNoSplit.TabIndex = 37;
            this.btnNoSplit.Text = "Don\'t Split";
            this.btnNoSplit.UseVisualStyleBackColor = true;
            this.btnNoSplit.Click += new System.EventHandler(this.btnNoSplit_Click);
            // 
            // btnNoInsurance
            // 
            this.btnNoInsurance.Location = new System.Drawing.Point(554, 540);
            this.btnNoInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoInsurance.Name = "btnNoInsurance";
            this.btnNoInsurance.Size = new System.Drawing.Size(109, 44);
            this.btnNoInsurance.TabIndex = 36;
            this.btnNoInsurance.Text = "Don\'t Insure";
            this.btnNoInsurance.UseVisualStyleBackColor = true;
            this.btnNoInsurance.Click += new System.EventHandler(this.btnNoInsurance_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(173, 98);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(61, 32);
            this.btnProfile.TabIndex = 38;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnUpdateInfo_Click_1);
            // 
            // btnRigHands
            // 
            this.btnRigHands.Location = new System.Drawing.Point(174, 540);
            this.btnRigHands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRigHands.Name = "btnRigHands";
            this.btnRigHands.Size = new System.Drawing.Size(107, 53);
            this.btnRigHands.TabIndex = 39;
            this.btnRigHands.Text = "Rig Hands";
            this.btnRigHands.UseVisualStyleBackColor = true;
            this.btnRigHands.Click += new System.EventHandler(this.btnRigHands_Click);
            // 
            // cmbPlayerCard2
            // 
            this.cmbPlayerCard2.FormattingEnabled = true;
            this.cmbPlayerCard2.Location = new System.Drawing.Point(115, 570);
            this.cmbPlayerCard2.Name = "cmbPlayerCard2";
            this.cmbPlayerCard2.Size = new System.Drawing.Size(52, 24);
            this.cmbPlayerCard2.TabIndex = 43;
            this.cmbPlayerCard2.SelectedIndexChanged += new System.EventHandler(this.cmbPlayerCard2_SelectedIndexChanged);
            // 
            // cmbDealerCard2
            // 
            this.cmbDealerCard2.FormattingEnabled = true;
            this.cmbDealerCard2.Location = new System.Drawing.Point(115, 540);
            this.cmbDealerCard2.Name = "cmbDealerCard2";
            this.cmbDealerCard2.Size = new System.Drawing.Size(52, 24);
            this.cmbDealerCard2.TabIndex = 42;
            // 
            // cmbPlayerCard1
            // 
            this.cmbPlayerCard1.FormattingEnabled = true;
            this.cmbPlayerCard1.Location = new System.Drawing.Point(63, 570);
            this.cmbPlayerCard1.Name = "cmbPlayerCard1";
            this.cmbPlayerCard1.Size = new System.Drawing.Size(51, 24);
            this.cmbPlayerCard1.TabIndex = 45;
            this.cmbPlayerCard1.SelectedIndexChanged += new System.EventHandler(this.cmbPlayerCard1_SelectedIndexChanged);
            // 
            // cmbDealerCard1
            // 
            this.cmbDealerCard1.FormattingEnabled = true;
            this.cmbDealerCard1.Location = new System.Drawing.Point(64, 540);
            this.cmbDealerCard1.Name = "cmbDealerCard1";
            this.cmbDealerCard1.Size = new System.Drawing.Size(50, 24);
            this.cmbDealerCard1.TabIndex = 44;
            this.cmbDealerCard1.SelectedIndexChanged += new System.EventHandler(this.cmbDealerCard1_SelectedIndexChanged);
            // 
            // lblDealerRig
            // 
            this.lblDealerRig.AutoSize = true;
            this.lblDealerRig.Location = new System.Drawing.Point(13, 543);
            this.lblDealerRig.Name = "lblDealerRig";
            this.lblDealerRig.Size = new System.Drawing.Size(50, 17);
            this.lblDealerRig.TabIndex = 46;
            this.lblDealerRig.Text = "Dealer";
            this.lblDealerRig.Click += new System.EventHandler(this.lblDealerRig_Click);
            // 
            // lblPlayerRig
            // 
            this.lblPlayerRig.AutoSize = true;
            this.lblPlayerRig.Location = new System.Drawing.Point(14, 570);
            this.lblPlayerRig.Name = "lblPlayerRig";
            this.lblPlayerRig.Size = new System.Drawing.Size(48, 17);
            this.lblPlayerRig.TabIndex = 47;
            this.lblPlayerRig.Text = "Player";
            // 
            // btnEnableRigging
            // 
            this.btnEnableRigging.Location = new System.Drawing.Point(19, 540);
            this.btnEnableRigging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnableRigging.Name = "btnEnableRigging";
            this.btnEnableRigging.Size = new System.Drawing.Size(263, 53);
            this.btnEnableRigging.TabIndex = 48;
            this.btnEnableRigging.Text = "Enable Rigging Hands";
            this.btnEnableRigging.UseVisualStyleBackColor = true;
            this.btnEnableRigging.Click += new System.EventHandler(this.btnEnableRigging_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.btnEnableRigging);
            this.Controls.Add(this.lblPlayerRig);
            this.Controls.Add(this.lblDealerRig);
            this.Controls.Add(this.cmbPlayerCard1);
            this.Controls.Add(this.cmbDealerCard1);
            this.Controls.Add(this.cmbPlayerCard2);
            this.Controls.Add(this.cmbDealerCard2);
            this.Controls.Add(this.btnRigHands);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnNoSplit);
            this.Controls.Add(this.btnNoInsurance);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnInsurance);
            this.Controls.Add(this.cmbAddMoney);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPlayerMoneyUser1);
            this.Controls.Add(this.lblYourMoneyUser1);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.lblPreviousBet);
            this.Controls.Add(this.lblSetBet);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.btnAdd1000);
            this.Controls.Add(this.btnSub10);
            this.Controls.Add(this.btnSub100);
            this.Controls.Add(this.btnSub1000);
            this.Controls.Add(this.btnAdd10);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblDealerHandScore);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblPlayerBetUser1);
            this.Controls.Add(this.lblYourBet);
            this.Controls.Add(this.lblPlayerMoney);
            this.Controls.Add(this.lblYourMoney);
            this.Controls.Add(this.lblPlayerHandScore);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.picDealerHand);
            this.Controls.Add(this.picPlayerHand);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox picPlayerHand;
        private System.Windows.Forms.PictureBox picDealerHand;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblPlayerHandScore;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblYourMoney;
        private System.Windows.Forms.Label lblPlayerMoney;
        private System.Windows.Forms.Label lblYourBet;
        private System.Windows.Forms.Label lblPlayerBetUser1;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblDealerHandScore;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnAdd10;
        private System.Windows.Forms.Button btnSub1000;
        private System.Windows.Forms.Button btnSub100;
        private System.Windows.Forms.Button btnSub10;
        private System.Windows.Forms.Button btnAdd1000;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Label lblPreviousBet;
        private System.Windows.Forms.Label lblSetBet;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblPlayerMoneyUser1;
        private System.Windows.Forms.Label lblYourMoneyUser1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.ComboBox cmbAddMoney;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnNoSplit;
        private System.Windows.Forms.Button btnNoInsurance;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRigHands;
        private System.Windows.Forms.ComboBox cmbPlayerCard2;
        private System.Windows.Forms.ComboBox cmbDealerCard2;
        private System.Windows.Forms.ComboBox cmbPlayerCard1;
        private System.Windows.Forms.ComboBox cmbDealerCard1;
        private System.Windows.Forms.Label lblDealerRig;
        private System.Windows.Forms.Label lblPlayerRig;
        private System.Windows.Forms.Button btnEnableRigging;
    }
}

