using System;

namespace lab1
{
    class Cottage: Building
    {
        public Cottage(int flC, int flA, int pC) : base(flC, flA, pC) {
            this.fullArea = flC * flA;
            this.type = "Коттедж";
        }
        public override double AreaPerMan() {
            return Math.Round(Convert.ToDouble(this.fullArea) / this.peopleCount,2);
        }
    }
}
