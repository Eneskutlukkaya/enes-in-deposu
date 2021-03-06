﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
       interface IPlayerService
    {
        void Save(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
