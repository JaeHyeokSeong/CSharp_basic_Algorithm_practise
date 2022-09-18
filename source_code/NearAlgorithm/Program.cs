// 근사값 알고리즘, 가까운 값
// 목표 : 원본 데이터 중에서 대상 데이터와 가장 가까운 값을 찾아보자 
namespace NearAlgorithm
{
    /// <summary>
    /// 근사값 알고리즘 (Near Algorithm) : 차잇값의 절댓값의 최솟값 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialise
            int minDifference = 0, nearestData = 0;
            // Input
            int targetData = 13;
            int[] numbers = { 10, 20, 30, 27, 17 };
            // Process
            for(int i = 0; i<numbers.Length; i++)
            {
                int difference = targetData - numbers[i];
                // 만약에 차이가 음수일때 절댓값을 사용해주면 차이값은 양수가 될것이다
                if (difference < 0)
                    difference = -difference;
                if (i == 0)
                {
                    minDifference = difference;
                    nearestData = numbers[i];
                    continue;
                }
                if(minDifference > difference)
                {
                    minDifference = difference;
                    nearestData = numbers[i];
                }
            }
            // Output
            Console.WriteLine("{0} 와 가장 가까운 값 : {1} (차이 : {2}) ", targetData, nearestData, minDifference);
            // Result
            // 13 와  가 장  가 까 운  값  : 10 (차 이  : 3) 
        }
    }
}