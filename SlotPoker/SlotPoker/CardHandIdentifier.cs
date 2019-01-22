using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotPoker
{
    public class CardHandIdentifier
    {
        public int FindHand(int[] hand)
        {
            if (Check_RoyalFlush(hand))
                return 11;
            if (Check_FiveOfAKind(hand))
                return 10;
            if (Check_RoyalFlushWithJoker(hand))
                return 9;
            if (Check_StraightFlush(hand))
                return 8;
            if (Check_FourOfAKind(hand))
                return 7;
            if (Check_FullHouse(hand))
                return 6;
            if (Check_Flush(hand))
                return 5;
            if (Check_Straight(hand))
                return 4;
            if (Check_ThreeOfAKind(hand))
                return 3;
            if (Check_TwoPair(hand))
                return 2;
            if (Check_KingsOrBetter(hand))
                return 1;
            return 0;
        }



        // Methods Check all Possible Hands with a Joker. ##
        private bool Check_RoyalFlush(int[] hand)
        {
            int[] tmp = NewHand(hand);
            return RoyalFlush(tmp);
        }
        private bool Check_FiveOfAKind(int[] hand)
        {
            int[] tmp = NewHand(hand);
            // Doesn't Need the Joker Function. ##
            return FiveOfAKind(tmp);
        }
        private bool Check_RoyalFlushWithJoker(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return RoyalFlush(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (RoyalFlush(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_StraightFlush(int[] hand)
        {
            int[] tmp = NewHand(hand);
            // Doesn't Need the Joker Function. ##
            return StraightFlush(tmp);
        }
        private bool Check_FourOfAKind(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return FourOfAKind(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (FourOfAKind(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_FullHouse(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return FullHouse(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (FullHouse(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_Flush(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return Flush(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (Flush(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_Straight(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return Straight(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (Straight(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_ThreeOfAKind(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return ThreeOfAKind(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (ThreeOfAKind(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_TwoPair(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return TwoPair(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (TwoPair(tmp))
                            return true;
                    }
                return false;
            }
        }
        private bool Check_KingsOrBetter(int[] hand)
        {
            int[] tmp = NewHand(hand);
            int joker = HasJoker(tmp);
            if (joker == -1)
                return KingsOrBetter(tmp);
            else
            {
                for (int i = 0; i < 52; i++)
                    if (!HandContains(tmp, i))
                    {
                        tmp[joker] = i;
                        if (KingsOrBetter(tmp))
                            return true;
                    }
                return false;
            }
        }



        // Methods Find Hands Using a Real Deck 52 Playing Cards. ##
        private bool RoyalFlush(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = TurnAcesToHigh(tmp);
            int size = 0;
            for (int i = 0; i < tmp.Length; i++)
                size += tmp[i];
            if (size == 55)
                if (StraightFlush(hand))
                    return true;
            return false;
        }
        private bool FiveOfAKind(int[] hand)
        {
            int[] tmp = NewHand(hand);
            return (HasJoker(tmp) != -1) && FourOfAKind(tmp);
        }
        private bool StraightFlush(int[] hand)
        {
            if (Flush(hand) && Straight(hand))
                return true;
            return false;
        }
        private bool FourOfAKind(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = SortHand(tmp);
            for (int i = 0; i < 2; i++)
                if ((tmp[i * 4] == tmp[1]) && (tmp[1] == tmp[2]) && (tmp[2] == tmp[3]))
                    return true;
            return false;
        }
        private bool FullHouse(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = SortHand(tmp);
            for (int i = 0; i < 2; i++)
                if ((tmp[4 * i] == tmp[i * 2 + 1]) && (tmp[i * 2 + 1] == tmp[2]) && (tmp[3 - 2 * i] == tmp[4 - i * 4]))
                    return true;
            return false;
        }
        private bool Flush(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardSuits(tmp);
            for (int i = 1; i < tmp.Length; i++)
                if (tmp[i - 1] != tmp[i])
                    return false;
            return true;
        }
        private bool Straight(int[] hand)
        {
            bool low = true;
            bool high = true;
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = SortHand(tmp);
            for (int i = 1; i < tmp.Length; i++)
                if (tmp[i - 1] + 1 != tmp[i])
                    low = false;
            tmp = TurnAcesToHigh(tmp);
            tmp = SortHand(tmp);
            for (int i = 1; i < tmp.Length; i++)
                if (tmp[i - 1] + 1 != tmp[i])
                    high = false;
            return (low || high);
        }
        private bool ThreeOfAKind(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = SortHand(tmp);
            for (int i = 0; i < 3; i++)
                if ((tmp[i] == tmp[i + 1]) && (tmp[i + 1] == tmp[i + 2]))
                    return true;
            return false;
        }
        private bool TwoPair(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = SortHand(tmp);
            if ((tmp[0] == tmp[1]) && (tmp[2] == tmp[3]))
                return true;
            if ((tmp[0] == tmp[1]) && (tmp[3] == tmp[4]))
                return true;
            if ((tmp[1] == tmp[2]) && (tmp[3] == tmp[4]))
                return true;
            return false;
        }
        private bool KingsOrBetter(int[] hand)
        {
            int[] tmp = NewHand(hand);
            tmp = GetCardRanks(tmp);
            tmp = SortHand(tmp);
            tmp = TurnAcesToHigh(tmp);
            for (int i = 1; i < tmp.Length; i++)
                if (tmp[i - 1] == tmp[i])
                    if (tmp[i] >= 12)
                        return true;
            return false;
        }



        // Helper Methods. ##
        private int[] SortHand(int[] hand)
        {
            int[] tmp = hand;
            for (int i = 0; i < tmp.Length - 1; i++)
                for (int j = 0; j < tmp.Length - i - 1; j++)
                    if (tmp[j] > tmp[j + 1])
                    {
                        int swap = tmp[j];
                        tmp[j] = tmp[j + 1];
                        tmp[j + 1] = swap;
                    }
            return tmp;
        }
        private int[] NewHand(int[] hand)
        {
            int[] tmp = new int[hand.Length];
            for (int i = 0; i < hand.Length; i++)
                tmp[i] = hand[i];
            return tmp;
        }
        private int HasJoker(int[] hand)
        {
            for (int i = 0; i < hand.Length; i++)
                if (hand[i] == 52)
                    return i;
            return -1;
        }
        private bool HandContains(int[] hand, int card)
        {
            for (int i = 0; i < hand.Length; i++)
                if (hand[i] == card)
                    return true;
            return false;
        }
        private int[] GetCardRanks(int[] hand)
        {
            int joker = HasJoker(hand);
            for (int i = 0; i < hand.Length; i++)
                if (hand[i] == 52)
                    hand[i] = -1;
            for (int i = 0; i < hand.Length; i++)
                hand[i] = hand[i] % 13;
            if (joker != -1)
                hand[joker] = -1;
            return hand;
        }
        private int[] GetCardSuits(int[] hand)
        {
            int joker = HasJoker(hand);
            for (int i = 0; i < hand.Length; i++)
                hand[i] = hand[i] / 13;
            if (joker != -1)
                hand[joker] = -1;
            return hand;
        }
        private int[] TurnAcesToHigh(int[] hand)
        {
            for (int i = 0; i < hand.Length; i++)
                if (hand[i] == 0)
                    hand[i] = 13;
            return hand;
        }
    }
}
