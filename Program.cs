using System;

namespace Lab3_Misyuro.Kirill_Arrays
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var mc = new Program();
            Console.WriteLine("--------ARRAYS #0--------");
            mc.OddNumbers();
            Console.WriteLine("--------ARRAYS #1--------");
            mc.NumbersFiveToOne();
            Console.WriteLine("--------ARRAYS #2--------");
            mc.SumOneToNumber();
            Console.WriteLine("--------ARRAYS #3--------");
            mc.FindNumberInArray();
            Console.WriteLine("--------ARRAYS #4--------");
            mc.RandomMinMaxNumber();
            Console.WriteLine("--------ARRAYS #5--------");
            mc.TwoArrays();
            Console.WriteLine("--------ARRAYS #6--------");
            mc.Fibonacci();
            Console.WriteLine("--------ARRAYS #7--------");
            mc.OddToZero();
            Console.WriteLine("--------ARRAYS #8--------");
            mc.SortNames();

        }

        void OddNumbers()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        void NumbersFiveToOne()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        void SumOneToNumber()
        {
            uint input = 0;
            bool isNumber;
            uint sum = 0;
            do
            {
                Console.Write("Enter positive number: ");
                isNumber = uint.TryParse(Console.ReadLine(), out input) && (input != 0);
            }
            while (!isNumber);
            for (uint i = 0; i <= input; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of positive numbers from 1 to {0} is {1}", input, sum);
        }

        void FindNumberInArray()
        {
            int[] arr = new int[10] { 2, 1, 4, 3, 6, 5, 6, 11, 8, 9 };
            Console.Write("Array: ");
            foreach (int i in arr)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            bool isNumber;
            int input;
            do
            {
                Console.Write("Enter the number you are looking for: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);
            }
            while (!isNumber);

            int NumberFound = Array.FindIndex(arr, x=>x==input );
            if (NumberFound > 0)
            {
                Console.WriteLine("Number {0} found in array at index {1}", input, NumberFound);
            }
            else
            {
                Console.WriteLine("Number {0} not found in array", input);
            }

        }

        void RandomMinMaxNumber()
        {
            // 1 2 3 4 5 6 7 8 9 10
            uint input;
            bool isNumber;
            do
            {
                Console.Write("Enter size array: ");
                isNumber = uint.TryParse(Console.ReadLine(), out input) && input != 0;
            }
            while (!isNumber);
            int[] arr = new int[input];
            Random rnd = new Random();
            for (int i = 0; i < input; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            int min = arr[0];
            int max = arr[0];
            float average = 0;
            for (int i = 0; i < input; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
                average += arr[i];
                Console.Write("{0,4}", arr[i]);
            }
            average /= input;
            Console.WriteLine();
            Console.WriteLine("Minimum value in array is {0}", min);
            Console.WriteLine("Maximum value in array is {0}", max);
            Console.WriteLine("Average value in array is {0}", average);

        }

        void TwoArrays()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9, 10 };

            foreach (int i in arr1)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            foreach (int i in arr2)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
        }

        void Fibonacci()
        {
            int a = 0;
            int b = 1;
            Console.Write("{0,4}", a, b);
            for (int i = 2; i <= 11; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.Write("{0,4}", c);
            }
            Console.WriteLine();
        }

        void OddToZero()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in arr)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    arr[i] = 0;
                }
                Console.Write("{0,4}", arr[i]);
            }
            Console.WriteLine();

        }

        void SortNames()
        {
            string[] names = { "Felicity", "Conner", "Layla", "Maddison", "Richie", "Clayton", "Casper", "Samia", "Maxwell", "Jade" };
            Array.Sort(names);
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}