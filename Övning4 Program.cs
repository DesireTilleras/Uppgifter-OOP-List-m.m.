using System;
using System.Collections.Generic;
using System.Linq;

// Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>. 
// Write a program to test whether the method works correctly.
namespace Övning4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.EqualNumbers();
        }

        List<int> EqualNumbers()
        {
            List<int> List = new List<int>() { 2, 2, 2, 5, 6, 6,6,6,6,6,6,6,6, 7, 7,7,7,7,7, 8, 8, 8, 8, 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 };
            

            foreach (var number in List)
            {
                Console.Write(number + " ");
            }

            int counter = 1;
            int counter2 = 0;
            int longestNumber = List[0];


            for (int i = 1; i < List.Count; i++)
            {
                if (List[i] == List[i - 1])
                {
                    counter++;

                    if (counter>counter2)
                    {
                        counter2 = counter;
                        longestNumber = List[i];
                    }
                }
                else
                {

                    counter = 0;
                }
            }

            List<int> NList = new List<int>();
          
            for (int i = 0; i < counter2+1; i++)
            {
                NList.Add(longestNumber);
            }


            Console.WriteLine();
            Console.WriteLine();


            foreach (var number in NList)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

            return NList;
        }
    }
}
