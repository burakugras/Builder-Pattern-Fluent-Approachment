using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Builder_ex5
{
    class HouseBuilder : IHouseBuilder
    {
        House house;
        public HouseBuilder()
        {
            house = new House();
        }

        public IHouseBuilder BuildBasement(int basement)
        {
            house.Basement = basement;
            return this;
        }
        public IHouseBuilder BuildWalls(int walls)
        {
            house.Walls = walls;
            return this;
        }

        public IHouseBuilder BuildDoors(int doors)
        {
            house.Doors = doors;
            return this;
        }

        public IHouseBuilder BuildisDurable(bool isDurable)
        {
            house.isDurable = isDurable;
            return this;
        }

        public IHouseBuilder BuildRoof(bool roof)
        {
            house.Roof = roof;
            return this;
        }               

        public IHouseBuilder BuildWindows(int windows)
        {
            house.Windows = windows;
            return this;
        }

        public House Build()
        {            
            return house;
        }
    }
}
