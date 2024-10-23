using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.FirstName = "Azize";
            player.LastName = "Dirilik";
            player.DateOfBirth = new DateOnly(2000, 10, 30);
            player.NationalityId = "111111111";

            Game game = new Game();
            game.GameName = "Oyun1";
            game.DeveloperName = "Developer1";

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Sen de Kazan";
            campaign.Campaignrate = "%20";
            campaign.StartDate = new DateOnly(2024, 10, 23);
            campaign.EndDate = new DateOnly(2024, 11, 23);

            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Add(player);

            GameManager gameManager = new GameManager();
            gameManager.Sale(game, player, campaign);
            gameManager.Add(game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
        }
    }
}
