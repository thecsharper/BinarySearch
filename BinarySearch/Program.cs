var tests = new[]
 {
            [1, 3, 5, 8, 6, 4, 2],     // peak = 8
            [1, 2, 7, 9, 5, 3],        // peak = 9
            [10, 20, 15, 14, 13],      // peak = 20
            [5, 10, 20, 15],           // peak = 20
            new[] {1, 100, 2},         // peak = 100
        };

foreach (var arr in tests)
{
    int peak = PeakFinder.FindPeak(arr);
    Console.WriteLine($"Array: [{string.Join(",", arr)}]");
    Console.WriteLine($"Peak: {peak}");
    Console.WriteLine();
}

public class PeakFinder
{
    public static int FindPeak(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // Compare with right neighbor
            if (arr[mid] > arr[mid + 1])
            {
                // Peak is in left half (including mid)
                right = mid;
            }
            else
            {
                // Peak is in right half
                left = mid + 1;
            }
        }

        return arr[left]; // or just return left (index)
    }
}