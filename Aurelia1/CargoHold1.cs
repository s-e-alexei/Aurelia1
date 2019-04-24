using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelia_1
{
    class CargoHold1
    {
        private Double level;
        private Double volume;
        private Double x;
        private Double y;
        private Double z;
        private Double square;
        private Double freeX;
        private Double freeY;
        private Double freeIx;
        private Double freeIy;

        public double Level { get => level; set => level = value; }
        public double Volume { get => volume; set => volume = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public double Square { get => square; set => square = value; }
        public double FreeX { get => freeX; set => freeX = value; }
        public double FreeY { get => freeY; set => freeY = value; }
        public double FreeIx { get => freeIx; set => freeIx = value; }
        public double FreeIy { get => freeIy; set => freeIy = value; }

        public CargoHold1(Double level, Double volume, Double x, Double y, Double z, Double square, Double freeX, Double freeY, Double freeIx, Double freeIy)
        {
            this.level = level;
            this.volume = volume;
            this.x = x;
            this.y = y;
            this.z = z;
            this.square = square;
            this.freeX = freeX;
            this.freeY = freeY;
            this.freeIx = freeIx;
            this.FreeIy = freeIy;
        }
        public override string ToString()
        {
            return $"{Level},{Volume},{X}, {Y}, {Z} {Square}, {FreeX},{FreeY}, {FreeIx},{FreeIy} , m\n";
        }
    }
    class ProgramCargoHold1
    {
        //static void Main(string[] args)
        static void Cargo(string[] args)
        {
            List<Double[]> st1 = new List<Double[]>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(@"C:\Users\Alex\source\repos\Aurelia 1\Aurelia 1\MarineRepository\Compartments\Data\CargoHold1.csv"))

                    st1.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }

            List<CargoHold1> cargoHold1 = new List<CargoHold1>();

            foreach (Double[] item in st1)
            {
                cargoHold1.Add(new CargoHold1(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9]));

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

        }
    }
}





