﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamProject.Abstracts;
using SteamProject.Adapter;
using SteamProject.Entityies;
using SteamProject.Concretes;

namespace SteamProject
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseGamerManager gamerManager = new SteamGamerService(new MernisServiceAdapter());
            gamerManager.Save(new Gamer {DateOfBirth = new DateTime(1994,04,25),FirstName="FirstName",LastName="LastName",NationalityId="TCNO" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignName = "Yeniyıl indirimi" });

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(new Gamer { FirstName = "Cengiz Han" },new Game {Name="COD",UnitPrice=200,Id=1 });

            Console.ReadLine();
        }
    }
}
