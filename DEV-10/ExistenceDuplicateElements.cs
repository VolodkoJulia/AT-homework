using System.Collections;
using static System.Console;

namespace RepeatElementInArray
{ 
  /// <summary>
  /// If in this array no any duplicate elements.
  /// </summary>
  class ExistenceDuplicateElements
  {
    /// <summary>
    /// Checking for the presence in the array of unique elements.
    /// </summary>
    /// <param name="arrayAfterCheck">
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
