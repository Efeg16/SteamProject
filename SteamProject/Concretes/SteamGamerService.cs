using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Abstracts;
using SteamProject.Entityies;

namespace SteamProject.Concretes
{
    //Burada amacımız oyuncuyu steam sistemine kimlik doğrulama ile kaydetmek.
    class SteamGamerService : BaseGamerManager
    {
       //Dependency Injection
        IGamerCheckService gamerCheckService;

        public SteamGamerService(IGamerCheckService gamerCheckService)
        {
            this.gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)//Save methodumu doğrulama gerçekleştikten sonra çalıştıracak olan method.
        {
            if (gamerCheckService.CheckIfRealGamer(gamer))//Eğer kullanıcı bilgileri doğrulanırsa sisteme kaydet.
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Kullanıcı bilgileri doğrulanamadı.");//Kullanıcı bilgileri doğru değilse hata fırlat.
            }
        }
    }
}
