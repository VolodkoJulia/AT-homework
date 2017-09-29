using System;

namespace RandomChangeTheSymbolsInString
{  // For empty string which are passed to the  methode for substitute the part of string
  class EmptyStringException : Exception
  {
    //Change the Message from class of inheritor 
    public override string Message
    {
      get
      {
        return "Wrong length of line(s).";
      }
    }
  }
}
