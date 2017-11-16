namespace lab1
{
    abstract class Building
    {
        protected int floorCount;
        protected int floorArea;
        protected int peopleCount;
        protected int fullArea;
        public string type;
        public Building(int flC, int flA, int pC) {
            this.floorCount = flC;
            this.floorArea = flA;
            this.peopleCount = pC;
        }
        
        public int FullArea
        {
            get
            {
                return fullArea;
            }
        }

        static public int Comp(Building b1, Building b2)
        {
            int answ = b1.FloorArea.CompareTo(b2.FloorArea);
            return answ;
        }

        public int FloorCount {
            get {
                return floorCount;
            }
            set {
                floorCount = value;
            }
        }
        
        public int FloorArea {
            get {
                return floorArea;
            }
            set {
                floorArea = value;
            }
        }
        
        public int PeopleCount {
            get {
                return peopleCount;
            }
            set {
                peopleCount = value;
            }
        }

        abstract public double AreaPerMan();

    }
}
