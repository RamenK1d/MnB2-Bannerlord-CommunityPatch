using System;


namespace Antijank.Debugging {

  [Flags]
  
  public enum CorDebugFilterFlagsWindows {

    None = 0,

    IS_FIRST_CHANCE = 0x1

  }

}