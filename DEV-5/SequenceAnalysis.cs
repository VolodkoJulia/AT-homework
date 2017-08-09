using System;
using static System.Console;

namespace Numsequence_new
{/// <summary>
/// Class for analysis entered string.
/// </summary>
   public class SequenceAnalysis
    {
        const string ENTERED_5 = "Your sequence is nondecreasing.\n ";
        const string ENTERED_6 = "Your sequence is not nondecreasing.\n ";
        string[] sequence = ReadLine().Split();
        /// <summary>
        /// Create an array with entered information.
        /// </summary>
        /// <returns>
        /// Return an array for further verification.
        /// </returns>
        public int[] InputNumber()
        {
            int[] Array = new int[sequence.Length];
            for (int k = 0; k < sequence.Length; k++)
            {
                Array[k] = int.Parse(sequence[k]);
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
            for (int i = 1; i < sequence.Length ; i++)   
            {
                if (Array[i - 1] > Array[i])    
                {
                    return true; //  pred > sled  => ubyv => is nondecreasing
                }
            }
            return false;
        }
        /// <summary>
        /// Method for showing the result.
        /// </summary>
        /// <param name="result">
        /// Result which we want to show
        /// </param>
        /// <returns>
        ///  Information output for a definite result
        /// </returns>
        public string ShowResult(bool result)
        {
            if (result) 
            {
                // Console.WriteLine(ENTERED_5);
                return "Your sequence is nondecreasing.\n";
            }
            else
            {
                // Console.WriteLine(ENTERED_6);
                return "Your sequence is not nondecreasing.\n";
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
            if(sequence.Length == 0 || sequence.Length == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}