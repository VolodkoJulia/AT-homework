using System;

namespace RandomChangeTheSymbolsInString
{
  //This class consists of the methods which let us to set the random positions and the random length of the lines's part
  //and allowes to replace this parts in established positions.
  class StringSubstitute
  {
    const int AMOUNTOFLINES = 2;

    public string SourceLine { get; set; }
    public string LineForSubstitution { get; set; }
    public Random rnd = new Random();

    //Field initialization and condition of the exception.
    public StringSubstitute(string sourceLine, string lineForSubstitution)
    {
      if(sourceLine == null || lineForSubstitution == null)
      {
        throw new EmptyStringException(); 
      }
      SourceLine = sourceLine;
      LineForSubstitution = lineForSubstitution;
    }

    //This method lets us replace this part of the line, with random length of substring from a random positions,
    //in the source line, to random positions in another one.
    public string SubstituteThePartOfString()
    {
      int indexInSourceLine = RandomPosition(SourceLine.Length);
      int indexInLineForSubstitude = RandomPosition(LineForSubstitution.Length);         
      int lengthInSourceLine = RandomLength(SourceLine.Length, indexInSourceLine);
      int lengthInLineForSubstitude= RandomLength(LineForSubstitution.Length, indexInLineForSubstitude);
      string substring = SourceLine.Substring(indexInSourceLine, lengthInSourceLine);
      string resultAfterSubstitution = LineForSubstitution.Remove(indexInLineForSubstitude, lengthInLineForSubstitude);
      resultAfterSubstitution = resultAfterSubstitution.Insert(indexInLineForSubstitude, substring);
      return resultAfterSubstitution;
    }

    //For setting the random position in which we cut out the part of the line
    //to the random position where we insert this part.
    public int RandomPosition(int lengthOfLine)
    {
      int position = rnd.Next(lengthOfLine);
      return position;
    }

    //For setting a random length of substring in the source line and a line which we want to replace.
    public int RandomLength(int lengthOfLine, int indexOfStart)
    {
      int lengthInLine = rnd.Next(1, lengthOfLine - indexOfStart);
      return lengthInLine;
    }
  }
}

