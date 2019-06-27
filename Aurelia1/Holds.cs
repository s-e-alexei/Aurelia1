using System.Collections.Generic;

namespace Aurelia1
{
    class Holds
    {
        List<Hold> list;

        public Holds()
        {
            this.list = new List<Hold>();
        }

        public void Add(Hold hold)
        {
            list.Add(hold);
        }

        public Hold GetLast()
        {
            return list[list.Count-1];
        }

        public double [] GetByTitleValue(string title, double value)
        {
            int index = 0;
            // todo search by title - index
            for (int i = 0; i < title.Length; i++) // for (int i = 0; i < list.Count; i++)
            {
                index ++;
                
            }
           

            // for found hold call 
            double[] xyz = list[index].GetInterpolatedValue();
            return xyz;
        }
    }
}