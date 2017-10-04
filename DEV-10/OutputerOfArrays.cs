using System;
using System.Collections;
using System.Text;
using static System.Console;

namespace RepeatElementInArray
{ 
  /// <summary>
  /// This class is consisted the methods to display an array before verification and after it.
  /// </summary>
  class OutputerOfArrays
  {
    StringBuilder builder = new StringBuilder();
    /// <summary>
    /// The method to display an array before verification.
    /// </summary>
    /// <param name="array">
    /// An array which we need to output.
    /// </param>
    public void OutputDoubleArray(double[][] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        for (int j = 0; j < array[i].Length; j++)
        {
          //Write(String.Format("{0:f5}", array[i][j]) + " ");
          builder.Append(array[i][j] + " ");
          Write(builder);
        }
        WriteLine();
      }    
    }

    /// <summary>
    /// The method to display an array after verification.
    /// </summary>
    /// <param name="arrayAfterCheck">
    /// An array which we want to output on display.
    /// </param>
    public void OutputArrayList(ArrayList arrayAfterCheck)
    {
      Write("\nArray with duplicate elements:");
      for (int i = 0; i < arrayAfterCheck.Count; i++)
      {
        builder.Append(arrayAfterCheck[i] + " ");
        Write(builder);
      }
    }
  }
}

