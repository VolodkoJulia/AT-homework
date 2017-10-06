using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransformFromCirillicToLatin
{ /// <summary>
  ///  For filling the dictionaries and output the result on display.
  /// </summary>
  class DictionaryFiller
  {
    /// <summary>
    /// For filling the dictionaries.
    /// </summary>
    /// <param name="dictionary">
    /// The dictionary, which you  want to fill.
    /// </param>
    /// <param name="reader">
    /// The file from a specific directory for filling the dictionary.
    /// </param>
    /// <returns>
    /// The full dictionary.
    /// </returns>
    public Dictionary<string, string> FillTheDictionaries(Dictionary<string, string> dictionary, StreamReader reader)
    {
      while (!reader.EndOfStream)
      {
        string line = reader.ReadLine();
        if (reader.EndOfStream)
        {
          break;
        }
        string[] pair = line.Split('-');
        dictionary.Add(pair[0], pair[1]);
      }
      reader.Close();
      return dictionary;
    }

    /// <summary>
    /// To display a result strings.
    /// </summary>
    /// <param name="resultArray"></param>
    public void PrintResultStrings(string resultString)
    {
      foreach (var symbol in resultString)
      {
        Write(symbol);
      }
    }
  }
}
