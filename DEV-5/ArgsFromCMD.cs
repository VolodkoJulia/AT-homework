using System;
using static System.Console;

namespace Numsequence_new
{
    /// <summary>
    /// Class which workes with arguments from command line
    /// </summary>
    /// </summary>
    class ArgsFromCMD
    {
        string[] args = null;
        const string ENTERED_5 = "\n Your sequence is nondecreasing. ";
        const string ENTERED_6 = "\n Your sequence is not nondecreasing. ";
        /// <summary>
        /// Metod for getting the arguments from command line
        /// </summary>
        /// <param name="argsFromConsole">
        /// The arguments which we write to the array
        /// </param>
        /// <returns>
        /// Array wih arguments
        /// </returns>
        public int[] GetArgs(string[] argsFromConsole)
        {
            args = argsFromConsole;
            int[] Array = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                Array[i] = int.Parse(args[i]);
            }
            return Array;
        }
        /// <summary>
        /// Sequence check for decreasing.
        /// </summary>
        /// <param name="Array">
        /// Array wich we get after entering.
        /// </param>
        /// <returns>
        ///  Return the result.
        /// </returns>
        public bool CheckSequence(int[] Array)
        {
            for (int i = 1; i < args.Length; i++)
            {
                if (Array[i - 1] > Array[i])
                {
                    return true; // pred>sled => ybuv
                }
            }
            return false;
        }
        /// <summary>
        /// Method for showing the information about result.
        /// </summary>
        /// <param name="result">
        /// Result which we got after check
        /// </param>
        /// <returns>
        ///  Result which we analyze
        /// </returns>
        public string Result(bool result)
        {
            if (result)
            {
                return ENTERED_6;
            }
            else
            {
                return ENTERED_5;
            }
        }
        /// <summary>
        /// Checking for the existence of a sequence.
        /// </summary>
        /// <returns>
        /// The information about the length.
        /// </returns>
        public bool SequenceLenght()
        {
            if (args.Length == 0 || args.Length == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// For output args
        /// </summary>
        public void OutputArgsToConsole()
        {
            foreach (var a in args)
            {
                Write(a + " ");
            }
                Write("\n");
        }
    }
}
