using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_CountingCloning
{
    public class CountTestApp : CountUtil
    {
        static void Main(string[] args)
        {
            Alligator gator = new Alligator();

            Console.WriteLine("Counting Alligators...");
            Console.WriteLine("");
            CountUtil.count(gator, 3);

            Sheep sheep1 = new Sheep();
            Console.WriteLine("");
            Console.WriteLine("Counting Sheep...");
            Console.WriteLine("");

            sheep1.setName("Blackie");
            CountUtil.count(sheep1, 2);
            Console.WriteLine("");
            Sheep clone = (Sheep)sheep1.Clone();
            clone.setName("Dolly");
            CountUtil.count(clone, 3);
            Console.WriteLine("");
            CountUtil.count(sheep1, 1);

            Console.ReadLine();
        }
    }
}
