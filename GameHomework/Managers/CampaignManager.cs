using GameHomework.Entities;
using GameHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.Managers
{
    internal class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi!");
        }
        public void List()
        {
            Console.WriteLine("Kampanyalar:");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi!");
        }
    }
}
