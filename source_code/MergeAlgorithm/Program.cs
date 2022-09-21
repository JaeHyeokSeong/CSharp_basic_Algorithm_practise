// Merge Sort Algorithm (병합 정렬) 두개의 배열을 합치는 거
// 목표 : 2개의 정수 배열 합치기. 이때 2 개의의 배열은 오름차순으로 정렬되어 있다고 가정
namespace MergeAlgorithm
{
    /// <summary>
    /// 병합 알고리즘 (Merge Algorithm) : 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input
            int[] first = { 1, 3, 3, 5 , 6, 7};
            int[] second = { 2, 4 , 8, 10};
            int m = first.Length, n = second.Length;
            int[] merge = new int[m + n];
            int i = 0, j = 0, k = 0;
            // Process
            while (k < merge.Length)
            {
                if (first[i] < second[j])
                {
                    merge[k++] = first[i++];
                }
                else if (first[i] > second[j])
                {
                    merge[k++] = second[j++];
                }
                else
                {
                    merge[k++] = first[i++];
                }

                if(i == first.Length)
                {
                    while (j < second.Length)
                    {
                        merge[k++] = second[j++];
                    }
                }
                else if (j == second.Length)
                {
                    while(i < first.Length)
                    {
                        merge[k++] = first[i++];
                    }
                }
            }
            // Ouput
            foreach(int item in merge)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
        }
    }
}