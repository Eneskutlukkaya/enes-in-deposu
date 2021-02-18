using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService

    {
        public void create(Campaign campaign)
        {
            Console.WriteLine("Campaign is created");
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated");
        }
    }
}
