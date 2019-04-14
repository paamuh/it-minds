using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var currentCustomer = Customers
                .Create("Kim")
                .Previous("Hans")
                .Previous("Ole")
                .Previous("Peter");

            //Testing out the method
            //Finder finder = new Finder();
            //string personFound = finder.FromRight(currentCustomer, 2);


            while (currentCustomer != null)
            {
                if (currentCustomer.Next != null)
                    Console.Write(currentCustomer.Person + " -> ");
                else
                    Console.WriteLine(currentCustomer.Person);

                currentCustomer = currentCustomer.Next;
            }

            //just to print the answer
            //Console.WriteLine(personFound);

            //cant use ctrl + f5 on this computer
            Console.WriteLine("Press any key to close");
            Console.ReadKey();




        }

        

    }
}
