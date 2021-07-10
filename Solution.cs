using System;
using System.Collections.Generic;
using System.Linq;

namespace PositioningAppleOranges
{
    class House
    {
        public int s { get; set; }
        public int t { get; set; }
        public House(int s, int t)
        {
            this.s = s;
            this.t = t;
        }
        public bool isInsideTheHouse(int x)
        {
            return ((x >= s) && (x <= t));
        }
    }

    class Result
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            House house = new House(s, t);
            int appleCount = 0;
            foreach (int appleDistance in apples)
            {
                if (house.isInsideTheHouse(a + appleDistance))
                {
                    ++appleCount;
                }
            }
            Console.WriteLine(appleCount);
            int orangeCount = 0;
            foreach (int orangeDistance in oranges)
            {
                if (house.isInsideTheHouse(b + orangeDistance))
                {
                    ++orangeCount;
                }
            }
            Console.WriteLine(orangeCount);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            Result.countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
