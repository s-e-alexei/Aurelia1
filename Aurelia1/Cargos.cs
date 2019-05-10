﻿using System;
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
            //C:\\Users\\USER\\source\\repos\\Aurelia1\\Aurelia1\\MarineRepository\\Compartments\\Data\\        
            string[] dirPaths = Directory.GetDirectories("C:\\Users\\USER\\source\\repos\\Aurelia1\\Aurelia1\\Data\\");
            for (int j = 0; j < dirPaths.Length; j++)
            {         
            string[] filePaths = Directory.GetFiles(dirPaths[j]);

            for (int i = 0; i < filePaths.Length; i++)
            {
                    // "C:\\Users\\USER\\source\\repos\\Aurelia1\\Aurelia1\\MarineRepository\\Compartments\\Data\\"+dirname+"\\"+(i+1)+".csv")
                    holds[i] = CargoList.Get("C:\\Users\\USER\\source\\repos\\Aurelia1\\Aurelia1\\MarineRepository\\Compartments\\Data\\"+dirname+"\\"+(i+1)+".csv");
            }
            Console.WriteLine();
            }
        }
    }
}