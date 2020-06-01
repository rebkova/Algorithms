using System;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            /*binary search function*/
            int[] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
        41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            
            doSearch(primes, 79);
                        
        }

        /*method defined*/
        private static void doSearch(int[] data, int searchItem)
        {
            int min = 0;
            int max = data.Length -1;
            int guess;
            int count = 0;

            while (max >= min)
            {
                guess = (int)(Math.Floor((max + min) / 2.0));
                if (data[guess] == searchItem)
                {
                    Console.WriteLine("Congrats, the number you're looking for is at index " + guess);
                    break;
                }
                
                else if (data[guess] > searchItem)
                {
                    max = guess - 1;
                }

                else
                {
                    min = guess + 1;
                }
                count++;
            }

            while (max < min)
            {
                Console.WriteLine("-1");
                break;
            }
            Console.WriteLine("Count:" + count);
            

        }
    }
}
