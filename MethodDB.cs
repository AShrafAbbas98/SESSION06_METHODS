using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MethodDB
    {

        // CalulateArea 

        public static double CalulateArea(double width, double depth)
        {
            double area = width * depth;

            return area;
        }

        // CalculateVolume

        public static double CalculateVolume(double area, double height)
        {
            double volume = area * height;

            return volume;
        }


        public static void PrintData(int i, double width, double depth, double height)
        {
            try
            {
                Console.WriteLine($"What is the width of Column No.{i + 1}?");
                width = int.Parse(Console.ReadLine());
                Console.WriteLine($"What is the depth of Column No.{i + 1}?");
                depth = int.Parse(Console.ReadLine());
                Console.WriteLine($"What is the height of Column No.{i + 1}?");
                height = int.Parse(Console.ReadLine());


                double area = CalulateArea(width, depth);
                double vol = CalculateVolume(area, height);

                Console.WriteLine();
                Console.WriteLine("----------------------------------");

                Console.WriteLine($"Volume for Element No.{i + 1} is {vol} m3");

                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
