using System;
using System.Collections.Generic;
using System.Linq;

namespace Aurelia1
{
    class CargoHold
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

        public CargoHold(Double level, Double volume, Double x, Double y, Double z, Double square, Double freeX, Double freeY, Double freeIx, Double freeIy)
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
}






