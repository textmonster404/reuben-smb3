﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daiz.NES.Reuben
{
    public interface IUndoableAction
    {
        ActionType Type { get; }
    }

    public enum ActionType
    {
        MultiTile,
        TileArea,
        SpriteAdd,
        SpriteDelete,
        SpriteChange,
        PointerAdd,
        PointerDelete
    }
}
