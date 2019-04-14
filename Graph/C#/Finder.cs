using System;

namespace Graph
{
    public class Finder : IFinder
    {
        public string FromRight(Customers customers, int numberFromRight)
        {
            // YOUR SOLUTION GOES HERE

            
            string answer = customers.Person;
            //Use a for loop to count it's way to the right, until it 
            //is in the correct position, then returns the answer. 
            //If the request is to many steps to the right it get 'Out of bound'
            //as an answer.

            for(int i = 0; i < numberFromRight; i++)
            {
                if(customers.Next != null)
                {
                    customers = customers.Next;
                    answer = customers.Person;

                } else
                {
                    return answer = "Out of bound";
                }
            }

            return answer;
        }
    }
}