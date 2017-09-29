using System;

namespace RandomChangeTheSymbolsInString
{
  class EmptyStringException : Exception
  {
    public override string Message
    {
      get
      {
        return "Wrong length of line(s).";
      }
    }
  }
}
