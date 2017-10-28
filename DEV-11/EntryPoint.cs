using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace TransformWords
{
  // The entry point of the programm.
  class EntryPoint
  {
    const string PATHLATTOCYR = @"...path to you Latin-Cyrillic dictionary: DicLatCirDown.txt...";
    const string PATHCYRTOLAT = @"...path to you Cyrillic-Latin dictionary: DictCirLatDown.txt";
    const string MENU = "\nChose the language, on wich you want to translate:";
    const string FIRSTCHOICE = "\n1 - To Cyrillic.";
    const string SECONDCHOICE = "\n2 - To Latin.";
    const string ENTERTHESTRING = "Enter the string:";
    const string ONEMORETIME = "\n3 - To enter again.\n >>";
    const string FROMCYRTOLAT = "\nThe new word from Cyrillic to Latin:\n";
    const string FROMLATTOCYR = "\nThe new word from Latin to Cyrillic:\n";
    const string TOCYRRILIC = "1: To Cyrillic";
    const string TOLATIN = "2: To Latin";

    // For colling the right method by user request to transfer from one language to another one.
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

      bool choice = true;
      while(choice == true)
      {
        choice = false;
        Write(MENU);
        Write(FIRSTCHOICE);
        Write(SECONDCHOICE);
        Write(ONEMORETIME);

        switch (Int32.Parse(ReadLine()))
        {
          case 1:
            WriteLine(TOCYRRILIC);
            WriteLine(ENTERTHESTRING);
            transform.PrintResultString(transform.GetWordsAndTranslateIt(dictionaryLatCyr));
            choice = true;
            break;
          case 2:
            WriteLine(TOLATIN);
            WriteLine(ENTERTHESTRING);
            transform.PrintResultString(transform.GetWordsAndTranslateIt(dictionaryCyrLat));
            choice = true;
            break;
          case 3:
            choice = true;
            break;
        }
      }
      ReadKey();
    }
  }
}