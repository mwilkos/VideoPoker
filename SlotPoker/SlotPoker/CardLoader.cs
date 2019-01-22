using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotPoker
{
    public class CardLoader
    {
        public Image GetCard(string cardSymbol)
        {
            if (cardSymbol == "AH")
            {
                return Properties.Resources.AH;
            }
            else if (cardSymbol == "2H")
            {
                return Properties.Resources._2H;
            }
            else if (cardSymbol == "3H")
            {
                return Properties.Resources._3H;
            }
            else if (cardSymbol == "4H")
            {
                return Properties.Resources._4H;
            }
            else if (cardSymbol == "5H")
            {
                return Properties.Resources._5H;
            }
            else if (cardSymbol == "6H")
            {
                return Properties.Resources._6H;
            }
            else if (cardSymbol == "7H")
            {
                return Properties.Resources._7H;
            }
            else if (cardSymbol == "8H")
            {
                return Properties.Resources._8H;
            }
            else if (cardSymbol == "9H")
            {
                return Properties.Resources._9H;
            }
            else if (cardSymbol == "10H")
            {
                return Properties.Resources._10H;
            }
            else if (cardSymbol == "JH")
            {
                return Properties.Resources.JH;
            }
            else if (cardSymbol == "QH")
            {
                return Properties.Resources.QH;
            }
            else if (cardSymbol == "KH")
            {
                return Properties.Resources.KH;
            }
            else if (cardSymbol == "AC")
            {
                return Properties.Resources.AC;
            }
            else if (cardSymbol == "2C")
            {
                return Properties.Resources._2C;
            }
            else if (cardSymbol == "3C")
            {
                return Properties.Resources._3C;
            }
            else if (cardSymbol == "4C")
            {
                return Properties.Resources._4C;
            }
            else if (cardSymbol == "5C")
            {
                return Properties.Resources._5C;
            }
            else if (cardSymbol == "6C")
            {
                return Properties.Resources._6C;
            }
            else if (cardSymbol == "7C")
            {
                return Properties.Resources._7C;
            }
            else if (cardSymbol == "8C")
            {
                return Properties.Resources._8C;
            }
            else if (cardSymbol == "9C")
            {
                return Properties.Resources._9C;
            }
            else if (cardSymbol == "10C")
            {
                return Properties.Resources._10C;
            }
            else if (cardSymbol == "JC")
            {
                return Properties.Resources.JC;
            }
            else if (cardSymbol == "QC")
            {
                return Properties.Resources.QC;
            }
            else if (cardSymbol == "KC")
            {
                return Properties.Resources.KC;
            }
            else if (cardSymbol == "AD")
            {
                return Properties.Resources.AD;
            }
            else if (cardSymbol == "2D")
            {
                return Properties.Resources._2D;
            }
            else if (cardSymbol == "3D")
            {
                return Properties.Resources._3D;
            }
            else if (cardSymbol == "4D")
            {
                return Properties.Resources._4D;
            }
            else if (cardSymbol == "5D")
            {
                return Properties.Resources._5D;
            }
            else if (cardSymbol == "6D")
            {
                return Properties.Resources._6D;
            }
            else if (cardSymbol == "7D")
            {
                return Properties.Resources._7D;
            }
            else if (cardSymbol == "8D")
            {
                return Properties.Resources._8D;
            }
            else if (cardSymbol == "9D")
            {
                return Properties.Resources._9D;
            }
            else if (cardSymbol == "10D")
            {
                return Properties.Resources._10D;
            }
            else if (cardSymbol == "JD")
            {
                return Properties.Resources.JD;
            }
            else if (cardSymbol == "QD")
            {
                return Properties.Resources.QD;
            }
            else if (cardSymbol == "KD")
            {
                return Properties.Resources.KD;
            }
            else if (cardSymbol == "AS")
            {
                return Properties.Resources.AS;
            }
            else if (cardSymbol == "2S")
            {
                return Properties.Resources._2S;
            }
            else if (cardSymbol == "3S")
            {
                return Properties.Resources._3S;
            }
            else if (cardSymbol == "4S")
            {
                return Properties.Resources._4S;
            }
            else if (cardSymbol == "5S")
            {
                return Properties.Resources._5S;
            }
            else if (cardSymbol == "6S")
            {
                return Properties.Resources._6S;
            }
            else if (cardSymbol == "7S")
            {
                return Properties.Resources._7S;
            }
            else if (cardSymbol == "8S")
            {
                return Properties.Resources._8S;
            }
            else if (cardSymbol == "9S")
            {
                return Properties.Resources._9S;
            }
            else if (cardSymbol == "10S")
            {
                return Properties.Resources._10S;
            }
            else if (cardSymbol == "JS")
            {
                return Properties.Resources.JS;
            }
            else if (cardSymbol == "QS")
            {
                return Properties.Resources.QS;
            }
            else if (cardSymbol == "KS")
            {
                return Properties.Resources.KS;
            }
            else if (cardSymbol == "JO")
            {
                return Properties.Resources.JO;
            }
            return null;
        }
    }
}
