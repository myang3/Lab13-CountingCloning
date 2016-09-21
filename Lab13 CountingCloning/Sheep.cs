using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_CountingCloning
{
    public class Sheep: Countable, ICloneable
    {
        private int count = 0;
        private String name;
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
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
            return getCount() + " " + getName();
        }

        public object Clone()
        {
            resetCount();
            Sheep clone = new Sheep();
            return clone;
        }
    }
}
