using System;

namespace lab1
{
    class Garage: Building
    {
        public Garage(int flC, int flA) : base(flC, flA, 0) {
            this.fullArea = flC * flA;
            this.type = "Гараж";
        }
        public override double AreaPerMan() {
            return Math.Round(Convert.ToDouble(this.fullArea),2);
        }
    }
}
