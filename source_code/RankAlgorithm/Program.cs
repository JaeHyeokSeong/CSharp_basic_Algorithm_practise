// 순위 알고리즘 혹은 등수 알고리즘 이라고 불립니다
// 목표 : 주어진 (지정한 범위) 데이터의 순의(등수, ranking)를 구하는 로직입니다
namespace RankAlgorithm
{
    /// <summary>
    /// 순위 알고리즘 (Rank Algorithm) : 점수 데이터에 대한 순위 구해보기
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialise
            int[] rankings = Enumerable.Repeat(1,5).ToArray();
            // Input
            int[] scores = { 90, 67, 100, 95, 80 };
            // Process
            for(int i = 0; i < scores.Length; i++)
            {
                for(int j = 0; j < scores.Length; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        rankings[i]++;
                    }
                }
            }
            // Output
            for(int i = 0; i < rankings.Length; i++)
            {
                Console.WriteLine("Score : {0, 3}, Ranking : {1}", scores[i], rankings[i]);
            }
            // Result
            // Score: 90, Ranking: 3
            // Score: 67, Ranking: 5
            // Score: 100, Ranking: 1
            // Score: 95, Ranking: 2
            // Score: 80, Ranking: 4
        }
    }
}