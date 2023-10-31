using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

                runApp();
            }

            static void runApp()
            {
                int[] array = { 11, 21, 31, 41, 51, 61, 71, 81, 91, 101 };

                Console.Write("Enter the value to search: ");
                if (int.TryParse(Console.ReadLine(), out int targetValue))
                {
                    int index = BinarySearch(array, targetValue);

                    if (index != -1)
                    {
                        Console.WriteLine($"Element {targetValue} found at index {index}");
                    Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Element {targetValue} not found in the array");
                    Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            static int BinarySearch(int[] arr, int target)
            {
                int left = 0;
                int right = arr.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (arr[mid] == target)
                    {
                        return mid; // Element found, return its index
                    }

                    if (arr[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return -1; // Element not found
            }
        }
    }
 
