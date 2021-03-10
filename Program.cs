using System;

namespace SortAlgorthim
{
    class Program
    {
        static void Main(string[] args)
        {
            //var count = Convert.ToInt32(Console.ReadLine());
            var Orginal = new int[] { 81,22,16,8,12,67,88,19,99 };
            var count = Orginal.Length;
            Console.WriteLine(string.Join(' ', Orginal));

            int temp;
            for (int i = 0; i < count -1; i++)
            {
                if(Orginal[i] > Orginal[i+1])
                {
                    temp = Orginal[i];
                    Orginal[i] = Orginal[i + 1];
                    Orginal[i + 1] = temp;
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(' ', Orginal));
        }
    }
}
