/*Zachary Miller
 * 1/29/2014
 * rectangle perimeter and area
 * assignment 3-3
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class Rectangle
    {
        public static double ComputeArea(double height, double width)
        {
            double area = (height * width);
            return area;
        }
        // this method computes the perimeter by multiplying the height and width by 2 and then adding them together
        public static double ComputePerimeter(double height, double width)
        {
            double perimeter = ((height * 2) + (width * 2));
            return perimeter;
        }
        //method displays the results found in ComputeArea and ComputePerimeter
        public static void DisplayResults(double height, double width, double area, double perimeter)
        {
            Console.WriteLine("Summary of Rectangle Measurements: \n\n");
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("The area of the rectangle is: " + "{0:f2}", area);
            Console.WriteLine("The perimeter of the rectangle is: " + "{0:f2}", perimeter);
            return;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the height of the rectangle: ");
            string inputValue = Console.ReadLine();
            double height = double.Parse(inputValue);
            Console.Write("Enter the width of the rectangle: ");
            inputValue = Console.ReadLine();
            double width = double.Parse(inputValue);
            double area = ComputeArea(height, width);
            double perimeter = ComputePerimeter(height, width);
            DisplayResults(height, width, area, perimeter);
        }
    }
}
