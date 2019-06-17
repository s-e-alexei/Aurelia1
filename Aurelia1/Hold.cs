using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelia1
{
    class Hold
    {
        List<Compartment> list;
        string title;

        public Hold(List<Compartment> list, string title)
        {
            this.list = list;
            this.title = title;
        }

        public override string ToString()
        {
            string result = title + "\n";

            foreach (var subitem in list)
                result += subitem.ToString() + " ";

            return (result + "\n");
        }

        public double[] GetInterpolatedValue()            
            
        {
            List<Compartment> GetInterpolatedValue = new List<Compartment>();
            double[] xyz = new double[3];

            xyz [0] = Math.Abs((((GetInterpolatedValue[pos1 + 1].X - GetInterpolatedValue[pos1].X)) / (GetInterpolatedValue[pos1 + 1].Volume - GetInterpolatedValue[pos1].Volume)) * (vi1 - GetInterpolatedValue[pos1].Volume) + GetInterpolatedValue[pos1].X);
            xyz [1] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Y - GetInterpolatedValue[pos1].Y)) / (GetInterpolatedValue[pos1 + 1].Volume - GetInterpolatedValue[pos1].Volume)) * (vi1 - GetInterpolatedValue[pos1].Volume) + GetInterpolatedValue[pos1].Y);
            xyz [2] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Z - GetInterpolatedValue[pos1].Z)) / (GetInterpolatedValue[pos1 + 1].Volume - GetInterpolatedValue[pos1].Volume)) * (vi1 - GetInterpolatedValue[pos1].Volume) + GetInterpolatedValue[pos1].Z);
           

            //todo interpolation 
            return xyz;

            /*List<Compartment> compartment = new List<Compartment>();

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
            */






        }
    }
}
