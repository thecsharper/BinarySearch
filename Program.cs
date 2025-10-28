var tests = new[]
{
            ([-6, 0, 2, 40], 2),
            ([1, 5, 7, 8],   -1),
            ([-10, -5, 3, 4, 7, 9], 3),   // 3 is at index 3
            (new[] {0}, 0)
        };

foreach (var (arr, exp) in tests)
{
    int ans = FixedPointFinder.FindFixedPoint(arr);
    Console.WriteLine($"{ans}  {(ans == exp ? "OK" : "FAIL")} (expected {exp})");
}

public class FixedPointFinder
{
    public static int FindFixedPoint(int[] arr)
    {
        int lo = 0, hi = arr.Length - 1;

        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            int val = arr[mid];

            if (val == mid)
                return mid;                 // found
            else if (val < mid)
                lo = mid + 1;               // need larger index
            else
                hi = mid - 1;               // need smaller index
        }
        return -1;                          // not found
    }
}