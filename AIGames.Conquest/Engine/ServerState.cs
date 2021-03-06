﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGames.Conquest.Engine
{
    public enum ServerState
    {
        Uninitialized,
        Initialized,
        StartingRegionsSelected,
        StartingRegionsAssigned,
        
        NewTurn,
        
        ArmyCountSent,
        OpponentMovesSent,
        MapUpdateSent,
        ArmyPlacementRequested,
        AttackRequested,
        
        GameEnded,
    }
}
