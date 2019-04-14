using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretAgent
{
    public class FindSecretAgent : IFindSecretAgent
    {
        public int StartSearch(IEnumerable<int> ids)
        {
            // YOUR SOLUTION GOES HERE
            
            //Make a HashSet to compare with
            HashSet<int> set = new HashSet<int>();

            //Iterate through all the ids.
            foreach (int id in ids)
            {
                //Adds to the set and check if the it is already in the set. If it is then we found the duplicate/spy.
                if (set.Contains(id))
                {
                    return id;
                } else
                {
                    //adds to the set if the set doesnt have it already.
                    set.Add(id);
                }
                
            }
            
            return 0;

            
        }

    }
}
