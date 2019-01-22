using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotPoker.Games
{
    public class JokerPoker : Game
    {
        public PlayingCards GetDeck()
        {
            int regularPlayingCards = 52;
            int jokers = 1;

            int[] cards = new int[regularPlayingCards + jokers];

            for (int i = 0; i < regularPlayingCards; i++)
                cards[i] = i;
            for (int i = regularPlayingCards; i < regularPlayingCards + jokers; i++)
                cards[i] = 52;

            return new PlayingCards(cards);
        }

        public string[,] Scoreboard()
        {
            string[,] ScoreBoard = {
                { "NATURAL ROYAL FLUSH", "940", "1880", "4700", "9400", "23500" },
                { "FIVE OF A KIND", "200", "400", "1000", "2000", "5000" },
                { "ROYAL FLUSH WITH JOKER", "100", "200", "500", "1000", "2500" },
                { "STRIGHT FLUSH", "50", "100", "250", "500", "1250" },
                { "FOUR OF A KIND", "17", "34", "85", "170", "425" },
                { "FULL HOUSE", "7", "14", "35", "70", "175" },
                { "FLUSH", "5", "10", "25", "50", "125" },
                { "STRAIGHT", "3", "6", "15", "30", "75" },
                { "THREE OF A KIND", "2", "4", "10", "20", "50" },
                { "TWO PAIR", "1", "2", "5", "10", "25" },
                { "KINGS OR BETTER", "1", "2", "5", "10", "25" }
            };

            return ScoreBoard;
        }
    }
}
