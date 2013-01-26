﻿using System;
using DPoint = System.Drawing.Point;

using TShockAPI;

namespace Terraria.Plugins.CoderCow.Hooks {
  public class ItemDropEventArgs: NetHookEventArgs {
    #region [Property: ItemIndex]
    private readonly int itemIndex;

    public int ItemIndex {
      get { return this.itemIndex; }
    }
    #endregion

    #region [Property: Location]
    private readonly Vector2 location;

    public Vector2 Location {
      get { return this.location; }
    }
    #endregion

    #region [Property: Velocity]
    private readonly Vector2 velocity;

    public Vector2 Velocity {
      get { return this.velocity; }
    }
    #endregion

    #region [Property: StackSize]
    private readonly byte stackSize;

    public byte StackSize {
      get { return this.stackSize; }
    }
    #endregion

    #region [Property: Prefix]
    private readonly byte prefix;

    public byte Prefix {
      get { return this.prefix; }
    }
    #endregion

    #region [Property: ItemType]
    private readonly short itemType;

    public short ItemType {
      get { return this.itemType; }
    }
    #endregion


    #region [Method: Constructor]
    public ItemDropEventArgs(
      TSPlayer player, int itemIndex, Vector2 location, Vector2 velocity, byte stackSize, byte prefix, short itemType
    ): base(player) {
      this.itemIndex = itemIndex;
      this.location = location;
      this.velocity = velocity;
      this.stackSize = stackSize;
      this.prefix = prefix;
      this.itemType = itemType;
    }
    #endregion
  }
}