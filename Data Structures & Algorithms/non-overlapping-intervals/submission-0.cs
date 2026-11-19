public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) 
    {
        Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1]));

        int removed = 0;
        int lastEnd = int.MinValue;

        foreach (var interval in intervals)
        {
            if (interval[0] >= lastEnd)
            {
                lastEnd = interval[1];
            }
            else
            {
                removed++;
            }
        }    

        return removed;
    }
}
