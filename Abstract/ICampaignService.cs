using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void create(Entities.Campaign campaign);
        void update(Entities.Campaign campaign);
        void delete(Entities.Campaign campaign);

    }
}
