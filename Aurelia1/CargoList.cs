using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelia1
{
    class CargoList
    {
        public static List<CargoHold> Get(string filename)
        
        {

            List<Double[]> st1 = new List<Double[]>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(filename))

                    st1.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }

            List<CargoHold> cargoHold1 = new List<CargoHold>();

            foreach (Double[] item in st1)
            {
                cargoHold1.Add(new CargoHold(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9]));

                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();
            }

           Console.WriteLine("Input vi1:");

            double vi1 = Convert.ToDouble(Console.ReadLine());
            int pos1 = 0;
            for (int i = 0; i < cargoHold1.Count; i++)
            {
                if (cargoHold1[i].Volume > vi1)
                {
                    pos1 = i - 1; //x1 = xmin
                    break;
                }
            }
            Console.WriteLine(pos1 + "   ");
            Console.WriteLine();

            double xi1 = Math.Abs((((cargoHold1[pos1 + 1].X - cargoHold1[pos1].X)) / (cargoHold1[pos1 + 1].Volume - cargoHold1[pos1].Volume)) * (vi1 - cargoHold1[pos1].Volume) + cargoHold1[pos1].X);
            double yi1 = Math.Abs((((cargoHold1[pos1 + 1].Y - cargoHold1[pos1].Y)) / (cargoHold1[pos1 + 1].Volume - cargoHold1[pos1].Volume)) * (vi1 - cargoHold1[pos1].Volume) + cargoHold1[pos1].Y);
            double zi1 = Math.Abs((((cargoHold1[pos1 + 1].Z - cargoHold1[pos1].Z)) / (cargoHold1[pos1 + 1].Volume - cargoHold1[pos1].Volume)) * (vi1 - cargoHold1[pos1].Volume) + cargoHold1[pos1].Z);

            Console.WriteLine("xi1: " + xi1);
            Console.WriteLine("yi1: " + yi1);
            Console.WriteLine("zi1; " + zi1);
            Console.WriteLine();

            Console.Read();
            
            return cargoHold1;
        }
    }
}
