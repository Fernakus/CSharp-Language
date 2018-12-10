using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class SortingAlgorithms
    {

        // bubbleSort()
        public static void bubbleSort(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if ((array[j] > array[j + 1]))
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        // insertionSort()
        public static void insertionSort(int[] array)
        {
            int length = array.Length;
            int key, j;

            for (int i = 1; i < length; ++i)
            {
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        // selectionSort()
        public static void selectionSort(int[] array)
        {
            int count = 1;
            for (int j = 0; j < array.Length; j++)
            {
                int maxIndex = 0;
                int maxElement = array[0];

                for (int i = 0; i < array.Length - j; i++)
                {
                    if (array[maxIndex] < array[i])
                    {
                        maxIndex = i;
                        maxElement = array[i];
                    }
                }

                // Swap Here
                int temp = array[array.Length - count];
                array[array.Length - count] = maxElement;
                array[maxIndex] = temp;

                // Increment Count
                count++;
            }
        }

        // quickSort()
        public static void quickSort(int[] array, int start, int end)
        {
            // Base Case
            if (end - start <= 1) return;

            int p = partion(array, start, end);

            quickSort(array, start, p);
            quickSort(array, p + 1, end);
        }

        public static int partion(int[] array, int start, int last)
        {
            swap(array, start, (start + last) / 2);

            int p = start;
            int endS1 = start;
            int unk = start++;

            while (unk < last)
            {
                if (array[p] > array[unk])
                {
                    endS1++;
                    swap(array, endS1, unk);
                }
                unk++;
            }
            swap(array, p, endS1);
            return endS1;
        }

        public static void swap(int[] array, int start, int end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
        }

        // mergeSort()
        public static void mergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                // Sort first and second halves 
                mergeSort(array, left, middle);
                mergeSort(array, middle + 1, right);

                // Merge sorted halves together
                merge(array, left, middle, right);
            }
        }

        public static void merge(int[] array, int left, int middle, int right)
        {
            int i, j, k;
            int index1 = middle - left + 1;
            int index2 = right - middle;

            // Temp Arrays
            int[] Left = new int[index1];
            int[] Right = new int[index2];

            // Copy data to temp arrays
            for (i = 0; i < index1; i++) Left[i] = array[left + i];
            for (j = 0; j < index2; j++) Right[j] = array[middle + 1 + j];

            // Merge the temp arrays back into array[l..r]
            i = 0; // Initial index of first subarray 
            j = 0; // Initial index of second subarray 
            k = left; // Initial index of merged subarray 

            while (i < index1 && j < index2)
            {
                if (Left[i] <= Right[j])
                {
                    array[k] = Left[i];
                    i++;
                }
                else
                {
                    array[k] = Right[j];
                    j++;
                }
                k++;
            }

            // Copy the remaining elements of Left[], if there are any
            while (i < index1)
            {
                array[k] = Left[i];
                i++;
                k++;
            }

            // Copy the remaining elements of Right[], if there are any
            while (j < index2)
            {
                array[k] = Right[j];
                j++;
                k++;
            }
        }
    }
}
