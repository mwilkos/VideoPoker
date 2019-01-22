using SlotPoker.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotPoker
{
    public partial class Form1 : Form
    {
        private CardLoader CL = new CardLoader();
        private bool[] Holds = { false, false, false, false, false };
        private int[] Hand = { 0, 0, 0, 0, 0 };
        private int Winning = 0;
        private int TimerInterval = 0;
        private int Round = 0;
        private int BetMode = 0;
        private int BetAmount = 25;
        private int Credits = 0;

        private SoundPlayer WinningSound = new SoundPlayer(Properties.Resources.Winning);

        private string[,] ScoreBoard;
        private PlayingCards Deck;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            // Setting up Game Properties. ##
            JokerPoker game = new JokerPoker();
            ScoreBoard = game.Scoreboard();
            Deck = game.GetDeck();

            Image cardBack = Properties.Resources.red_back;
            pb_Card1.Image = cardBack;
            pb_Card2.Image = cardBack;
            pb_Card3.Image = cardBack;
            pb_Card4.Image = cardBack;
            pb_Card5.Image = cardBack;

            lbl_Credits.Text = CreditsToCash(Credits) + "";
            if (BetAmount >= 100)
                lbl_BetAmount.Text = "$" + (BetAmount / 100);
            else
                lbl_BetAmount.Text = BetAmount + "¢";

            for (int i = 0; i < ScoreBoard.GetLength(0); i++)
            {
                txt_TableHands.Text += ScoreBoard[i, 0];
                txt_TableBet0.Text += ScoreBoard[i, 1];
                txt_TableBet1.Text += ScoreBoard[i, 2];
                txt_TableBet2.Text += ScoreBoard[i, 3];
                txt_TableBet3.Text += ScoreBoard[i, 4];
                txt_TableBet4.Text += ScoreBoard[i, 5];
                if (i < ScoreBoard.GetLength(0) - 1)
                {
                    txt_TableHands.Text += "\r\n";
                    txt_TableBet0.Text += "\r\n";
                    txt_TableBet1.Text += "\r\n";
                    txt_TableBet2.Text += "\r\n";
                    txt_TableBet3.Text += "\r\n";
                    txt_TableBet4.Text += "\r\n";
                }
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to stop playing Joker Poker?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Turn_Click(object sender, EventArgs e)
        {
            if (timer_Winnings.Enabled)
            {
                timer_Winnings.Stop();
                WinningSound.Stop();
                lbl_Credits.Text = CreditsToCash(Credits);
                return;
            }
            if (Round == 0)
            {
                if (Credits >= BetAmount * Convert.ToInt32(ScoreBoard[ScoreBoard.GetLength(0) - 1, BetMode + 1]) || true)
                {
                    Credits = Credits - BetAmount * Convert.ToInt32(ScoreBoard[ScoreBoard.GetLength(0) - 1, BetMode + 1]);
                    lbl_Credits.Text = CreditsToCash(Credits) + "";
                    //lbl_Winnings.Text = "";
                    //*
                    for (int i = 0; i < 5; i++)
                        Deck.Shuffle();
                    //*/
                    Holds[0] = false;
                    Holds[1] = false;
                    Holds[2] = false;
                    Holds[3] = false;
                    Holds[4] = false;
                    lbl_Held1.Text = "";
                    lbl_Held2.Text = "";
                    lbl_Held3.Text = "";
                    lbl_Held4.Text = "";
                    lbl_Held5.Text = "";

                    int[] picks = { 0, 1, 2, 3, 4 };

                    pb_Card1.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[0])));
                    Hand[0] = Deck.GetCardIndex(picks[0]);
                    pb_Card2.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[1])));
                    Hand[1] = Deck.GetCardIndex(picks[1]);
                    pb_Card3.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[2])));
                    Hand[2] = Deck.GetCardIndex(picks[2]);
                    pb_Card4.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[3])));
                    Hand[3] = Deck.GetCardIndex(picks[3]);
                    pb_Card5.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[4])));
                    Hand[4] = Deck.GetCardIndex(picks[4]);

                    lbl_HandDisplay.Text = "";
                    lbl_HandDisplay.Visible = false;

                    btn_Turn.Text = "DRAW";

                    Round = 1;
                }
            }
            else
            {
                
                int[] picks = { 5, 6, 7, 8, 9 };
                if (!Holds[0])
                {
                    pb_Card1.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[0])));
                    Hand[0] = Deck.GetCardIndex(picks[0]);
                }
                if (!Holds[1])
                {
                    pb_Card2.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[1])));
                    Hand[1] = Deck.GetCardIndex(picks[1]);
                }
                if (!Holds[2])
                {
                    pb_Card3.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[2])));
                    Hand[2] = Deck.GetCardIndex(picks[2]);
                }
                if (!Holds[3])
                {
                    pb_Card4.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[3])));
                    Hand[3] = Deck.GetCardIndex(picks[3]);
                }
                if (!Holds[4])
                {
                    pb_Card5.Image = CL.GetCard(Deck.GetCardIcon(Deck.GetCardIndex(picks[4])));
                    Hand[4] = Deck.GetCardIndex(picks[4]);
                }

                btn_Turn.Text = "DEAL";

                Round = 0;

                CardHandIdentifier chi = new CardHandIdentifier();
                Winning = chi.FindHand(Hand);
                if (Winning > 0)
                {
                    lbl_HandDisplay.Text = ScoreBoard[ScoreBoard.GetLength(0) - Winning, 0];
                    lbl_HandDisplay.Visible = true;

                    int winnings = Convert.ToInt32(ScoreBoard[ScoreBoard.GetLength(0) - Winning, BetMode + 1]) * BetAmount;
                    lbl_Winnings.Text = CreditsToCash(winnings);
                    Credits += winnings;
                    TimerInterval = winnings;
                    WinningSound.PlayLooping();
                    timer_Winnings.Start();
                }
                else
                {
                    lbl_HandDisplay.Text = "NOTHING";
                    lbl_HandDisplay.Visible = true;
                    lbl_Winnings.Text = Winning + "";
                }
            }
        }

        // Held Toggles. ##
        private void pb_Card1_Click(object sender, EventArgs e)
        {
            if (Round == 1)
                lbl_Held1.Text = ToggleHold(0);
        }
        private void pb_Card2_Click(object sender, EventArgs e)
        {
            if (Round == 1)
                lbl_Held2.Text = ToggleHold(1);
        }
        private void pb_Card3_Click(object sender, EventArgs e)
        {
            if (Round == 1)
                lbl_Held3.Text = ToggleHold(2);
        }
        private void pb_Card4_Click(object sender, EventArgs e)
        {
            if (Round == 1)
                lbl_Held4.Text = ToggleHold(3);
        }
        private void pb_Card5_Click(object sender, EventArgs e)
        {
            if (Round == 1)
                lbl_Held5.Text = ToggleHold(4);
        }
        private string ToggleHold(int hold)
        {
            Holds[hold] = !Holds[hold];
            if (Holds[hold])
                return "HELD";
            return "";
        }

        private void btn_ToggleBet_Click(object sender, EventArgs e)
        {
            if (Round == 0)
            {
                Color myRed = Color.FromArgb(192, 0, 0);
                BetMode = (BetMode + 1) % (ScoreBoard.GetLength(1) - 1);
                ResetBetModeColors();
                if (BetMode == 0)
                    txt_TableBet0.BackColor = myRed;
                else if (BetMode == 1)
                    txt_TableBet1.BackColor = myRed;
                else if (BetMode == 2)
                    txt_TableBet2.BackColor = myRed;
                else if (BetMode == 3)
                    txt_TableBet3.BackColor = myRed;
                else if (BetMode == 4)
                    txt_TableBet4.BackColor = myRed;
            }
        }

        private void ResetBetModeColors()
        {
            txt_TableBet0.BackColor = txt_TableHands.BackColor;
            txt_TableBet1.BackColor = txt_TableHands.BackColor;
            txt_TableBet2.BackColor = txt_TableHands.BackColor;
            txt_TableBet3.BackColor = txt_TableHands.BackColor;
            txt_TableBet4.BackColor = txt_TableHands.BackColor;
        }

        private string CreditsToCash(int credits)
        {
            if (credits < 0)
                return "-" + string.Format("{0:C}", -(double)credits / 100);
            return string.Format("{0:C}", (double)credits/100);
        }

        private void timer_Winnings_Tick(object sender, EventArgs e)
        {
            TimerInterval -= BetAmount;
            lbl_Credits.Text = CreditsToCash(Credits - TimerInterval);
            if (TimerInterval == 0)
            {
                timer_Winnings.Stop();
                WinningSound.Stop();
            }
        }

        private void btn_addMoney_Click(object sender, EventArgs e)
        {
            if (Credits == 0)
                Credits = 10000;
            lbl_Credits.Text = CreditsToCash(Credits);
        }
    }
}
