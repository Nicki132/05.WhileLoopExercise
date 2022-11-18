using System;

namespace Т06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            double countPieces = 0;
            double piece = 0;

            while (cakeLenght == cakeWidth)
            {
                if (countPieces > 0)
                {
                    piece = countPieces - piece;
                }
                else if (true)
                {

                }
                counter++;
            }
        }
    }
}
