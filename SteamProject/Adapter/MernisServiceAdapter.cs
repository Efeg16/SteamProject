using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Abstracts;
using SteamProject.Entityies;
using SteamProject.Concretes;
using SteamProject.MernisServiceReference;

namespace SteamProject.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        //Gerçek olan mernis doğrulama sistemimi buraya yazıyorum.
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(gamer.NationalityId), 
                gamer.FirstName, 
                gamer.LastName, 
                gamer.DateOfBirth.Year);
        }
    }
}
