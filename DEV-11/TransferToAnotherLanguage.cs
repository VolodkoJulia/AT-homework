using System.Collections.Generic;
using static System.Console;

namespace TransformWords
{ 
  // To translate the word(s) from one language to another one.
  class TransferToAnotherLanguage
  {
    // To translate the user's word(s).
    public string GetWordsAndTranslateIt(Dictionary<string, string> dictionary)
    {
      string wordForTranslation = ReadLine();
      string resultArray = TranslateWords(dictionary, wordForTranslation);
      return resultArray;
    }

    public string TranslateWords(Dictionary<string, string> dictionary, string word)
    {
      string resultString = word;
      foreach (KeyValuePair<string, string> keyValue in dictionary)
      {
        resultString = resultString.Replace(keyValue.Key, keyValue.Value);
      }
     return resultString;
    }

    public void PrintResultString(string resultString)
    {
      foreach (var symbol in resultString)
      {
        Write(symbol);
      }
    }
  }
}