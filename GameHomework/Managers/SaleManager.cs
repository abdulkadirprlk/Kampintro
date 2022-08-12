using GameHomework.Entities;
using GameHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.NewFolder
{
    internal class SaleManager : ISaleService
    {

        public void Sell(Game game,Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyunu " + game.GamePrice + " TL'ye " +gamer.FirstName + " kişisine satıldı! : " + campaign.CampaignName);
        }
    }
}
    