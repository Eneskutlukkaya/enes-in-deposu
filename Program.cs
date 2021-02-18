using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Happy New Year Campaign";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.create(campaign1);
            

            Game game1 = new Game();
            game1.GameName = "GTA6";
            game1.GamePrice = 999;
            GameManager gameManager = new GameManager();
            gameManager.NewGame(game1);

            Player player1 = new Player();
            player1.FirstName = "TONY";
            player1.LastName = "MONTANA";
            player1.NationalId = "1";
            player1.PlayerId = 2;
            PlayerManager playerManager = new PlayerManager();
            playerManager.Save(player1);

            





        }
    }
}
