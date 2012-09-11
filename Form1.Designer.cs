namespace PokerBetSizeCalculator
{
    partial class BetSizeCalculator
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
            this.lblBet = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPreFlop = new System.Windows.Forms.TabPage();
            this.btnThreeFive = new System.Windows.Forms.Button();
            this.btnTwoSeven = new System.Windows.Forms.Button();
            this.btntwotwo = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwoHalf = new System.Windows.Forms.Button();
            this.btnTwoQuarter = new System.Windows.Forms.Button();
            this.txtLimpers = new System.Windows.Forms.TextBox();
            this.lblLimpers = new System.Windows.Forms.Label();
            this.txtBigBlind = new System.Windows.Forms.TextBox();
            this.lblBBSize = new System.Windows.Forms.Label();
            this.tabPostFlop = new System.Windows.Forms.TabPage();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblPotSize = new System.Windows.Forms.Label();
            this.txtPotSize = new System.Windows.Forms.TextBox();
            this.tabBigBlinds = new System.Windows.Forms.TabPage();
            this.btnBigBlinds = new System.Windows.Forms.Button();
            this.txtCurrentBB = new System.Windows.Forms.TextBox();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.lblCurrentBB = new System.Windows.Forms.Label();
            this.lblStack = new System.Windows.Forms.Label();
            this.tabPotOdds = new System.Windows.Forms.TabPage();
            this.btnCalculateEquity = new System.Windows.Forms.Button();
            this.comStage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOuts = new System.Windows.Forms.TextBox();
            this.lblOuts = new System.Windows.Forms.Label();
            this.txtAmountToCall = new System.Windows.Forms.TextBox();
            this.lblAmountToCall = new System.Windows.Forms.Label();
            this.txtCurrentPotSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblPlayAdvice = new System.Windows.Forms.Label();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPreFlop.SuspendLayout();
            this.tabPostFlop.SuspendLayout();
            this.tabBigBlinds.SuspendLayout();
            this.tabPotOdds.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBet
            // 
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(48, 259);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(256, 67);
            this.lblBet.TabIndex = 6;
            this.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPreFlop);
            this.tabControl1.Controls.Add(this.tabPostFlop);
            this.tabControl1.Controls.Add(this.tabBigBlinds);
            this.tabControl1.Controls.Add(this.tabPotOdds);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 221);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabChanged);
            // 
            // tabPreFlop
            // 
            this.tabPreFlop.Controls.Add(this.btnThreeFive);
            this.tabPreFlop.Controls.Add(this.btnTwoSeven);
            this.tabPreFlop.Controls.Add(this.btntwotwo);
            this.tabPreFlop.Controls.Add(this.btnFour);
            this.tabPreFlop.Controls.Add(this.btnThree);
            this.tabPreFlop.Controls.Add(this.btnTwoHalf);
            this.tabPreFlop.Controls.Add(this.btnTwoQuarter);
            this.tabPreFlop.Controls.Add(this.txtLimpers);
            this.tabPreFlop.Controls.Add(this.lblLimpers);
            this.tabPreFlop.Controls.Add(this.txtBigBlind);
            this.tabPreFlop.Controls.Add(this.lblBBSize);
            this.tabPreFlop.Location = new System.Drawing.Point(4, 22);
            this.tabPreFlop.Name = "tabPreFlop";
            this.tabPreFlop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreFlop.Size = new System.Drawing.Size(350, 195);
            this.tabPreFlop.TabIndex = 0;
            this.tabPreFlop.Text = "PreFlop";
            this.tabPreFlop.UseVisualStyleBackColor = true;
            // 
            // btnThreeFive
            // 
            this.btnThreeFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreeFive.Location = new System.Drawing.Point(108, 137);
            this.btnThreeFive.Name = "btnThreeFive";
            this.btnThreeFive.Size = new System.Drawing.Size(65, 41);
            this.btnThreeFive.TabIndex = 22;
            this.btnThreeFive.Text = "3.5x";
            this.btnThreeFive.UseVisualStyleBackColor = true;
            this.btnThreeFive.Click += new System.EventHandler(this.btnThreeFive_Click);
            // 
            // btnTwoSeven
            // 
            this.btnTwoSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoSeven.Location = new System.Drawing.Point(250, 90);
            this.btnTwoSeven.Name = "btnTwoSeven";
            this.btnTwoSeven.Size = new System.Drawing.Size(65, 41);
            this.btnTwoSeven.TabIndex = 21;
            this.btnTwoSeven.Text = "2.7x";
            this.btnTwoSeven.UseVisualStyleBackColor = true;
            this.btnTwoSeven.Click += new System.EventHandler(this.btnTwoSeven_Click);
            // 
            // btntwotwo
            // 
            this.btntwotwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwotwo.Location = new System.Drawing.Point(36, 90);
            this.btntwotwo.Name = "btntwotwo";
            this.btntwotwo.Size = new System.Drawing.Size(66, 41);
            this.btntwotwo.TabIndex = 20;
            this.btntwotwo.Text = "2.2x";
            this.btntwotwo.UseVisualStyleBackColor = true;
            this.btntwotwo.Click += new System.EventHandler(this.btntwotwo_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(179, 137);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(65, 41);
            this.btnFour.TabIndex = 19;
            this.btnFour.Text = "4x";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(37, 137);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(65, 41);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3x";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwoHalf
            // 
            this.btnTwoHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoHalf.Location = new System.Drawing.Point(179, 90);
            this.btnTwoHalf.Name = "btnTwoHalf";
            this.btnTwoHalf.Size = new System.Drawing.Size(65, 41);
            this.btnTwoHalf.TabIndex = 17;
            this.btnTwoHalf.Text = "2.5x";
            this.btnTwoHalf.UseVisualStyleBackColor = true;
            this.btnTwoHalf.Click += new System.EventHandler(this.btnTwoHalf_Click);
            // 
            // btnTwoQuarter
            // 
            this.btnTwoQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoQuarter.Location = new System.Drawing.Point(107, 90);
            this.btnTwoQuarter.Name = "btnTwoQuarter";
            this.btnTwoQuarter.Size = new System.Drawing.Size(66, 41);
            this.btnTwoQuarter.TabIndex = 16;
            this.btnTwoQuarter.Text = "2.25x";
            this.btnTwoQuarter.UseVisualStyleBackColor = true;
            this.btnTwoQuarter.Click += new System.EventHandler(this.btnTwoQuarter_Click);
            // 
            // txtLimpers
            // 
            this.txtLimpers.Location = new System.Drawing.Point(151, 46);
            this.txtLimpers.Name = "txtLimpers";
            this.txtLimpers.Size = new System.Drawing.Size(35, 20);
            this.txtLimpers.TabIndex = 15;
            // 
            // lblLimpers
            // 
            this.lblLimpers.AutoSize = true;
            this.lblLimpers.Location = new System.Drawing.Point(46, 46);
            this.lblLimpers.Name = "lblLimpers";
            this.lblLimpers.Size = new System.Drawing.Size(78, 13);
            this.lblLimpers.TabIndex = 14;
            this.lblLimpers.Text = "No. of Limpers:";
            // 
            // txtBigBlind
            // 
            this.txtBigBlind.Location = new System.Drawing.Point(151, 16);
            this.txtBigBlind.Name = "txtBigBlind";
            this.txtBigBlind.Size = new System.Drawing.Size(100, 20);
            this.txtBigBlind.TabIndex = 13;
            // 
            // lblBBSize
            // 
            this.lblBBSize.AutoSize = true;
            this.lblBBSize.Location = new System.Drawing.Point(46, 16);
            this.lblBBSize.Name = "lblBBSize";
            this.lblBBSize.Size = new System.Drawing.Size(86, 13);
            this.lblBBSize.TabIndex = 12;
            this.lblBBSize.Text = "Size of Big Blind:";
            // 
            // tabPostFlop
            // 
            this.tabPostFlop.Controls.Add(this.btnBet);
            this.tabPostFlop.Controls.Add(this.lblPercentage);
            this.tabPostFlop.Controls.Add(this.txtPercentage);
            this.tabPostFlop.Controls.Add(this.lblPotSize);
            this.tabPostFlop.Controls.Add(this.txtPotSize);
            this.tabPostFlop.Location = new System.Drawing.Point(4, 22);
            this.tabPostFlop.Name = "tabPostFlop";
            this.tabPostFlop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostFlop.Size = new System.Drawing.Size(350, 195);
            this.tabPostFlop.TabIndex = 1;
            this.tabPostFlop.Text = "Post Flop";
            this.tabPostFlop.UseVisualStyleBackColor = true;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(19, 81);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(16, 50);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(65, 13);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "Percentage:";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(107, 44);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(38, 20);
            this.txtPercentage.TabIndex = 2;
            // 
            // lblPotSize
            // 
            this.lblPotSize.AutoSize = true;
            this.lblPotSize.Location = new System.Drawing.Point(16, 22);
            this.lblPotSize.Name = "lblPotSize";
            this.lblPotSize.Size = new System.Drawing.Size(49, 13);
            this.lblPotSize.TabIndex = 1;
            this.lblPotSize.Text = "Pot Size:";
            // 
            // txtPotSize
            // 
            this.txtPotSize.Location = new System.Drawing.Point(107, 16);
            this.txtPotSize.Name = "txtPotSize";
            this.txtPotSize.Size = new System.Drawing.Size(100, 20);
            this.txtPotSize.TabIndex = 0;
            // 
            // tabBigBlinds
            // 
            this.tabBigBlinds.Controls.Add(this.btnBigBlinds);
            this.tabBigBlinds.Controls.Add(this.txtCurrentBB);
            this.tabBigBlinds.Controls.Add(this.txtStack);
            this.tabBigBlinds.Controls.Add(this.lblCurrentBB);
            this.tabBigBlinds.Controls.Add(this.lblStack);
            this.tabBigBlinds.Location = new System.Drawing.Point(4, 22);
            this.tabBigBlinds.Name = "tabBigBlinds";
            this.tabBigBlinds.Padding = new System.Windows.Forms.Padding(3);
            this.tabBigBlinds.Size = new System.Drawing.Size(350, 195);
            this.tabBigBlinds.TabIndex = 2;
            this.tabBigBlinds.Text = "Big Blinds";
            this.tabBigBlinds.UseVisualStyleBackColor = true;
            // 
            // btnBigBlinds
            // 
            this.btnBigBlinds.Location = new System.Drawing.Point(21, 84);
            this.btnBigBlinds.Name = "btnBigBlinds";
            this.btnBigBlinds.Size = new System.Drawing.Size(108, 23);
            this.btnBigBlinds.TabIndex = 4;
            this.btnBigBlinds.Text = "Calculate Big Blinds";
            this.btnBigBlinds.UseVisualStyleBackColor = true;
            this.btnBigBlinds.Click += new System.EventHandler(this.btnBigBlinds_Click);
            // 
            // txtCurrentBB
            // 
            this.txtCurrentBB.Location = new System.Drawing.Point(130, 47);
            this.txtCurrentBB.Name = "txtCurrentBB";
            this.txtCurrentBB.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentBB.TabIndex = 3;
            // 
            // txtStack
            // 
            this.txtStack.Location = new System.Drawing.Point(130, 17);
            this.txtStack.Name = "txtStack";
            this.txtStack.Size = new System.Drawing.Size(100, 20);
            this.txtStack.TabIndex = 2;
            // 
            // lblCurrentBB
            // 
            this.lblCurrentBB.AutoSize = true;
            this.lblCurrentBB.Location = new System.Drawing.Point(18, 47);
            this.lblCurrentBB.Name = "lblCurrentBB";
            this.lblCurrentBB.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentBB.TabIndex = 1;
            this.lblCurrentBB.Text = "Current Big Blind:";
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Location = new System.Drawing.Point(18, 17);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(75, 13);
            this.lblStack.TabIndex = 0;
            this.lblStack.Text = "Current Stack:";
            // 
            // tabPotOdds
            // 
            this.tabPotOdds.Controls.Add(this.btnCalculateEquity);
            this.tabPotOdds.Controls.Add(this.comStage);
            this.tabPotOdds.Controls.Add(this.label2);
            this.tabPotOdds.Controls.Add(this.txtOuts);
            this.tabPotOdds.Controls.Add(this.lblOuts);
            this.tabPotOdds.Controls.Add(this.txtAmountToCall);
            this.tabPotOdds.Controls.Add(this.lblAmountToCall);
            this.tabPotOdds.Controls.Add(this.txtCurrentPotSize);
            this.tabPotOdds.Controls.Add(this.label1);
            this.tabPotOdds.Location = new System.Drawing.Point(4, 22);
            this.tabPotOdds.Name = "tabPotOdds";
            this.tabPotOdds.Size = new System.Drawing.Size(350, 195);
            this.tabPotOdds.TabIndex = 3;
            this.tabPotOdds.Text = "Pot Odds";
            this.tabPotOdds.UseVisualStyleBackColor = true;
            // 
            // btnCalculateEquity
            // 
            this.btnCalculateEquity.Location = new System.Drawing.Point(105, 150);
            this.btnCalculateEquity.Name = "btnCalculateEquity";
            this.btnCalculateEquity.Size = new System.Drawing.Size(140, 31);
            this.btnCalculateEquity.TabIndex = 8;
            this.btnCalculateEquity.Text = "Calculate Equity and Odds";
            this.btnCalculateEquity.UseVisualStyleBackColor = true;
            this.btnCalculateEquity.Click += new System.EventHandler(this.btnCalculateEquity_Click);
            // 
            // comStage
            // 
            this.comStage.FormattingEnabled = true;
            this.comStage.Items.AddRange(new object[] {
            "Flop",
            "Turn",
            "River"});
            this.comStage.Location = new System.Drawing.Point(140, 114);
            this.comStage.Name = "comStage";
            this.comStage.Size = new System.Drawing.Size(121, 21);
            this.comStage.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stage:";
            // 
            // txtOuts
            // 
            this.txtOuts.Location = new System.Drawing.Point(140, 87);
            this.txtOuts.Name = "txtOuts";
            this.txtOuts.Size = new System.Drawing.Size(100, 20);
            this.txtOuts.TabIndex = 5;
            // 
            // lblOuts
            // 
            this.lblOuts.AutoSize = true;
            this.lblOuts.Location = new System.Drawing.Point(29, 87);
            this.lblOuts.Name = "lblOuts";
            this.lblOuts.Size = new System.Drawing.Size(84, 13);
            this.lblOuts.TabIndex = 4;
            this.lblOuts.Text = "Number of Outs:";
            // 
            // txtAmountToCall
            // 
            this.txtAmountToCall.Location = new System.Drawing.Point(140, 54);
            this.txtAmountToCall.Name = "txtAmountToCall";
            this.txtAmountToCall.Size = new System.Drawing.Size(100, 20);
            this.txtAmountToCall.TabIndex = 3;
            // 
            // lblAmountToCall
            // 
            this.lblAmountToCall.AutoSize = true;
            this.lblAmountToCall.Location = new System.Drawing.Point(29, 54);
            this.lblAmountToCall.Name = "lblAmountToCall";
            this.lblAmountToCall.Size = new System.Drawing.Size(78, 13);
            this.lblAmountToCall.TabIndex = 2;
            this.lblAmountToCall.Text = "Amount to Call:";
            // 
            // txtCurrentPotSize
            // 
            this.txtCurrentPotSize.Location = new System.Drawing.Point(140, 21);
            this.txtCurrentPotSize.Name = "txtCurrentPotSize";
            this.txtCurrentPotSize.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPotSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Potsize:";
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetAmount.Location = new System.Drawing.Point(118, 227);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(125, 20);
            this.lblBetAmount.TabIndex = 8;
            this.lblBetAmount.Text = "Amount to Bet";
            // 
            // lblPlayAdvice
            // 
            this.lblPlayAdvice.AutoSize = true;
            this.lblPlayAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAdvice.Location = new System.Drawing.Point(130, 326);
            this.lblPlayAdvice.Name = "lblPlayAdvice";
            this.lblPlayAdvice.Size = new System.Drawing.Size(100, 20);
            this.lblPlayAdvice.TabIndex = 9;
            this.lblPlayAdvice.Text = "Play Advice";
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(24, 350);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.ReadOnly = true;
            this.txtAdvice.Size = new System.Drawing.Size(315, 73);
            this.txtAdvice.TabIndex = 10;
            this.txtAdvice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BetSizeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(361, 435);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.lblPlayAdvice);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblBet);
            this.Name = "BetSizeCalculator";
            this.Text = "Bet Size Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPreFlop.ResumeLayout(false);
            this.tabPreFlop.PerformLayout();
            this.tabPostFlop.ResumeLayout(false);
            this.tabPostFlop.PerformLayout();
            this.tabBigBlinds.ResumeLayout(false);
            this.tabBigBlinds.PerformLayout();
            this.tabPotOdds.ResumeLayout(false);
            this.tabPotOdds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPostFlop;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblPotSize;
        private System.Windows.Forms.TextBox txtPotSize;
        private System.Windows.Forms.TabPage tabPreFlop;
        private System.Windows.Forms.Button btnThreeFive;
        private System.Windows.Forms.Button btnTwoSeven;
        private System.Windows.Forms.Button btntwotwo;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwoHalf;
        private System.Windows.Forms.Button btnTwoQuarter;
        private System.Windows.Forms.TextBox txtLimpers;
        private System.Windows.Forms.Label lblLimpers;
        private System.Windows.Forms.TextBox txtBigBlind;
        private System.Windows.Forms.Label lblBBSize;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.TabPage tabBigBlinds;
        private System.Windows.Forms.Button btnBigBlinds;
        private System.Windows.Forms.TextBox txtCurrentBB;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.Label lblCurrentBB;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.Label lblPlayAdvice;
        private System.Windows.Forms.TabPage tabPotOdds;
        private System.Windows.Forms.ComboBox comStage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOuts;
        private System.Windows.Forms.Label lblOuts;
        private System.Windows.Forms.TextBox txtAmountToCall;
        private System.Windows.Forms.Label lblAmountToCall;
        private System.Windows.Forms.TextBox txtCurrentPotSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateEquity;
        private System.Windows.Forms.TextBox txtAdvice;
    }
}

