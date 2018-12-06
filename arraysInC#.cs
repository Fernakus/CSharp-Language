using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variable
            byte[] array = new byte[35];

            // Output
            Console.Write("Enter in a low value: ");
            byte low = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter in a high value: ");
            byte high = Convert.ToByte(Console.ReadLine());

            // Populates Array
            PopulateArray(array, high, low);

            // Prints array
            Console.WriteLine();
            Console.WriteLine("Here is the byte array: ");
            PrintArray(array);

            // Sorts and prints sorted array
            Console.WriteLine();
            Console.WriteLine("Here is the sorted byte array: ");
            BubbleSort(array);
            PrintArray(array);

            // Finds max
            Console.WriteLine();
            Console.WriteLine("The max in the byte array is: " + FindMax(array));

            // Finds min
            Console.WriteLine();
            Console.WriteLine("The min in the byte array is: " + FindMin(array));
        }

        // PopulateArray()
        public static byte[] PopulateArray(byte[] array, byte high, byte low)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            { 
                byte random = (byte)rand.Next(low, high);
                array[i] = random;
            }
            return array;
        }

        // FindMax()
        public static byte FindMax(byte[] array)
        {
            byte max = array[0];
            for (int i = 0; i < array.Length; i++) if (array[i] > max) max = array[i];
            return max;
        }

        // FindMin()
        public static byte FindMin(byte[] array)
        {
            byte min = array[0];
            for (int i = 0; i < array.Length; i++) if (array[i] < min) min = array[i];
            return min;
        }

        // PrintArray()
        public static void PrintArray(byte[] array)
        {
            int count = 0;
            Console.Write("[");
            while (count < array.Length - 1)
            {
                Console.Write(array[count] + ", ");
                count++;
            }
            Console.WriteLine(array[array.Length - 1] + "]");
        }

        // BubbleSort()
        public static void BubbleSort(byte[] array)
        {
            byte temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                   if (array[j] > array[j+1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    } 
                }
            }
        }
    }
}