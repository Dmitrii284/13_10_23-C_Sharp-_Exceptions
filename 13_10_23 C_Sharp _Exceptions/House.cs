using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_10_23_C_Sharp__Exceptions
{/*. Дом 
состоит из фундамента (Basement), стен (Wall), окон 
(Window), дверей (Door), крыши (Part).*/
    internal class House
    {
        public Basement? basement { get; set; }
        public Walls? walls { get; set; }
        public Window? window { get; set; }
        public Door? door { get; set; }
        public Roof? roof { get; set; }
        
        public void Build()
        {
            Team team = new Team();
            team.Work(this);
            Console.WriteLine($"У дома Построено : {this}");
        }
        public void Report()
        {
            List<string> CompletDetails = new List<string>();
            if (basement != null) CompletDetails.Add("Фундамент");
            if(walls != null) CompletDetails.Add("Окно");
            if (window != null) CompletDetails.Add("Окно");
            if (door != null) CompletDetails.Add("Дверь");
            if (roof != null) CompletDetails.Add("Крыша");
            Console.WriteLine($"Завершенные части постройки: {string.Join(", ", CompletDetails)}");            
        }
    }
}
