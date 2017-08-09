using System;
using static System.Console;

namespace Numsequence_new
{/// <summary>
///  This class us used as entry point of program.
/// </summary>
    class Program
    {
        const string ENTERED_1= "This is not the sequence. Such a sequence does not exist.\n";
        const string ENTERED_2 = "Enter the sequence: ";
        const string ENTERED_3 = "The entered data is not a number. You can try once again.";
        const string ENTERED_4 = "If you want to continue, you'll press ENTER";
        /// <summary>
        /// The method with objects and сheck for exceptions 
        /// </summary>
        /// <param name="args">
        /// From command line
        /// </param>
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                var arguments = new ArgsFromCMD();
                int[] Array = arguments.GetArgs(args);
                arguments.OutputArgsToConsole();
                if (arguments.SequenceLenght())
                {
                    bool number = arguments.CheckSequence(Array);
                    Write(arguments.Result(number));
                }
                else
                {
                    Write(ENTERED_1);
                }
                ReadKey();
            }
            else
            {
                bool flag = true;
                while (flag)
                {
                    try
                    {
                        WriteLine(ENTERED_2);
                        SequenceAnalysis sequenceAnalisys = new SequenceAnalysis();
                        if (sequenceAnalisys.SequenceLenght())
                        {
                            int[] Array = sequenceAnalisys.InputNumber();
                            bool result = sequenceAnalisys.CheckSequence(Array);
                            Write(sequenceAnalisys.ShowResult(result));
                        }
                        else
                        {
                            Write(ENTERED_1);
                        }
                        WriteLine(ENTERED_4);
                        if (ReadLine().Equals("NEXT"))
                        {
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        WriteLine(ENTERED_3);
                        continue;
                    }
                    flag = false;

                    ReadKey();
                }
            }
        }
    }
}
