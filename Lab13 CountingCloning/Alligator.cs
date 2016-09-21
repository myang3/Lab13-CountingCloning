using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_CountingCloning
{
    public class Alligator: Countable
    {

        private int count = 0;

        public int formatCount()
        {
            return count;
        }

        public void incrementCount()
        {
            count++;
        }

        public void resetCount()
        {
            count = 0;
        }

        public int getCount()
        {
            return count;
        }

        public String getCountString()
        {
            return getCount() + " Alligator";
        }

    }
}
