using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Line_Comparison
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public void LineComparison()
        {


            double lenght;

            lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Length of a given Line is: " + lenght);
        }
    }
}
