using System;

namespace RandomChangeTheSymbolsInString
{
  //This class consists of the methods which let us to set the random positions and the random length of the lines's part
  //and allowes to replace this parts in established positions
  class StringSubstitute
  {
    const int AMOUNTOFLINES = 2;

    public string SourceLine { get; set; }
    public string LineForSubstitution { get; set; }
    public Random rnd = new Random();

    //Field initialization:
    public StringSubstitute(string sourceLine, string lineForSubstitution)
    {
      if(sourceLine.Length == 0 || lineForSubstitution.Length == 0)
      {
        throw new EmptyStringException(); 
      }
      SourceLine = sourceLine;
      LineForSubstitution = lineForSubstitution;
    }

    //This method lets us replace this part of the line, with random length from a random positions,
    //in the source line, to random positions in another one
    public string Substitute()
    {
      int[] indexOfStart = RandomPosition(SourceLine.Length, LineForSubstitution.Length);
      int[] length = RandomLength(SourceLine.Length, LineForSubstitution.Length, indexOfStart);
      string substring = SourceLine.Substring(indexOfStart[0], length[0]);
      string resultAfterSubstitution = LineForSubstitution.Remove(indexOfStart[1], length[1]);
      resultAfterSubstitution = resultAfterSubstitution.Insert(indexOfStart[1], substring);
      return resultAfterSubstitution;
    }

    //For setting the random position in which we cut out the part of the line
    //to the random position where we insert this part
    public int[] RandomPosition(int lengthOfSourceLine, int lengthOfLineForSubstitute)
    {
      int[] position = new int[AMOUNTOFLINES];
      position[0] = rnd.Next(lengthOfSourceLine);
      position[1] = rnd.Next(lengthOfLineForSubstitute);
      return position;
    }

    //For setting the source line a random length of a line which we want to replace
    //and the random length in another line where we want to insert
    public int[] RandomLength(int lengthOfSourceLine, int lengthOfLineForSubstitute, int[] indexOfStart)
    {
      int positionStartInSourceLine = indexOfStart[0];
      int positionStartLineForSubstitude = indexOfStart[1];
      int[] length = new int[AMOUNTOFLINES];
      length[0] = rnd.Next(1,lengthOfSourceLine - positionStartInSourceLine);
      length[1] = rnd.Next(1,lengthOfLineForSubstitute - positionStartLineForSubstitude);
      return length;
    }
  }
}

