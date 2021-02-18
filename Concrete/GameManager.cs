using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void delete(Game game)
        {
            Console.WriteLine("Game is deleted");
        }

        public void NewGame(Game game)
        {
            Console.WriteLine("New game is created");
        }

        public void update(Game game)
        {
            Console.WriteLine("Game is updated");
        }
    }
}
