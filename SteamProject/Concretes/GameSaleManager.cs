using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Entityies;
using SteamProject.Concretes;
using SteamProject.Abstracts;

namespace SteamProject.Concretes
{
    class GameSaleManager
    {
        public void SaleWithCampaign(Gamer gamer , Game game, Campaign campaign)
        {
            double NewPrice = game.UnitPrice - (game.UnitPrice * campaign.Rate);
            Console.WriteLine(game.Name + " İsimli Oyunu " + campaign.CampaignName + " isimli kampanyadan yararlanarak " + NewPrice + " ücretiyle satın aldınız." +" Tebrikler : " +gamer.FirstName);
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine( "Ücreti : " + game.UnitPrice + "  olan " + game.Name + " İsimli Oyunu " + "satın aldınız! " + "Tebrikler : " + gamer.FirstName );
        }
    }
}
