namespace SumAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //[1] Input n명의 국어 점수
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int sum = 0;
            //[2] Process: 합계 알고리즘 영역이다
            foreach(int score in scores)
            {
                if(score >= 80)
                {
                    sum += score;
                }
            }
            //[3] Output
            Console.WriteLine("{0} 명의 점수 중 80점 이상의 총점: {1}", scores.Length, sum);
        }
    }
}