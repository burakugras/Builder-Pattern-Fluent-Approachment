using System;

namespace _05_Builder_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBuilder houseBuilder = new HouseBuilder();
            House house = houseBuilder.BuildBasement(1).BuildisDurable(true).BuildWalls(12).BuildDoors(4).BuildWindows(8).BuildRoof(true).Build();
            Console.ReadKey();
        }
    }
}
