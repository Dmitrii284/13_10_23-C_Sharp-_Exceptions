using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_10_23_C_Sharp__Exceptions
{
    internal class Worker: IWorker
    {
        public void Work(House house)
        {
            if (house.roof == null)
            {
                house.basement = new Basement();
                house.basement.Build();
            }   
            if(house.walls == null )
            {
                house.walls = new Walls();
                house.walls.Build();
            }
            if (house.window == null)
            {
                house.window = new Window();
                house.window.Build();
            }
            if (house.door == null)
            {
                house.door = new Door();
                house.door.Build();
            }
            if (house.roof == null)
            {
                house.roof = new Roof();
                house.roof.Build();
            }
        }
    }
}
