// Search Algorithm (binary search)
using System.Security.Cryptography;

namespace SearchAlgorithm
{
    /// <summary>
    /// Search Algorithm (Binary Algorithm) : 주어진 테이터에서 특정 데이터 찾기
    /// 오름차순으로 정렬되어져 있는 데이터를 이진 탐색을 통하여서 원하는 테이터를 찾아 보기
    /// (이때 내림차순도 가능한데 그렇게 할려면 반대로 설정해주면 된다)
    /// </summary>
    public class Program
    {
        public static int BinarySearch(int[] datas, int find)
        {
            int start = 0, end = datas.Length - 1, mid = (start + end) / 2, times = 0;
            while (start <= end)
            {
                Console.WriteLine("[Times : {0}]", ++times);
                if (datas[mid] == find)
                {
                    return mid;
                }
                else if (datas[mid] > find)
                {
                    end = mid - 1;
                }
                else if (datas[mid] < find)
                {
                    start = mid + 1;
                }
                mid = (start + end) / 2;
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            // Initialise
            int find = 92;
            // Input
            int[] datas = { 17, 28, 43, 67, 88, 92, 100 };
            // Process
            int index = BinarySearch(datas, find);
            // Ouput
            if (index != -1)
            {
                Console.WriteLine("{0} has found at index {1}", find, index);
            }
            else
            {
                Console.WriteLine("{0} has not found", find);
            }
        }
    }
}