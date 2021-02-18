using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void NewGame(Entities.Game game);
        void update(Entities.Game game);
        void delete(Entities.Game game);

    }
}
