// n명의 점수 중에서 80점 이상 95점 이하의 점수의 평균을 구하시오
namespace AverageAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input
            int[] scores = { 90, 65, 78, 50, 95 };
            int count = 0;
            double sum = 0;
            // Process
            foreach(int score in scores)
            {
                if(score >= 80 && score <= 95)
                {
                    sum += score;
                    count++;
                }
            }
            // Output
            Console.WriteLine("{0}명의 점수 중에서 80점 이상 95점 이하의 점수의 평균은 {1} 입니다.", scores.Length, sum / count);

            // output
            // 5명 의  점 수  중 에 서  80점  이 상  95점  이 하 의  점 수 의  평 균 은  92.5 입 니 다 .
        }
    }
}