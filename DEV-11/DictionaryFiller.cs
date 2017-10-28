using System.Collections.Generic;
using System.IO;

namespace TransformWords
{ 
  // For filling the dictionaries.
  class DictionaryFiller
  {
    public Dictionary<string, string> FillTheDictionaries(Dictionary<string, string> dictionary, StreamReader reader)
    {
      string line = null;
      while ((line = reader.ReadLine()) != null)
      {
        string[] pair = line.Split('-');
        dictionary.Add(pair[0], pair[1]);
      }
      reader.Close();
      return dictionary;
    }
  }
}
