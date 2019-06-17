using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelia1
{
    class CompartmentsList
    {
        public static List<Compartment> Get(string filename)        
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
            
            List<Compartment> compartment = new List<Compartment>();

            foreach (Double[] item in st1)
            {
                compartment.Add(new Compartment(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9]));

            }

           Console.WriteLine("Input vi1:");

            double vi1 = 1; //Convert.ToDouble(Console.ReadLine());
            int pos1 = 0;
            for (int i = 0; i < compartment.Count; i++)
            {
                if (compartment[i].Volume > vi1)
                {
                    pos1 = i - 1; //x1 = xmin
                    break;
                }
            }
            Console.WriteLine(pos1 + "   ");
            Console.WriteLine();

            double xi1 = Math.Abs((((compartment[pos1 + 1].X - compartment[pos1].X)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].X);
            double yi1 = Math.Abs((((compartment[pos1 + 1].Y - compartment[pos1].Y)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].Y);
            double zi1 = Math.Abs((((compartment[pos1 + 1].Z - compartment[pos1].Z)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].Z);

            Console.WriteLine("xi1: " + xi1);
            Console.WriteLine("yi1: " + yi1);
            Console.WriteLine("zi1; " + zi1);
            Console.WriteLine();
            
  //          Console.Read();
            
            return compartment;
        }
    }
}
