// 목표 : 주어진 데이터 중에서 가장 큰 값을 찾아보
namespace MaxAlgorithm
{
    /// <summary>
    /// Max Algorithm 은 (주어진 범위 + 주어진 조건) 에서 가장 큰 값을 찾는 것이다 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialise
            int max = 0;
            // Input
            int[] numbers = { -2, -5, 2, 10, -1 };
            // Process
            for(int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    max = numbers[i];
                    continue;
                }
                if(max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            // Output
            Console.WriteLine("최댓값 : {0}", max);

            // Result
            // 최 댓 값  : 10
        }
    }
}