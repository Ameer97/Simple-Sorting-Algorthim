using System;

namespace SortAlgorthim
{
    class Program
    {
        static void Main(string[] args)
        {
            //var count = Convert.ToInt32(Console.ReadLine());
            var Arr = new int[] { 81,22,16,8,12,67,88,19,99 };
            var count = Arr.Length;
            Console.WriteLine(string.Join(' ', Arr));

            int temp;
            for (int i = 0; i < count -1; i++)
            {
                if(Arr[i] > Arr[i+1])
                {
                    temp = Arr[i];
                    Arr[i] = Arr[i + 1];
                    Arr[i + 1] = temp;
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(' ', Arr));
        }
    }
}
