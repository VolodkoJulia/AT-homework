using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace TransformFromCirillicToLatin
{
  /// <summary>
  /// For colling the method to transfer from one language to another one.
  /// </summary>
  class EntryPoint
  {
    const string PATHLATTOCYR = @"E:\Desktop\DicLatCirDown.txt";
    const string PATHCYRTOLAT = @"E:\Desktop\DictCirLatDown.txt";
    const string MENU = "Chose the language, on wich you want to translate:";
    const string FIRSTCHOICE = "\n1 - To Cyrillic.";
    const string SECONDCHOICE = "\n2 - To Latin.";
    const string ENTERTHESTRING = "Enter the string:";
    const string ONEMORETIME = "\n3 - To enter again.\n >>";

    static void Main()
    {
      Dictionary<string, string> dictionaryLatCyr = new Dictionary<string, string>();
      Dictionary<string, string> dictionaryCyrLat = new Dictionary<string, string>();
      StreamReader readerLatCyr = new StreamReader(PATHLATTOCYR, Encoding.Default);
      StreamReader readerCyrLat = new StreamReader(PATHCYRTOLAT, Encoding.Default);
      DictionaryFiller dictionaryFiller = new DictionaryFiller();
      dictionaryLatCyr = dictionaryFiller.FillTheDictionaries(dictionaryLatCyr, readerLatCyr);
      dictionaryCyrLat = dictionaryFiller.FillTheDictionaries(dictionaryCyrLat, readerCyrLat);

      TransferToAnotherLanguage transform = new TransferToAnotherLanguage();
      string forTranslateToCyrrilic = null;
      string forTranslateToLatin = null;
      string resultArrayFromLat = null;
      string resultArrayFromCir = null;
      int languageChoice;
      bool key = true;
      while(key == true)
      {
        Write(MENU);
        Write(FIRSTCHOICE);
        Write(SECONDCHOICE);
        Write(ONEMORETIME);

        languageChoice = Int32.Parse(ReadLine());
        switch (languageChoice)
        {
          case 1:
            WriteLine("1: To Cyrillic");
            WriteLine(ENTERTHESTRING);
            forTranslateToCyrrilic = ReadLine();
            resultArrayFromLat = transform.TranslateToAnotherLanguage(dictionaryLatCyr, forTranslateToCyrrilic);
            Write("The new word from Latin to Cyrillic:\n");
            dictionaryFiller.PrintResultStrings(resultArrayFromLat);
            key = true;
            break;
          case 2:
            Console.WriteLine("2: To Latin");
            WriteLine(ENTERTHESTRING);
            forTranslateToLatin = ReadLine();
            resultArrayFromCir = transform.TranslateToAnotherLanguage(dictionaryCyrLat, forTranslateToLatin);
            Write("\nThe new word from Latin to Cirillic:\n");
            dictionaryFiller.PrintResultStrings(resultArrayFromCir);
            key = true;
            break;
          case 3:
            break;
        }
      }
      ReadKey();
    }
  }
}