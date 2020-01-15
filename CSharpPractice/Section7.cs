using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using CSharpPractice.Section7Repository;

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
    }
}
