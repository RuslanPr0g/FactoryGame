﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    interface IEnemiesFactory
    {
        IEnemy Create();
    }
}
