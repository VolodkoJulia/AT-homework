using System;
using static System.Console;
namespace RandomChangeTheSymbolsInString
{
  //The entry point of the program
  class EntryPoint
  {
    //This method is used for calling the method for substitution
    //random amount of symbols from random index in the source line to another string 
    static void Main()
    {
      string sourceLine = "QWERTYUIOP";
      string lineForSubstitution = "asdfgh";

      try
      { 
        StringSubstitute stringSubstitute = new StringSubstitute(sourceLine, lineForSubstitution);
        string resultOfSubstitution = stringSubstitute.Substitute();
        Write("The source line is:\n" + sourceLine + "\nThe line for substitution is:\n" + lineForSubstitution + "\nThe line after substitution is:\n" + resultOfSubstitution);
      }
      catch (EmptyStringException ex)
      {
        WriteLine(ex.Message);
      }
      
      ReadKey();
    }
  }  
}
