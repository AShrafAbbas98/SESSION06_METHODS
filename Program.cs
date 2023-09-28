using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Session_05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Create a new List to store you personal data

            //Print("Hello", "World" ,2023); ==> Correct

            //Print(20, "ssss");   Wrong ===>>>>>>>>> dont mix paramters


            // -----------------------------------------------------------------------------------------------------

            //Console.WriteLine("Please Enter Your name");
            //string name = Console.ReadLine();

            //Console.WriteLine("What is your budget?");
            //double budget = double.Parse(Console.ReadLine());

            //Console.WriteLine("Did you start the project? Yes or No??");
            //string ans = Console.ReadLine();

            //bool status = false;
            //switch (ans)
            //{
            //    case "Yes":
            //        status = true;
            //        break;

            //    case "No":
            //        status = false;
            //        break;

            //        default:
            //        Console.WriteLine("Your answer isn't valid");
            //        break;
            //}


            //List<Object> contractorData = new List<object>();

            //contractorData.Add(name);
            //contractorData.Add(budget);
            //contractorData.Add(status);


            //GetContractorData(name, budget, status);




            //Console.WriteLine("What is the building Width?");
            //double Width = double.Parse(Console.ReadLine());

            //Console.WriteLine("What is the building height?");
            //double height = double.Parse(Console.ReadLine());

            //Console.WriteLine("What is the building depth?");
            //double depth = double.Parse(Console.ReadLine());

            //GetBuildingData(Width, height, depth);


            //double buildingArea = CalulateArea(Width, depth);


            //Console.WriteLine($"The building area is {buildingArea} m2");


            //double buildingVolumne = CalculateVolume(buildingArea, height);


            //Console.WriteLine("Choose what you want \n" +
            //                  " #1 for Calculating Area \n" +
            //                  " #2 for Calculating Volume");
            //int choose = int.Parse(Console.ReadLine());

            //switch (choose)
            //{
            //    case 1:
            //        Console.WriteLine($"Your Building Area is {buildingArea} m2");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Your Building Volume is {buildingVolumne} m3");
            //        break;

            //    default:
            //        Console.WriteLine("Input in valid!!!!!!!!!");
            //        break;
            //}


            // -----------------------------------------------------------------------------------------------------


            Console.WriteLine("What are the No. of Columns?");

            int noOfCol = int.Parse(Console.ReadLine());
            double width = 0; 
            double height = 0; 
            double depth = 0;


            for (int i = 0; i < noOfCol; i++)
            {
                MethodDB.PrintData(i, width, depth, height);
            }


        }


        // Method with void return type
        //******************************
        /* A method with a "void" return type means it doesn't return any value.
        It performs a task or an action or takes a data but doesn't provide any data back to the caller. */


        // Print


        /// <summary>
        /// This method prints string into Console App
        /// </summary>
        /// <param name="text"> first text</param>
        /// <param name="word"> second text</param>
        /// <param name="year">Year of today</param>
        public static void Print (string text, string word, int year)
        {
            Console.WriteLine(text + word + year);    
        }


        // GetContractorData

        public static void GetContractorData(string Name, double budget , bool status)
        {
            Console.WriteLine($"Contractor Name: {Name} \n" +
                              $"Contractor Budget: {budget} EGP \n" +
                              $"Project status: {status}");
        }



        // GetBuildingData

        public static void GetBuildingData(double width, double height, double depth)
        {
            Console.WriteLine($"Buidling width: {width} m\n" +
                              $"Buidling height: {height} m \n" +
                              $"Buidling depth: {depth} m");
        }

        //---------------------------------------------------------------------------------------

        // Method with return type
        //*************************
        /* A method with a return type provides data back to the caller. */


        // DisplayContractorData

        // CalulateArea 

        public static double CalulateArea(double width, double depth)
        {
            double area = width * depth;

            return area;
        }

        // CalculateVolume

        /// <summary>
        /// This method Calc Area of a building
        /// </summary>
        /// <param name="area">area of a building</param>
        /// <param name="area">area of a building</param>
        /// <param name="height">height oof </param>
        /// <returns>double</returns>
        public static double CalculateVolume(double area, double height)
        {
            double volume = area * height;

            return volume;
        }


        public static void PrintData(int i , double width, double depth, double height)
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

        //---------------------------------------------------------------------------------------



        // Challange
        // Write A method that represents a Law in your Displine and then 
        //01- take the inputs from the user
        //02- Put the input in the method
        //03- Show the user the output from your method.



    }

}
