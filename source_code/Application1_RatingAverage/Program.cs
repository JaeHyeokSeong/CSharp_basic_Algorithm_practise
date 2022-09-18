// 제품에 대한 별점 중에서 최솟값 최댓값을 뺀 별점들의 평균값을 구하는 프로그램
namespace Application1_RatingAverage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialise
            int max = 0, min = 0;
            double sum = 0.0;
            // Input
            int[] ratings = { 2, 1, 4, 3, 5 };
            // Process
            for(int i = 0; i < ratings.Length; i++)
            {
                if(i == 0)
                {
                    max = ratings[i];
                    min = ratings[i];
                    continue;
                }
                if(max < ratings[i])
                {
                    max = ratings[i];
                }
                if(min > ratings[i])
                {
                    min = ratings[i];
                }
            }

            foreach(int rating in ratings)
            {
                sum += rating;
            }
            sum -= (max + min);
            // Output
            Console.WriteLine("Max : {0}, Min : {1}", max, min);
            Console.WriteLine("Average ratings : {0}", sum / (ratings.Length - 2));

            // Result
            // Max : 5, Min : 1
            // Average ratings : 3
        }
    }
}