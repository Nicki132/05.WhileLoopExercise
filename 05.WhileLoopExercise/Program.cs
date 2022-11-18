using System;

namespace _05.WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int counter = 0;
            bool isbookFound = false;
            string nextBookName = Console.ReadLine();

            while (nextBookName != "No More Books")
            {
                if (nextBookName == favoriteBook)
                {
                    isbookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isbookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else 
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
