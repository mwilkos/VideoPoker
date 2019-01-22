namespace SlotPoker
{
    partial class Form1
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
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_Turn = new System.Windows.Forms.Button();
            this.lbl_Held1 = new System.Windows.Forms.Label();
            this.lbl_Held2 = new System.Windows.Forms.Label();
            this.lbl_Held3 = new System.Windows.Forms.Label();
            this.lbl_Held4 = new System.Windows.Forms.Label();
            this.lbl_Held5 = new System.Windows.Forms.Label();
            this.lbl_HandDisplay = new System.Windows.Forms.Label();
            this.lbl_BetAmount = new System.Windows.Forms.Label();
            this.lbl_Credits = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Winnings = new System.Windows.Forms.Label();
            this.txt_TableHands = new System.Windows.Forms.TextBox();
            this.txt_TableBet0 = new System.Windows.Forms.TextBox();
            this.txt_TableBet1 = new System.Windows.Forms.TextBox();
            this.txt_TableBet2 = new System.Windows.Forms.TextBox();
            this.txt_TableBet3 = new System.Windows.Forms.TextBox();
            this.txt_TableBet4 = new System.Windows.Forms.TextBox();
            this.btn_ToggleBet = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer_Winnings = new System.Windows.Forms.Timer(this.components);
            this.pb_Card5 = new System.Windows.Forms.PictureBox();
            this.pb_Card4 = new System.Windows.Forms.PictureBox();
            this.pb_Card3 = new System.Windows.Forms.PictureBox();
            this.pb_Card2 = new System.Windows.Forms.PictureBox();
            this.pb_Card1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_addMoney = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.DimGray;
            this.btn_Quit.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.Color.White;
            this.btn_Quit.Location = new System.Drawing.Point(12, 976);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(348, 92);
            this.btn_Quit.TabIndex = 0;
            this.btn_Quit.Text = "CASH OUT";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_Turn
            // 
            this.btn_Turn.BackColor = System.Drawing.Color.DimGray;
            this.btn_Turn.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Turn.ForeColor = System.Drawing.Color.White;
            this.btn_Turn.Location = new System.Drawing.Point(1560, 976);
            this.btn_Turn.Name = "btn_Turn";
            this.btn_Turn.Size = new System.Drawing.Size(348, 92);
            this.btn_Turn.TabIndex = 1;
            this.btn_Turn.Text = "DEAL";
            this.btn_Turn.UseVisualStyleBackColor = false;
            this.btn_Turn.Click += new System.EventHandler(this.btn_Turn_Click);
            // 
            // lbl_Held1
            // 
            this.lbl_Held1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Held1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Held1.Location = new System.Drawing.Point(366, 576);
            this.lbl_Held1.Name = "lbl_Held1";
            this.lbl_Held1.Size = new System.Drawing.Size(233, 40);
            this.lbl_Held1.TabIndex = 7;
            this.lbl_Held1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Held2
            // 
            this.lbl_Held2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Held2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Held2.Location = new System.Drawing.Point(605, 576);
            this.lbl_Held2.Name = "lbl_Held2";
            this.lbl_Held2.Size = new System.Drawing.Size(233, 40);
            this.lbl_Held2.TabIndex = 8;
            this.lbl_Held2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Held3
            // 
            this.lbl_Held3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Held3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Held3.Location = new System.Drawing.Point(844, 576);
            this.lbl_Held3.Name = "lbl_Held3";
            this.lbl_Held3.Size = new System.Drawing.Size(233, 40);
            this.lbl_Held3.TabIndex = 9;
            this.lbl_Held3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Held4
            // 
            this.lbl_Held4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Held4.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Held4.Location = new System.Drawing.Point(1083, 576);
            this.lbl_Held4.Name = "lbl_Held4";
            this.lbl_Held4.Size = new System.Drawing.Size(233, 40);
            this.lbl_Held4.TabIndex = 10;
            this.lbl_Held4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Held5
            // 
            this.lbl_Held5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Held5.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Held5.Location = new System.Drawing.Point(1322, 576);
            this.lbl_Held5.Name = "lbl_Held5";
            this.lbl_Held5.Size = new System.Drawing.Size(233, 40);
            this.lbl_Held5.TabIndex = 11;
            this.lbl_Held5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_HandDisplay
            // 
            this.lbl_HandDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_HandDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HandDisplay.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_HandDisplay.Location = new System.Drawing.Point(12, 490);
            this.lbl_HandDisplay.Name = "lbl_HandDisplay";
            this.lbl_HandDisplay.Size = new System.Drawing.Size(1896, 70);
            this.lbl_HandDisplay.TabIndex = 12;
            this.lbl_HandDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_HandDisplay.Visible = false;
            // 
            // lbl_BetAmount
            // 
            this.lbl_BetAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_BetAmount.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BetAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_BetAmount.Location = new System.Drawing.Point(891, 976);
            this.lbl_BetAmount.Name = "lbl_BetAmount";
            this.lbl_BetAmount.Size = new System.Drawing.Size(143, 92);
            this.lbl_BetAmount.TabIndex = 13;
            this.lbl_BetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Credits
            // 
            this.lbl_Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Credits.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credits.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Credits.Location = new System.Drawing.Point(1561, 900);
            this.lbl_Credits.Name = "lbl_Credits";
            this.lbl_Credits.Size = new System.Drawing.Size(347, 70);
            this.lbl_Credits.TabIndex = 14;
            this.lbl_Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1561, 830);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 70);
            this.label2.TabIndex = 15;
            this.label2.Text = "CREDITS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 830);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 70);
            this.label3.TabIndex = 16;
            this.label3.Text = "WINNINGS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Winnings
            // 
            this.lbl_Winnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Winnings.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winnings.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Winnings.Location = new System.Drawing.Point(12, 900);
            this.lbl_Winnings.Name = "lbl_Winnings";
            this.lbl_Winnings.Size = new System.Drawing.Size(347, 70);
            this.lbl_Winnings.TabIndex = 17;
            this.lbl_Winnings.Text = "0";
            this.lbl_Winnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TableHands
            // 
            this.txt_TableHands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.txt_TableHands.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableHands.ForeColor = System.Drawing.Color.Yellow;
            this.txt_TableHands.Location = new System.Drawing.Point(195, 12);
            this.txt_TableHands.Multiline = true;
            this.txt_TableHands.Name = "txt_TableHands";
            this.txt_TableHands.ReadOnly = true;
            this.txt_TableHands.Size = new System.Drawing.Size(350, 400);
            this.txt_TableHands.TabIndex = 18;
            // 
            // txt_TableBet0
            // 
            this.txt_TableBet0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_TableBet0.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableBet0.ForeColor = System.Drawing.Color.Yellow;
            this.txt_TableBet0.Location = new System.Drawing.Point(543, 12);
            this.txt_TableBet0.Multiline = true;
            this.txt_TableBet0.Name = "txt_TableBet0";
            this.txt_TableBet0.ReadOnly = true;
            this.txt_TableBet0.Size = new System.Drawing.Size(200, 400);
            this.txt_TableBet0.TabIndex = 19;
            this.txt_TableBet0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TableBet1
            // 
            this.txt_TableBet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.txt_TableBet1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableBet1.ForeColor = System.Drawing.Color.Yellow;
            this.txt_TableBet1.Location = new System.Drawing.Point(741, 12);
            this.txt_TableBet1.Multiline = true;
            this.txt_TableBet1.Name = "txt_TableBet1";
            this.txt_TableBet1.ReadOnly = true;
            this.txt_TableBet1.Size = new System.Drawing.Size(200, 400);
            this.txt_TableBet1.TabIndex = 20;
            this.txt_TableBet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TableBet2
            // 
            this.txt_TableBet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.txt_TableBet2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableBet2.ForeColor = System.Drawing.Color.Yellow;
            this.txt_TableBet2.Location = new System.Drawing.Point(939, 12);
            this.txt_TableBet2.Multiline = true;
            this.txt_TableBet2.Name = "txt_TableBet2";
            this.txt_TableBet2.ReadOnly = true;
            this.txt_TableBet2.Size = new System.Drawing.Size(200, 400);
            this.txt_TableBet2.TabIndex = 21;
            this.txt_TableBet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TableBet3
            // 
            this.txt_TableBet3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.txt_TableBet3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableBet3.ForeColor = System.Drawing.Color.Yellow;
            this.txt_TableBet3.Location = new System.Drawing.Point(1137, 12);
            this.txt_TableBet3.Multiline = true;
            this.txt_TableBet3.Name = "txt_TableBet3";
            this.txt_TableBet3.ReadOnly = true;
            this.txt_TableBet3.Size = new System.Drawing.Size(200, 400);
            this.txt_TableBet3.TabIndex = 22;
            this.txt_TableBet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TableBet4
            // 
            this.txt_TableBet4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.txt_TableBet4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableBet4.ForeColor = System.Drawing.Color.Yellow;
            this.txt_TableBet4.Location = new System.Drawing.Point(1335, 12);
            this.txt_TableBet4.Multiline = true;
            this.txt_TableBet4.Name = "txt_TableBet4";
            this.txt_TableBet4.ReadOnly = true;
            this.txt_TableBet4.Size = new System.Drawing.Size(300, 400);
            this.txt_TableBet4.TabIndex = 23;
            this.txt_TableBet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ToggleBet
            // 
            this.btn_ToggleBet.BackColor = System.Drawing.Color.DimGray;
            this.btn_ToggleBet.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToggleBet.ForeColor = System.Drawing.Color.White;
            this.btn_ToggleBet.Location = new System.Drawing.Point(366, 976);
            this.btn_ToggleBet.Name = "btn_ToggleBet";
            this.btn_ToggleBet.Size = new System.Drawing.Size(347, 92);
            this.btn_ToggleBet.TabIndex = 24;
            this.btn_ToggleBet.Text = "TOGGLE BET";
            this.btn_ToggleBet.UseVisualStyleBackColor = false;
            this.btn_ToggleBet.Click += new System.EventHandler(this.btn_ToggleBet_Click);
            // 
            // timer_Winnings
            // 
            this.timer_Winnings.Interval = 1;
            this.timer_Winnings.Tick += new System.EventHandler(this.timer_Winnings_Tick);
            // 
            // pb_Card5
            // 
            this.pb_Card5.BackColor = System.Drawing.Color.Transparent;
            this.pb_Card5.Location = new System.Drawing.Point(1322, 620);
            this.pb_Card5.Name = "pb_Card5";
            this.pb_Card5.Size = new System.Drawing.Size(233, 350);
            this.pb_Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Card5.TabIndex = 6;
            this.pb_Card5.TabStop = false;
            this.pb_Card5.Click += new System.EventHandler(this.pb_Card5_Click);
            // 
            // pb_Card4
            // 
            this.pb_Card4.BackColor = System.Drawing.Color.Transparent;
            this.pb_Card4.Location = new System.Drawing.Point(1083, 620);
            this.pb_Card4.Name = "pb_Card4";
            this.pb_Card4.Size = new System.Drawing.Size(233, 350);
            this.pb_Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Card4.TabIndex = 5;
            this.pb_Card4.TabStop = false;
            this.pb_Card4.Click += new System.EventHandler(this.pb_Card4_Click);
            // 
            // pb_Card3
            // 
            this.pb_Card3.BackColor = System.Drawing.Color.Transparent;
            this.pb_Card3.Location = new System.Drawing.Point(844, 620);
            this.pb_Card3.Name = "pb_Card3";
            this.pb_Card3.Size = new System.Drawing.Size(233, 350);
            this.pb_Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Card3.TabIndex = 4;
            this.pb_Card3.TabStop = false;
            this.pb_Card3.Click += new System.EventHandler(this.pb_Card3_Click);
            // 
            // pb_Card2
            // 
            this.pb_Card2.BackColor = System.Drawing.Color.Transparent;
            this.pb_Card2.Location = new System.Drawing.Point(605, 620);
            this.pb_Card2.Name = "pb_Card2";
            this.pb_Card2.Size = new System.Drawing.Size(233, 350);
            this.pb_Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Card2.TabIndex = 3;
            this.pb_Card2.TabStop = false;
            this.pb_Card2.Click += new System.EventHandler(this.pb_Card2_Click);
            // 
            // pb_Card1
            // 
            this.pb_Card1.BackColor = System.Drawing.Color.Transparent;
            this.pb_Card1.Location = new System.Drawing.Point(366, 620);
            this.pb_Card1.Name = "pb_Card1";
            this.pb_Card1.Size = new System.Drawing.Size(233, 350);
            this.pb_Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Card1.TabIndex = 2;
            this.pb_Card1.TabStop = false;
            this.pb_Card1.Click += new System.EventHandler(this.pb_Card1_Click);
            // 
            // btn_addMoney
            // 
            this.btn_addMoney.BackColor = System.Drawing.Color.DimGray;
            this.btn_addMoney.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMoney.ForeColor = System.Drawing.Color.White;
            this.btn_addMoney.Location = new System.Drawing.Point(1206, 976);
            this.btn_addMoney.Name = "btn_addMoney";
            this.btn_addMoney.Size = new System.Drawing.Size(348, 92);
            this.btn_addMoney.TabIndex = 25;
            this.btn_addMoney.Text = "Add $100";
            this.btn_addMoney.UseVisualStyleBackColor = false;
            this.btn_addMoney.Click += new System.EventHandler(this.btn_addMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btn_addMoney);
            this.Controls.Add(this.btn_ToggleBet);
            this.Controls.Add(this.txt_TableBet4);
            this.Controls.Add(this.txt_TableBet3);
            this.Controls.Add(this.txt_TableBet2);
            this.Controls.Add(this.txt_TableBet1);
            this.Controls.Add(this.txt_TableBet0);
            this.Controls.Add(this.txt_TableHands);
            this.Controls.Add(this.lbl_Winnings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Credits);
            this.Controls.Add(this.lbl_BetAmount);
            this.Controls.Add(this.lbl_HandDisplay);
            this.Controls.Add(this.lbl_Held5);
            this.Controls.Add(this.lbl_Held4);
            this.Controls.Add(this.lbl_Held3);
            this.Controls.Add(this.lbl_Held2);
            this.Controls.Add(this.lbl_Held1);
            this.Controls.Add(this.pb_Card5);
            this.Controls.Add(this.pb_Card4);
            this.Controls.Add(this.pb_Card3);
            this.Controls.Add(this.pb_Card2);
            this.Controls.Add(this.pb_Card1);
            this.Controls.Add(this.btn_Turn);
            this.Controls.Add(this.btn_Quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_Turn;
        private System.Windows.Forms.PictureBox pb_Card1;
        private System.Windows.Forms.PictureBox pb_Card2;
        private System.Windows.Forms.PictureBox pb_Card3;
        private System.Windows.Forms.PictureBox pb_Card4;
        private System.Windows.Forms.PictureBox pb_Card5;
        private System.Windows.Forms.Label lbl_Held1;
        private System.Windows.Forms.Label lbl_Held2;
        private System.Windows.Forms.Label lbl_Held3;
        private System.Windows.Forms.Label lbl_Held4;
        private System.Windows.Forms.Label lbl_Held5;
        private System.Windows.Forms.Label lbl_HandDisplay;
        private System.Windows.Forms.Label lbl_BetAmount;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbl_Credits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Winnings;
        private System.Windows.Forms.TextBox txt_TableHands;
        private System.Windows.Forms.TextBox txt_TableBet0;
        private System.Windows.Forms.TextBox txt_TableBet1;
        private System.Windows.Forms.TextBox txt_TableBet2;
        private System.Windows.Forms.TextBox txt_TableBet3;
        private System.Windows.Forms.TextBox txt_TableBet4;
        private System.Windows.Forms.Button btn_ToggleBet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_Winnings;
        private System.Windows.Forms.Button btn_addMoney;
    }
}

