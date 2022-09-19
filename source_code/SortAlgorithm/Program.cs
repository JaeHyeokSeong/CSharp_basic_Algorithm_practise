// Sort Algorithm (정렬 알고리즘) 중에서 Selection Sort (선택 정렬) 를 구현해 봅시다 
using static System.Net.Mime.MediaTypeNames;

namespace SumAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input
            int[] numbers = { 2, -3, 1, 4, 0, 1, 7 };
            // Initialise
            int min;
            // Process
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                min = numbers[i];
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(min > numbers[j])
                    {
                        int temp = min;
                        min = numbers[j];
                        numbers[j] = temp;
                    }
                }
                numbers[i] = min;
                // suspect each process
                Console.Write("[Test{0}] ", i + 1);
                foreach (int number in numbers)
                {
                    Console.Write(number.ToString() + " ");
                }
                Console.WriteLine();
            }
            // Output
            Console.Write("\n[Result]: ");
            foreach(int number in numbers)
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine();
            // Result
            // [Test1] -3 2 1 4 0 1 7
            // [Test2] - 3 0 2 4 1 1 7
            // [Test3] - 3 0 1 4 2 1 7
            // [Test4] - 3 0 1 1 4 2 7
            // [Test5] - 3 0 1 1 2 4 7
            // [Test6] - 3 0 1 1 2 4 7

            // [Result]: -3 0 1 1 2 4 7
        }
    }
}
