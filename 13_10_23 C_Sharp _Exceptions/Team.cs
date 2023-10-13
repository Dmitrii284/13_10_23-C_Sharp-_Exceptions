using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13_10_23_C_Sharp__Exceptions
{
    internal class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker) { workers.Add(worker); }

        public void Work(House house)
        {

            while (house.roof == null)
            {
                foreach (IWorker worker in workers)
                    worker.Work(house);
            }
        }
    }
}
