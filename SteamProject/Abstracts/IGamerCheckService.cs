using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Entityies;

namespace SteamProject.Abstracts
{
   public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
