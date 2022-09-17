// 1부터 1000까지의 정수 중 13의 배수의 개수는?
namespace CountAlgorithm
{
    /// <summary>
    /// 개수 알고리즘(Count Algorithm): 주어진 범위에서 주어진 조건에 해당되어지는 자료의 개수를 의미 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input
            int[] numbers = Enumerable.Range(1, 1000).ToArray();
            int count = 0;
            // Process
            foreach(int number in numbers)
            {
                if(number % 13 == 0)
                {
                    // 13 의 배수 이다. 만약 13으로 나누었을때 나머지가 0 이라면
                    count++;
                }
            }
            // Output
            Console.WriteLine("1부터 1000까지의 정수 중 13의 배수의 개수는 -> {0} 개 입니다.", count);
        }
    }
}