namespace Lab3_Misyuro.Kirill_Arrays
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var mc = new Program();
            Console.WriteLine("--------Arrays #0--------");
            mc.OddNumbers();
            Console.WriteLine("--------Arrays #1--------");
            mc.NumbersFiveToOne();
            Console.WriteLine("--------Arrays #2--------");
            mc.SumOneToNumber();
            Console.WriteLine("--------Arrays #3--------");
            mc.FindNumberInArray();



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
                isNumber = uint.TryParse(Console.ReadLine(), out input);
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
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Enter the number you are looking for: ");
            int.TryParse(Console.ReadLine(), out int input);
            int NumberFound = Array.BinarySearch(arr, input);
            if (NumberFound > 0)
            {
                Console.WriteLine("Number {0} found in array at index {1}",input,NumberFound);
            }
            else
            {
                Console.WriteLine("Number {0} not found in array", input);
            }

        }
    }
}