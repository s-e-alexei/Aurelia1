using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Compartments holds = new Compartments("holds");
            //Cargos ballasts = new Cargos("ballast");
            double [] xyz = holds.holds.GetByTitleValue("cargohold1", 32);

            Console.Read();
        }
    }
}
