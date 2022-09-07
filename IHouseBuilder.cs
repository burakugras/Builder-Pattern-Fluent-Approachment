using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Builder_ex5
{
    interface IHouseBuilder
    {
        IHouseBuilder BuildBasement(int basement);
        IHouseBuilder BuildWalls(int walls);
        IHouseBuilder BuildWindows(int windows);
        IHouseBuilder BuildDoors(int doors);
        IHouseBuilder BuildisDurable(bool isDurable);
        IHouseBuilder BuildRoof(bool roof);
        House Build();
    }
}
