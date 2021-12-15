using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Entityies;
using SteamProject.Abstracts;
using SteamProject.Concretes;

namespace SteamProject.Abstracts
{
    public abstract class BaseGamerManager : IGamerService
    {
        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.FirstName);
        }

        public virtual  void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer is saved to SteamDatabase : " + gamer.FirstName );
           
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi : " + gamer.FirstName);
        }

     
    }
}
