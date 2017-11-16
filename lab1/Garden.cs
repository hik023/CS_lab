using System;

namespace lab1
{
    class Garden: Building
    {
        protected int gardenArea;
        public Garden(int flC, int flA, int pC, int gardenArea) : base(flC, flA, pC) {
            this.gardenArea = gardenArea;
            this.fullArea = flC * flA + gardenArea;
            this.type = "Сад";
        }

        
        public int GardenArea {
            get {
                return gardenArea;
            }
            set {
                this.gardenArea = value;
            }
        }

        public override double AreaPerMan() {
            return Math.Round(Convert.ToDouble(this.fullArea) / this.peopleCount,2);
        }
    }
}
