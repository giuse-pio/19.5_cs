namespace _19._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in numbers)
            {

                Console.WriteLine(n);

            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                int n = numbers[i];
                if (n % 2 != 0)
                {
                    numbers.Remove(n);
                }
            }

            Console.WriteLine();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
