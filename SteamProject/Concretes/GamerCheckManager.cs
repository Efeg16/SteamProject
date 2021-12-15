using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Abstracts;
using SteamProject.Entityies;

namespace SteamProject.Concretes
{
    public class GamerCheckManager : IGamerCheckService
    {
        //Mernis sistemine bağımlı kalmamak için kendi doğrulama sistemimi burada yazıyorum.
        //Testlerde kullanabilmem için kendi doğrulama sistemim.
        public bool CheckIfRealGamer(Gamer gamer)
        {
           return true;// Kaydolan kullanıcıyı default olarak true kabul ettim.
        }
    }
}
