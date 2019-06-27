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
        
        //todo interpolation 

        public double[] GetInterpolatedValue()            
            
        {
            List<Compartment> GetInterpolatedValue = new List<Compartment>();

            double vi1 = 1; //Convert.ToDouble(Console.ReadLine());
            int pos1 = 0;
                for (int i = 0; i < GetInterpolatedValue.Count; i++)
                {
                     if (GetInterpolatedValue[i].Volume > vi1)
                     {
                        pos1 = i - 1; //x1 = xmin
                            break;
                     } 
                }
            Console.WriteLine(pos1 + "   ");
            Console.WriteLine();


            double[] xyz = new double[3];

            xyz [0] = Math.Abs((((GetInterpolatedValue[pos1 + 1].X - GetInterpolatedValue[pos1].X)) / (GetInterpolatedValue[pos1 + 1].Volume - GetInterpolatedValue[pos1].Volume)) * (vi1 - GetInterpolatedValue[pos1].Volume) + GetInterpolatedValue[pos1].X);
            xyz [1] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Y - GetInterpolatedValue[pos1].Y)) / (GetInterpolatedValue[pos1 + 1].Volume - GetInterpolatedValue[pos1].Volume)) * (vi1 - GetInterpolatedValue[pos1].Volume) + GetInterpolatedValue[pos1].Y);
            xyz [2] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Z - GetInterpolatedValue[pos1].Z)) / (GetInterpolatedValue[pos1 + 1].Volume - GetInterpolatedValue[pos1].Volume)) * (vi1 - GetInterpolatedValue[pos1].Volume) + GetInterpolatedValue[pos1].Z);
           

            
            return xyz;      


        }
    }
}
