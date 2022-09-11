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
            int a1 = x1;
            int b1 = y1;
            int a2 = x2;
            int b2 = y2;

            double lenght;
            double lenght1;

            lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Length of a given Line is: " + lenght);

            lenght1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of a given Line is: " + lenght1);

            if (lenght1 == lenght)
            {
                Console.WriteLine("Both lines are Equal.");
            }
            else if (lenght > lenght1)
            {
                Console.WriteLine("Line with co-ordinates x1,y1,x2,y2 is greater and other one os smaller.");
            }
            else
            {
                Console.WriteLine("Line with co-ordinates a1,b1,a2,b2 is greater and other one is smaller.");
            }
        }
    }
}
