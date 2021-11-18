using System;

namespace SecondMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 4, 12, 5, 0, 9, 3 };
            int f_max = int.MinValue;//first max value
            int s_max = int.MinValue;//second max value
            foreach(var i in list)//go through the list
            {
                if (i > f_max)//checking for max value
                {
                    s_max = f_max;
                    f_max = i;
                }
                else if (i > s_max)//checking for second max value
                    s_max = i;
            }
            Console.WriteLine($"second max value: {s_max}" );
        }
    }
}
