using System.Collections;
using static System.Console;

namespace RepeatElementInArray
{ 
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// For calling the methods to check array elements for repeatability
    /// and to display an array before verification and after it.
    /// </summary>
    static void Main()
    {
      GeneratorOFArray generatorOfArray = new GeneratorOFArray();
      double[][] afterArrayGeneration = generatorOfArray.Fill2DArray();

      OutputerOfArrays outputer = new OutputerOfArrays();
      outputer.OutputDoubleArray(afterArrayGeneration);

      ElementChecker elementChecker = new ElementChecker();
      ArrayList resultArray = elementChecker.CheckElements(afterArrayGeneration);

      ExistenceDuplicateElements existElement = new ExistenceDuplicateElements();
      bool unique = existElement.CheckNonuniqueElement(resultArray);
      if (unique)
      {
        Write("\nThere are no any duplicate elements.");
      }

      OutputerOfArrays outputerOfArrays = new OutputerOfArrays();
      outputerOfArrays.OutputArrayList(resultArray);

      ReadKey();
    }
  }
}
