using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerManager : IPlayerService

    {
        public void Delete(Player player)
        {
            Console.WriteLine("Player is deleted");
        }

        public void Save(Player player)
        {
            Console.WriteLine("Player is saved");
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
