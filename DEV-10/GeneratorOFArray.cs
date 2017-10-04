using System;

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
  }
}
