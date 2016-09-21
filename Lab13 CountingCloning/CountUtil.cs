using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_CountingCloning
{
    public class CountUtil
    {
        public static void count(Countable c, int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                c.incrementCount();
                c.getCount();

                Console.WriteLine(c.getCountString());
            }
        }
    }
}
