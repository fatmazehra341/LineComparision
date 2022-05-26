using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
     class LineComparisionProgram
    {
        public static void lengthOfTwoLines()

        {
            Console.WriteLine("This is a program for Line Comparison");
            Console.WriteLine("Enter the coordinates");
            //UC1
            double x1, y1, x2, y2, length1;//Variables

            Console.WriteLine("enter x1: "); 
            x1 = Convert.ToDouble(Console.ReadLine()); //Converting string to double

            Console.WriteLine("enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            Console.WriteLine("enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            Console.WriteLine("enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));//Mathmatical farmula to finding the lenght two lines
            Console.WriteLine("Greater line is {0}",length1);

            //UC2
            double a1, b1, a2, b2, length2;//Variables

            Console.WriteLine("enter a1: ");
            a1 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            Console.WriteLine("enter b1: ");
            b1 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            Console.WriteLine("enter a2: ");
            a2 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            Console.WriteLine("enter b2: ");
            b2 = Convert.ToDouble(Console.ReadLine());//Converting string to double

            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));//Mathmatical farmula to finding the lenght two lines
            Console.WriteLine("Greater Line is {0}",length2);

            //UC3
            if (length1.CompareTo(length2) == 0)//Comparing lenght1 and lenght2 finding which is bigger
            {
                Console.WriteLine("Lines are of equal length");
            }

            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line1 is bigger than Line2");
            }
            else
            {
                Console.WriteLine("Line2 is bigger than Line1");
            }
            Console.ReadLine();
        }

    }
}
