using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class SortUp : IComparer<Building>
    {
        public int Compare(Building b1, Building b2)
        {
            if (b1.FullArea > b2.FullArea) return 1;
            else if (b1.FullArea < b2.FullArea) return -1;
            else return 0;
        }
    }
}
