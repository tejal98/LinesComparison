using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LengthOfLines
    {
        public int x1, y1, x2, y2, x3, y3, x4, y4;
        public double lengthOfLine(int first, int first1, int second, int second1)
        {
            int diffOfXCordinate = first1 - first;
            int diffOfYCordinate = second1 - second;

            double XExp2 = Math.Pow(diffOfXCordinate, 2);
            double YExp2 = Math.Pow(diffOfYCordinate, 2);

            double lengthOfLine = Math.Sqrt(XExp2 + YExp2);
            return lengthOfLine;
        }
    }
    class ComparisionOfBothLines:LengthOfLines
    {
        public void EqualLines(bool checkLines)
        {
            if (checkLines)
            {
                Console.WriteLine("Lines are equal.\n");
            }
            else
            {
                Console.WriteLine("Lines are not equal.\n");
            }
        }

        public void Comparision(int compare)
        {
            if (compare > 0)
            {
                Console.WriteLine("Length of 1st line is greater than length of 2nd line. ");
            }
            else if (compare < 0)
            {
                Console.WriteLine("Length of 1st line is smaller than length of 2nd line. ");
            }
            else
            {
                Console.WriteLine("Length of 1st line is equal to length of 2nd line. ");
            }
            
        }
    }

    class LineComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");
            ComparisionOfBothLines lines = new ComparisionOfBothLines();

            Console.WriteLine("Enter the poitns of first cordinator");

            lines.x1 = Convert.ToInt32(Console.ReadLine());
            lines.y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the points of second cordinator");
            lines.x2 = Convert.ToInt32(Console.ReadLine());
            lines.y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of 1st line is ({0},{1}) ({2},{3})\n", lines.x1, lines.y1, lines.x2, lines.y2);

            double lenghtOfLineOne = lines.lengthOfLine(lines.x1, lines.x2, lines.y1, lines.y2);
            Console.WriteLine("Length of the first line is " + lenghtOfLineOne + " CM\n");

            Console.WriteLine("Enter the poitns of third cordinator");
            lines.x3 = Convert.ToInt32(Console.ReadLine());
            lines.y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the points of fourth cordinator");
            lines.x4 = Convert.ToInt32(Console.ReadLine());
            lines.y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of 2st line is ({0},{1}) ({2},{3})\n", lines.x3, lines.y3, lines.x4, lines.y4);

            double lengthOfLineTwo = lines.lengthOfLine(lines.x3, lines.x4, lines.y3, lines.y4);
            Console.WriteLine("Length of the second line is " + lengthOfLineTwo + " CM\n");

            bool checkLines = lenghtOfLineOne.Equals(lengthOfLineTwo);
            lines.EqualLines(checkLines);

            int compare = lenghtOfLineOne.CompareTo(lengthOfLineTwo);
            lines.Comparision(compare);
            
            Console.ReadLine();
        }
    }
}