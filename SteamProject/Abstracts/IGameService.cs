using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Entityies;

namespace SteamProject.Abstracts
{
    interface IGameService
    {
        void Buy(Game game);
        void Sell(Game game);
        
    }
}
