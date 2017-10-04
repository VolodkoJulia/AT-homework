using System;
using System.Collections;
namespace RepeatElementInArray
{ 
  /// <summary>
  /// For filling an array with random values.
  /// </summary>
  class GeneratorOFArray
  {
    const int MINSIZEOFARRAY = 2;
    const int MAXSIZEOFARRAY = 7;

    /// <summary>
    /// This method is used for filling an array with random double values.
    /// </summary>
    /// <returns>
    /// The two-dimensional array after filling.
    /// </returns>
    public double[][] Fill2DArray()
    {
      Random rnd = new Random();
      double[][] array = new double[rnd.Next(MINSIZEOFARRAY, MAXSIZEOFARRAY)][];
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = new double[rnd.Next(MINSIZEOFARRAY, MAXSIZEOFARRAY)];
        for (int j = 0; j < array[i].Length; j++)
        {
          array[i][j] = rnd.NextDouble();
        }
      }
      return array;
    }

    /// <summary>
    /// Checking for the presence in the array of unique elements.
    /// </summary>
    /// <param name = "arrayAfterCheck" >
    /// An array which we want to check.
    /// </param>
    /// <returns>
    /// Exist the element or not exist.
    /// <returns>
    public bool CheckNonuniqueElement(ArrayList arrayAfterCheck)
    {
      if (arrayAfterCheck.Count == 0)
      {
        return true;
      }
      return false;
    }
  }
}
