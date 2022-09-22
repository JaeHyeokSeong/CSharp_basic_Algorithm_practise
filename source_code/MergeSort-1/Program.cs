namespace MergeSort1
{
    /// <summary>
    /// 배열안에 있는 수를 병합정렬 (merge sort)를 사용하여서 오름차순으로 정렬해보자
    /// </summary>
    public class Program
    {
        public static int[] sorted = null;
        public static void Merge(int[] numbers, int left, int mid, int right)
        {
            int i = left, j = mid + 1, k = left;
            while(i<=mid && j <= right)
            {
                if (numbers[i] < numbers[j])
                    sorted[k++] = numbers[i++];
                else
                    sorted[k++] = numbers[j++];
            }

            while (i <= mid)
            {
                sorted[k++] = numbers[i++];
            }
            while (j <= right)
            {
                sorted[k++] = numbers[j++];
            }
            for(int l = left; l <= right; l++)
            {
                numbers[l] = sorted[l];
            }
        }
        public static void MergeSort(int[] numbers, int left, int right)
        {
            if(left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, mid + 1, right);
                Merge(numbers, left, mid, right);
            }
        }
        public static void Main(string[] args)
        {
            // Input
            int[] numbers = { 1, 5, -2, 4, 7, 4 };
            sorted = new int[numbers.Length];
            // Process
            MergeSort(numbers, 0, numbers.Length - 1);
            // Output
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}