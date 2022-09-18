// 목표 : 주어진 값들 중에서 가장 작은 값을 찾아보자 
namespace MinAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialise
            int min = 0;
            // Input
            int[] numbers = { 2, 5, 3, 7, 1 };
            // binary expression
            // int[] numbers = { 0b_0010, 0b_0101, 0b_0011, 0b_0111, 0b_0001 };
            // process
            for(int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    min = numbers[i];
                    continue;
                }
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            // Output
            Console.WriteLine("최솟값 : {0}", min);
            // Result
            // 최 솟 값  : 1
        }
    }
}