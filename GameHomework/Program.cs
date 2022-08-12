using GameHomework.Entities;
using GameHomework.Managers;
using GameHomework.NewFolder;
using System.Collections.Generic;

namespace GameHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
            //gamerManager.Add(new Gamer {FirstName = "ABDULKADİR",LastName = "PARLAK", BirthYear = 2003, NationalityId = 12345});

            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "ABDULKADİR";
            gamer1.LastName = "PARLAK";
            gamer1.BirthYear = 2003;
            gamer1.NationalityId = 12345;

            Game game1 = new Game();
            game1.GameName = "PUBG";
            game1.GamePrice = 99;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "2 Al 1 Öde!";


            SaleManager saleManager = new SaleManager();
            //saleManager.Sell(game1, gamer1, campaign1);


            gamerManager.Add(gamer1);
            gamerManager.List();

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.List();

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.List();

        }   
    }
}