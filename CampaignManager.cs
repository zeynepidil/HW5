using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is applied");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }
    }

    public class Campaign
    {
        public string CampaignName { get; internal set; }
        public int DiscountRate { get; internal set; }
    }

    internal interface ICampaignService
    {
    }
}
