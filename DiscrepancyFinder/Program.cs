using System;
using System.Collections.Generic;

/* Program has been designed to find a discrepancy between two number based arrays, by comparing values.
 * It expects the ordering of both data sets to be related, as it will check each value at the same index
 * as the other data input.
 */

namespace DiscrepancyFinder {

    class Program {

        static string[] FindDiscrepancy(int[] arr, int[] arr2)
        {
            // All issues will be saved in this list.
            List<string> locations = new List<string>();

            // Iterating through every array pair.
            for (var i = 0; i < arr.Length; i++)
            {
                // If they're not equal, then we add it to the list as a discrepancy.
                if (arr[i] != arr2[i])
                {
                    locations.Add(i + ": Discrepancy found between values " + arr[i] + " | " + arr2[i]);
                }
            }

            // When list is empty, then no discrepancies have been found.
            if(locations.Count == 0) locations.Add("No discrepancy found.");

            return locations.ToArray();
        }

        static void Main(string[] args) {
            Console.WriteLine("Input data set 1: ");
            string[] arr = Console.ReadLine().Split(' ');
            
            Console.WriteLine("Input data set 2: ");
            string[] arr2 = Console.ReadLine().Split(' ');

            if (arr.Length != arr2.Length)
            {
                Console.WriteLine("Issue with data set sizes. Please input same sized sets.");
                Console.ReadLine();
                return;
            }

            try
            {
                int[] a = Array.ConvertAll(arr, Int32.Parse);
                int[] a2 = Array.ConvertAll(arr2, Int32.Parse);

                foreach (string s in FindDiscrepancy(a, a2))
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading data from dataset. Fix any issues, then try again.");
            }

            Console.ReadLine();
        }

    }
}