using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_10_23_C_Sharp__Exceptions
{
    internal class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine($"У дома Построено : {this}");
        }
    }
}
