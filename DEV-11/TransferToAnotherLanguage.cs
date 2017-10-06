using System.Collections.Generic;

namespace TransformFromCirillicToLatin
{ /// <summary>
  /// To translate the word(s) from one language to another one.
  /// </summary>
  class TransferToAnotherLanguage
  {
    /// <summary>
    /// To translate the word(s) from one language to another one.
    /// </summary>
    /// <param name="dictionary">
    /// The dictionary which contains the translation rules
    /// </param>
    /// <param name="word">
    /// The word(s) which you want to translate.
    /// </param>
    /// <returns>
    /// The result string after translation.
    /// </returns>
    public string TranslateToAnotherLanguage(Dictionary<string, string> dictionary, string word)
    {
      string value = null;
      string resultArray = null;
      bool register = false;
      for (int i = 0; i < word.Length; i++)
      {
        register = false;
        if (char.IsUpper(word[i]))
        {
          register = true;
        }
        if (word[i] == ' ')
        {
          resultArray += ' ';
        }
        else if (word[i] == 'z' && (i != word.Length - 1) && word[i + 1] == 'h')
        {
          dictionary.TryGetValue("zh", out value);
          if (register)
          {
            value[0].ToString().ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 'k' && (i != word.Length - 1) && ((word[i + 1] == 'h')))
        {
          dictionary.TryGetValue("kh", out value);
          if (register)
          {
            value.ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 't' && (i != word.Length - 1) && word[i + 1] == 's')
        {
          dictionary.TryGetValue("ts", out value);
          if (register)
          {
            value.ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 'c' && (i != word.Length - 1) && word[i + 1] == 'h')
        {
          dictionary.TryGetValue("ch", out value);
          if (register)
          {
            value.ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 's' && word[i + 1] == 'h' && word[i + 2] == 'c' && word[i + 3] == 'h')
        {
          dictionary.TryGetValue("shch", out value);
          if (register)
          {
            value = value[0].ToString().ToUpper();
          }
          resultArray += value;
          i += 2;
        }
        else if (word[i] == 's' && (i != word.Length - 1) && word[i + 1] == 'h')
        {
          dictionary.TryGetValue("sh", out value);
          if (register)
          {
            value.ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 'y' && (i != word.Length - 1) && word[i] == 'i')
        {
          dictionary.TryGetValue("yu", out value);
          if (register)
          {
            value.ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 'y' && (i != word.Length - 1) && word[i] == 'a')
        {
          dictionary.TryGetValue("ya", out value);
          if (register)
          {
            value.ToUpper();
          }
          resultArray += value;
          i++;
        }
        else if (word[i] == 'ь' && (i != word.Length - 1) && word[i] == 'я')
        {
          if (register)
          {
            value.ToUpper();
          }
          resultArray += "ia";
          i++;
        }
        else if (word[i] == 'i' && (i != word.Length - 1) && word[i] == 'a')
        {
          if (register)
          {
            value.ToUpper();
          }
          resultArray += "ья";
          i++;
        }
        else if ((word[i] == 'ь' || word[i] == 'ъ') && ((word[i + 1] == 'е' || word[i + 1] == 'ё')))
        {
          if (register)
          {
            value.ToUpper();
          }
          resultArray += "ye";
          i++;
        }
        else if ((word[0] == 'е' || word[0] == 'ё'))
        {
          if (register)
          {
            value.ToUpper();
          }
          resultArray += "ye";
          i++;
        }
        else if (word[word.Length - 1] == 'и' && word[word.Length] == 'й')
        {
          if (register)
          {
            value.ToUpper();
          }
          resultArray += "iy";
          i++;
        }
        else if (word[word.Length - 1] == 'ы' && word[word.Length] == 'й')
        {
          if (register)
          {
            value.ToUpper();
          }
          resultArray += "y";
          i++;
        }
        else if ((word[i] == 'о') && ((word[i + 1] == 'а') && word[i + 2] == 'о') && (word[i + 3] == ' '))
        {
          resultArray += "OJSC";
          i += 2;
        }
        else if ((word[i] == 'з') && ((word[i + 1] == 'а') && word[i + 2] == 'o') && (word[i + 3] == ' '))
        {
          resultArray += "CJSC";
          i += 2;
        }
        else if ((word[i] == 'о') && ((word[i + 1] == 'о') && word[i + 2] == 'o') && (word[i + 3] == ' '))
        {
          resultArray += "LLC";
          i += 2;
        }
        else if ((word[i] == 'ф') && (word[i + 1] == 'о') && (word[i + 2] == 'н') && (word[i + 3] == 'н') && (word[i + 4] == ' '))
        {
          resultArray += "FUND";
          i += 2;
        }
        else if ((word[i] == 'г') && (word[i + 1] == 'о') && (word[i + 2] == 'у') && (word[i + 3] == ' '))
        {
          resultArray += "SEE";
          i += 2;
        }
        else if ((word[i] == 'м') && (word[i + 1] == 'о') && (word[i + 2] == 'у') && (word[i + 3] == ' '))
        {
          resultArray += "MEE";
          i += 2;
        }
        else if ((word[i] == 'н') && (word[i + 1] == 'о') && (word[i + 2] == 'у') && (word[i + 3] == ' '))
        {
          resultArray += "NEE";
          i += 2;
        }
        else if (dictionary.TryGetValue(word[i].ToString().ToLower(), out value))
        {
          if (register)
          {
            value = value[0].ToString().ToUpper();
          }
          resultArray += value;
        }
      }
      return resultArray;
    }
  }
}
