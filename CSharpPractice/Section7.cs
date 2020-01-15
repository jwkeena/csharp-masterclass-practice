using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpPractice
{
    // Arrays and lists
    class Section7
    {
        public static void DeclareArray()
        {
            
            // dataType[] arrayName = new dataType[amountOfEntries];
            int[] gradesA = new int[3];

            gradesA[0] = 88;
            gradesA[1] = 67;
            gradesA[2] = 97;

            // another way to declare arrays
            int[] gradesB = { 23, 43, 66, 34, 88, 45 };

            // third way of initializing arrays
            int[] gradesC = new int[] { 75, 46, 89, 77, 88 };

            GetLengthOfArray(gradesA);
            ListContentsOfArray(gradesA);

        }

        public static void GetLengthOfArray(int[] arr)
        {
            Console.WriteLine("This array has " + arr.Length + " elements.");
        }

        public static void ListContentsOfArray(int[] arr)
        {
            int counter = 0;  // Note that this counter only exists to get and print the index, not to make the loop function
            foreach (int i in arr) 
            {
                Console.WriteLine("Element {0} is {1}", counter, i);
                counter++;
            }

            // or one line solution, but without iterator access
            // Array.ForEach(arr, Console.WriteLine);
        }

        public static void CreateArrayOfStrings()
        {
            string[] myLanguages = { "JavaScript", "C#", "CSS", "HTML", "XML", "JSON", "JSX" };

            foreach (string lang in myLanguages)
            {
                Console.WriteLine("I know some " + lang);
            }

        }

        public static void Create2DArray()
        {
            // Declaring 2D array
            string[,] matrix;

            // Initialize 2D array
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // Get info in 2D array
            Console.WriteLine(array2D[1, 1]);

            // There are other ways to create 2D arrays.
        }

        public static void Create3DArray()
        {
            // Declaring 3D array
            string[,,] matrixReloaded;

            // Initialize 3D array
            int[,,] array3D = new int[,,]
            { // depth
                { // length
                    {1, 2}, // height
                    {3, 4}
                },
                {
                    {5, 6},
                    {7, 8}
                }
            };

            // Get info in 3D array
            Console.WriteLine(array3D[1, 0, 1]);

        }

        public static void CreateJaggedArray()
        {
            // A jagged array is an array of arrays such that member arrays can be of different sizes
            // Notice that a 2D array MUST have equal columns and rows.
            // There are differences between jagged arrays and 2D arrays: https://stackoverflow.com/questions/597720/what-are-the-differences-between-a-multidimensional-array-and-an-array-of-arrays

            // Declaring a jaggedArray with 3 inner arrays
            int[][] jaggedArray = new int[3][];

            // Within the overarching array, we declare arrays of different sizes and initialize them later
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[7];
            jaggedArray[2] = new int[3];

            jaggedArray[0][0] = 56; // and so on.

            // Or we can can declare and initialize the arrays simultaneously
            jaggedArray[0] = new int[]{ 3, 4, 6, 7, 8 };
            jaggedArray[1] = new int[]{ 45, 67, 54, 87, 88, 99, 7};
            jaggedArray[2] = new int[]{ 234, 433, 654};

            // Or we can declare and initialize the outer and inner arrays simultaneously
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {3, 5, 76, 4, 542},
                new int[] {1, 2, 3}
            };

            PrintContentsOfJaggedArray(jaggedArray2);
        }

        public static void PrintContentsOfJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i <jaggedArray.Length; i++ )
            {
                Console.WriteLine("Nested array at index" + i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
        }

        public static void PassArrayAsParameter()
        {
            int[] grades = { 43, 64, 76, 86, 99, 100, 77, 86 };

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("The average is " + Average(grades));
        }

        public static double Average(int[] array)
        {
            int sum = 0;
            double average;

            for (int i=0; i < array.Length; i++)
            {
                sum += array[i];
            }

            average = (double)sum/array.Length;
            return average;

        }

        public static void CreateArrayList()
        {
            // Declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();

            // Declaring an ArrayList with a defined amount of objects
            ArrayList myArrayList2 = new ArrayList();

            // ArrayLists are like arrays in javascript (you can add any kind of data to it)
            // .Add is like .push in javascript
            myArrayList2.Add("test");
            myArrayList.Add(24);
            myArrayList.Add(53.55);
            myArrayList.Add(2343.55);
            myArrayList.Add(true);
            myArrayList.Add("You can add any data type");
            myArrayList.Add(myArrayList2);

            // Deletes first matching element
            myArrayList.Remove(24);

            // Delete element at specific position
            myArrayList.RemoveAt(0);

            foreach(object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
