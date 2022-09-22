// 목표 : 주어진 데이터에서 가장 많이 나타난 (중복된) 값을 찾아보자 
namespace ModeAlgorithm
{
    /// <summary>
    /// 최빈값 알고리즘 (Mode Algorithm) -> 점수를 하나의 인덱스로 생각한 후 그 점수가 나오면 그 인덱스의 값을
    /// 증가시켜 준다.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input
            int[] scores = { 1, 3, 4, 2, 1 , 3, 2, 1};
            int[] indexes;
            // Process

            // find the biggest score in the socers array
            int maxIndex = 0;
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[maxIndex] < scores[i])
                {
                    maxIndex = i;
                }
            }

            // set the indexes array size
            indexes = new int[scores[maxIndex] + 1];
            foreach (int score in scores)
            {
                indexes[score]++;
            }

            // find the biggest value in the indexes array
            // and the biggest value is the most duplicated value
            int value = indexes[0], mode = 0;
            bool isMostDuplicatedValue = true;
            for (int i = 1; i < indexes.Length; i++)
            {
                if (value < indexes[i])
                {
                    isMostDuplicatedValue = true;
                    value = indexes[i];
                    mode = i;
                }
                else if(value == indexes[i])
                {
                    isMostDuplicatedValue = false;
                }

            }
            // Output
            if (!isMostDuplicatedValue)
            {
                Console.WriteLine("최빈값이 발견되지 않았습니다");
            }
            else
            {
                Console.WriteLine("최빈값 : {0}, 나타난 횟수 : {1} ", mode, indexes[mode]);
            }
        }
    }
}