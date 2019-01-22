using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotPoker
{
    public class PlayingCards
    {
        // Card String ID's. ##
        private string[] Icons = {
            "AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH",
            "AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC",
            "AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD",
            "AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS",
            "JO"
        };
        // Cards. ##
        private int[] Cards;

        // Construct. ##
        private void BuildDeck(int[] cards)
        {
            Cards = cards;
        }
        public PlayingCards()
        {
            int[] cards = new int[52];
            for (int i = 0; i < cards.Length; i++)
                cards[i] = i;
            BuildDeck(cards);
        }
        public PlayingCards(int[] cards)
        {
            BuildDeck(cards);
        }

        // Get the number of cards. ##
        public int Count()
        {
            return Cards.Length;
        }
        // Get the card at the index location. ##
        public int GetCardIndex(int index)
        {
            return Cards[index];
        }
        // Get the card string ID. ##
        public string GetCardIcon(int card)
        {
            return Icons[card];
        }
        // Shuffle cards with a random bubble sort. ##
        public void Shuffle()
        {
            Random rnd = new Random();
            int[] tmp = new int[Cards.Length];
            for (int i = 0; i < tmp.Length; i++)
                tmp[i] = rnd.Next(10000);
            int swap;
            for (int i = 0; i < tmp.Length - 1; i++)
                for (int j = 0; j < tmp.Length - i - 1; j++)
                    if (tmp[j] > tmp[j + 1])
                    {
                        swap = tmp[j];
                        tmp[j] = tmp[j + 1];
                        tmp[j + 1] = swap;
                        swap = Cards[j];
                        Cards[j] = Cards[j + 1];
                        Cards[j + 1] = swap;
                    }
            return;
        }
    }
}
