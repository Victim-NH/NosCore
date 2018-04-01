﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NosCore.GameObject
{
    public interface IExperiencedEntity
    {
        byte Level { get; set; }

        long LevelXp { get; set; }
    }
}
