using System;
//find a Armstrong number a question from PSCP
//programming fundamentals
namespace programingfunda
{
    class Program
    {
        static void Main(string[] args)
        {
            int usern;
            int cube;
            int sum = 0, store;
            Console.Write("Welcome to Armstrong Finder\n"); //here We ask for number
            Console.Write("Please Enter any number to find Armstrong: "); //here consule will get the input
            usern = int.Parse(Console.ReadLine());
            store = usern; // I store the input in store vaiable
            while (usern > 0) //check number should be 0 for run loop
            {
                cube = usern % 10; //here we mode input by 10
                sum = sum + (cube * cube * cube);
                usern = usern / 10; 
            }
            if (store == sum)
                Console.Write("its a armstrong no.");
            else
                Console.Write("its not a armstrong no.");
        }
    }
}
