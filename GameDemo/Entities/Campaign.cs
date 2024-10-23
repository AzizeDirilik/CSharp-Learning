using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Campaignrate { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
       
            
    }
}
