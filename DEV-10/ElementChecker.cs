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
            for (int counter = 0; counter < arrayAfterCheck.Count; counter++)
            {
              if (Abs((double)arrayAfterCheck[counter] - array[i][j]) < EPSILON)
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

    /// <summary>
    /// Checking for the presence in the array of unique elements.
    /// </summary>
    /// <param name = "arrayAfterCheck" >
    /// An array which we want to check.
    /// </param>
    /// <returns>
    /// Exist the element or not exist.
    /// <returns>
    public bool CheckExistanceNonuniqueElement(ArrayList arrayAfterCheck)
    {
      if (arrayAfterCheck.Count == 0)
      {
        return true;
      }
      return false;
    }
  }
}

