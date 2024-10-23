using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " " + "isimli oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " " + "isimli oyun silindi.");
        }

        public void Sale(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine(game.GameName);
            Console.WriteLine(campaign.CampaignName + " " + campaign.Campaignrate);
            Console.WriteLine(player.FirstName + " " + player.LastName + " isimli oyuncu tarafindan satin alindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " " + "isimli oyun guncellendi.");
        }
    }
}
