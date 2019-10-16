using System;

namespace danceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double hallAreaM = (hallLength * 100) * (hallWidth * 100);
            double seatArea = hallAreaM / 10;
            double cleanArea = hallAreaM - seatArea - wardrobeArea;
            double dancersNumber = cleanArea / (40 + 7000);

            Console.WriteLine(Math.Floor(dancersNumber));
           
        }
    }
}
