using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelia1
{
    class Cargos
    {
        List<List<CargoHold>> holds;
        int holdNumber;

        public Cargos(string dirname)
        {
            holds = new List<List<CargoHold>>();
                   
            string[] dirPaths = Directory.GetDirectories("..\\..\\Data\\Compartments\\");

            for (int j = 0; j < dirPaths.Length; j++)
            {
                string[] filePaths = Directory.GetFiles(dirPaths[j]);
                string[] dirPaths2 = Directory.GetDirectories(dirPaths[j] + "\\");
                    if (dirPaths2.Length != 0)
                    {
                       for (int i = 0; i < dirPaths2.Length; i++)
                       {
                         string[] filePaths2 = Directory.GetFiles(dirPaths2[i]);
                            for (int k = 0; k < filePaths2.Length; k++)
                            {
                                Console.WriteLine(filePaths2[k]);
                                holds.Add(CargoList.Get(filePaths2[k]));
                            }
                       }
                    }                
                for (int i = 0; i < filePaths.Length; i++)
                {                   
                    Console.WriteLine(filePaths[i]);
                    holds.Add(CargoList.Get(filePaths[i]));
                    holds[i] = new List<CargoHold>();
                    holds[i] = CargoList.Get("..\\..\\Data\\Compartments\\CargoHold\\CargoHold1.csv");

                }

                Console.WriteLine();
            }
        }
    }
}
