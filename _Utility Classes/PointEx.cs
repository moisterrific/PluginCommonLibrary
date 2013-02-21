﻿// This file is provided unter the terms of the 
// Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/.
// 
// Written by CoderCow

using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using DPoint = System.Drawing.Point;

namespace Terraria.Plugins.CoderCow {
  public static class PointEx {
    public static string ToSimpleString(this DPoint point) {
      return string.Concat(point.X, ',', point.Y);
    }

    public static DPoint Parse(string pointData) {
      string[] locationCoords = pointData.Split(',');
      if (locationCoords.Length != 2)
        throw new ArgumentException();

      return new DPoint(int.Parse(locationCoords[0]), int.Parse(locationCoords[1]));
    }

    public static DPoint OffsetTowards(this DPoint point, Direction direction, int offset = 1) {
      switch (direction) {
        case Direction.Left:
          return new DPoint(point.X - offset, point.Y);
        case Direction.Up:
          return new DPoint(point.X, point.Y - offset);
        case Direction.Right:
          return new DPoint(point.X + offset, point.Y);
        case Direction.Down:
          return new DPoint(point.X, point.Y + offset);
        default:
          return point;
      }
    }

    public static Tile ByPoint(this TileCollection tileCollection, DPoint point) {
      return tileCollection[point.X, point.Y];
    }
  }
}