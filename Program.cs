// See https://aka.ms/new-console-template for more information
using System;
namespace logicproject
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine(" What is the number of variable?");
            int row = int.Parse(Console.ReadLine());
            int column = row;
            int[,] array = new int[row, column];
            Console.WriteLine(" What is the number of minterms?");
            int size = int.Parse(Console.ReadLine());
            string[] array2 = new string[size];
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(" enter the minterm number" + (i + 1));
                array2[i] = Console.ReadLine();
            }
            for (int j = 0; j < array2.Length; j++)
            {
                {
                    if (array2[j] == "x`y`") { array[0, 0] = 1; }

                }
                {
                    if (array2[j] == "x`y") { array[0, 1] = 1; }

                }
                {
                    if (array2[j] == "xy`") { array[1, 0] = 1; }

                }
                {
                    if (array2[j] == "xy") { array[1,1] = 1; }

                }
            } 
            if ((array[0,0]==1&& array[1,1]!=1&& array[1,0]!=1&& array[0,1]!=1)|| (array[1, 1] == 1 && array[0,0]!=1&& array[1,0]!=1&& array[0, 1] != 1) || (array[1,0]==1&& array[1,1]!=1&& array[0, 0] != 1 && array[0,1]!=1)|| (array[0,1]==1&& array[1,1]!=1&& array[0,0]!=1&& array[1,0]!=1))
            {
                if (array[1, 1] == 1) Console.WriteLine("The simplification form is: xy");
                if (array[0, 1] == 1) Console.WriteLine("The simplification form is: x`y");
                if (array[1, 0] == 1) Console.WriteLine("The simplification form is: xy`");
                if (array[0, 0] == 1) Console.WriteLine("The simplification form is: x`y`");

            }
            if (array[0,0]==1&& array[0, 1]==1 && array[1, 0] ==1&& array[1, 1] == 1)
            {
                Console.WriteLine(" The simplification form is: 1 ");
            }
            if (array[0, 0] == 1 && array[0, 1] == 1 && array[1, 1] != 1 && array[1, 0] != 1)
                Console.WriteLine(" The simplification form is: x`");
            if (array[0, 0] != 1 && array[0, 1] != 1 && array[1, 1] == 1 && array[1, 0] == 1)
                Console.WriteLine(" The simplification form is: x");
            if (array[0, 0] != 1 && array[0, 1] == 1 && array[1, 1] == 1 && array[1, 0] != 1)
                Console.WriteLine(" The simplification form is:y ");
            if (array[0, 0] == 1 && array[0, 1] != 1 && array[1, 1] != 1 && array[1, 0] == 1)
                Console.WriteLine(" The simplification form is: y`");
            if ( array[0,0]==1&& array[1,1]==1 && array[0,1]!=1&& array[1, 0] != 1) { Console.WriteLine(" The simplification form is; x`y`+xy"); }
            if (array[0, 0] != 1 && array[1, 1] != 1 && array[0, 1] == 1 && array[1, 0] == 1) { Console.WriteLine(" The simplification form is; x`y`+xy"); }
            if ( array[0,0]==1 && array[0,1]==1&& array[ 1,1]==1&& array[1,0] != 1)
            {
                Console.WriteLine(" The simplification form is: x`+y");

            }
            if (array[0, 0] == 1 && array[0, 1] == 1 && array[1, 1] != 1 && array[1, 0] == 1)
            {
                Console.WriteLine(" The simplification form is: x`+y`");

            }
            if (array[0, 0] == 1 && array[0, 1] != 1 && array[1, 1] == 1 && array[1, 0] != 1)
            {
                Console.WriteLine(" The simplification form is: x+y`");

            }
            if (array[0, 0] != 1 && array[0, 1] == 1 && array[1, 1] == 1 && array[1, 0] != 1)
            {
                Console.WriteLine(" The simplification form is: x+y");

            } // end the program of 2 variables x and y 
        }


    }
}
