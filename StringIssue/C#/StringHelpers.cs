using System.Collections.Generic;
using System;

namespace StringIssue
{
    public static class StringHelpers
    {
        /// <summary>
        /// Method that does not perform well.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string MergeStrings(IEnumerable<string> strs)
        {
            var toReturn = "";

            foreach (var str in strs)
            {
                toReturn += str;
            }
            Console.WriteLine(toReturn);
            return toReturn;
        }
        // The function Concat do not need to allocate new memory evry time it is going to add one more string to 'toReturn' as the += operator does.
        // The Concat allocate all the memory it needs one time when it sees how much it is going to handle. 
        // I use the concat since we get all the strings in as parameter.
        public static string BetterMergeStrings(IEnumerable<string> strs)
        {
            var toReturn = string.Concat(strs);


            return toReturn;
        }

       
    }
}

/* Explain why your solution is faster below this line

*/
