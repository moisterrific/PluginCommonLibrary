﻿using System;

namespace Terraria.Plugins.Common {
  public static class BoolEx {
    public static bool ParseEx(string input) {
      input = input.Trim();
      if (input.Equals("1", StringComparison.OrdinalIgnoreCase))
        return true;
      if (input.Equals("0", StringComparison.OrdinalIgnoreCase))
        return false;
      if (input.Equals("true", StringComparison.OrdinalIgnoreCase))
        return true;
      if (input.Equals("false", StringComparison.OrdinalIgnoreCase))
        return false;

      throw new FormatException($"The value \"{input}\" can not be parsed as a valid boolean.");
    }
  }
}
