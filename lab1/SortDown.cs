using System.Collections.Generic;

namespace lab1
{
    class SortDown:IComparer<Building>
    {
        public int Compare(Building b1, Building b2)
        {
            if (b1.FullArea < b2.FullArea) return 1;
            else if (b1.FullArea > b2.FullArea) return -1;
            else return 0;
        }
    }
}
