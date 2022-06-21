using System;

namespace A8_2_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numGenerator = new Random();
            int[] data = new int[10];

            for (int x = 0; x < data.Length; x++)
            {
                data[x] = numGenerator.Next(0, 50);
            }

            foreach (int x in data)
            {
                Console.Write($"{x}, ");
            }

            Console.WriteLine("\n");
            SortData(data);

            foreach (int x in data)
            {
                Console.Write($"{x}, ");
            }

            Console.ReadLine();
        }

        public static int[] SortData(int[] data)
        {
            for (int x = 0; x < data.Length; x++)
            {
                for(int y = 0; y < data.Length - 1; y++)
                {
                    int yCompare = y + 1;
                    if(data[y] > data[yCompare])
                    {
                        Swap(ref data[y], ref data[yCompare]);
                    }
                }
            }
            return data;
        }

        //Use ref when calling this method to change the actual value
        public static void Swap(ref int value1, ref int value2)
        {
            int tempStorage = value1;
            value1 = value2;
            value2 = tempStorage;
        }
    }
}
