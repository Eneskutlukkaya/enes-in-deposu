using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IPlayerValuedationService
    {
        bool validate(Entities.Player player);
    }
}
