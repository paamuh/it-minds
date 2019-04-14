using System;
using System.Collections.Generic;
using System.Text;

namespace SecretAgent
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            FindSecretAgent findSecretAgent = new FindSecretAgent();

            IEnumerable<int> soldiers = new List<int>() { 1, 5, 6, 4, 9, 2 , 22, 13, 4, 0 };

            Console.WriteLine(findSecretAgent.StartSearch(soldiers));

            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
