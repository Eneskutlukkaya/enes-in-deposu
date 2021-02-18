using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerValuedationManager : IPlayerValuedationService

    {
        public bool validate(Player player)
        {
            int YearNow = Convert.ToInt32(DateTime.Now.Year.ToString());
            if(player.FirstName !=null && player.LastName!=null && player.NationalId != null && player.DateofBirth == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
