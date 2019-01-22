using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotPoker.Games
{
    public interface Game
    {
        string[,] Scoreboard();
        PlayingCards GetDeck();
    }
}
