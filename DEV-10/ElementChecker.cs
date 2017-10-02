using System.Collections;
using static System.Math;

namespace RepeatElementInArray
{ /// <summary>
  /// For checking elements on uniqueness.
  /// </summary>
  class ElementChecker
  {
    const double EPSILON = 10e-2;
    /// <summary>
    /// For checking elements on uniqueness.
    /// </summary>
    /// <param name="array"> 
    /// The array which we need to check.
    /// </param>
    /// <returns>
    /// An array just with duplicate elements.
    /// </returns>
    public ArrayList CheckElements(double[][] array)
    {
      ArrayList arrayAfterCheck = new ArrayList();
      for (int i = 0; i < array.Length; i++)
      {
        for (int j = 0; j < array[i].Length; j++)
        {
          int count = 0;
          for (int k = 0; k < array.Length; k++)
          {
            for (int l = 0; l < array[k].Length; l++)
            {
              if (Abs(array[i][j] - array[k][l]) < EPSILON)
              {
                count++;
                break;
              }
            }                        
          }
          if (count >= 2)
          {
            for (int checker = 0; checker < arrayAfterCheck.Count; checker++)
            {
              if (Abs((double)arrayAfterCheck[checker] - array[i][j]) < EPSILON)
              {
                arrayAfterCheck.Remove(array[i][j]);
              }
            }
            arrayAfterCheck.Add(array[i][j]);
            break;
          }
        }
      }
      return arrayAfterCheck;
    }
  }
}

