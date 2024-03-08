using Microsoft.VisualBasic;

namespace masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
               
            }

            Console.Write(string.Join(" ,", array));

        }
    }
}
