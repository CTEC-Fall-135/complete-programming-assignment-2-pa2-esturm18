
/* Name: Emma Sturm
   Date: 10/07/2024
   Assignment2: Practice casting, ints, loops, and switch cases. 
   CSE 135 */

using System;
using System.Diagnostics;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Fixed Sized Ints
            //This region tests out printing the max value as an integer and in hex
            Console.WriteLine("Fixed Sized Ints"); 
            int maxValue = int.MaxValue;
            Console.WriteLine($"    myInt max value:    {maxValue}   {maxValue:X}");
            maxValue++;
            Console.WriteLine($"    myInt max value:    {maxValue}  {maxValue:X}");
            maxValue = 0;
            Console.WriteLine($"    myInt max value:    {maxValue}            {maxValue:X}");
            maxValue--;
            Console.WriteLine($"    myInt max value:    {maxValue}           {maxValue:X}");
            Console.WriteLine();
            #endregion

            #region Casting
            //This region tests out casting larger things into smaller ones. 
            Console.WriteLine("Casting");
            int value = int.MaxValue;
            Console.WriteLine($"    myInt max value :   {value}   {value:X}");
            short myShort = (short) value;
            Console.WriteLine($"    myShort:            {myShort}           {myShort:X}");
            Console.WriteLine();
            #endregion

            #region Loops
            //This region practices using both a for loop and a foreach loop
            Console.WriteLine("Loops");
            int num = 0; 
            int[] myArray = new int[5];
            for(int i=0; i<5; i++)
            {
                myArray[i] = num;
                num++;
            }
            Console.Write("   "); 
            foreach (int obj in myArray)
            {
                Console.Write($" {obj} ");
            }
            Console.WriteLine();
            #endregion

            #region LoopBonus
            //This region prints out a multiplcation table for the numbers 1-5
            int[][] multable = new int[5][];
            Console.WriteLine();
            Console.WriteLine("    Multiplcation Table"); 

            for(int i  = 0; i<5; i++)
            {
                Console.Write("\t    {0}", i+1);
            }
            Console.WriteLine();
            Console.Write("    ");
            for (int i =0; i<9; i++)
            {
                Console.Write("-----");
            }
            Console.WriteLine(); 

            for (int i = 0; i < multable.Length; i++)
            {
                multable[i] = new int[5]; 

                for (int j = 0; j < 5; j++)
                {
                    multable[i][j] = (i+1) * (j+1); 
                }

            }

            int count = 0; 
            foreach(int[] row in multable)
            {
                Console.Write("  {0} |   ", count+1); 
                foreach(int element in row)
                {
                    Console.Write("    {0}\t", element); 
                }
                Console.WriteLine();
                count++; 
            }

            #endregion

            #region Printer TroubleShooter
            //This region diagnoses a printer depending on what types of issues it has.
            //To manage how to diagnoze the pritner, a switch case is used. 
            string condition = ""; 
            Console.WriteLine(); 
            Console.Write("Printer TroubleShooter");

            //First question
            Console.Write("\nIs the printer printing? (Y/N) ");
            string answer1 = Console.ReadLine();
            condition += answer1.ToUpper() == "Y" ? "Y" : "N";

            //Second question
            Console.Write("\nIs there a red light flashing? (Y/N) ");
            string answer2 = Console.ReadLine();
            condition += answer2.ToUpper() == "Y" ? "Y" : "N";

            //Third question
            Console.Write("\nIs the printer recognized by the computer? (Y/N) ");
            string answer3 = Console.ReadLine();
            condition += answer3.ToUpper() == "Y" ? "Y" : "N";

            Console.WriteLine();
            //Writing the switch cases...
            switch (condition)
            {
                case "NYN":
                    Console.WriteLine("Check the printer-computer cable");
                    Console.WriteLine("Ensure printer software is installed");
                    Console.WriteLine("Check/Replace ink");
                    break;
                case "NYY":
                    Console.WriteLine("Check/Replace ink");
                    Console.WriteLine("Check for paper jam"); 
                    break;
                case "NNN":
                    Console.WriteLine("Check the power cable");
                    Console.WriteLine("Check the printer-computer cable");
                    Console.WriteLine("Ensure printer software is installed");
                    break;
                case "NNY":
                    Console.WriteLine("Check for a paper jam");
                    break;
                case "YYN":
                    Console.WriteLine("Ensure printer software is installed");
                    break;
                case "YYY":
                    Console.WriteLine("Check/Replace ink");
                    break;
                case "YNN":
                    Console.WriteLine("Ensure printer software is installed");
                    break;
                case "YNY":
                    Console.WriteLine("No problems detected"); 
                    break;
            }

            #endregion
        }

    }
}
