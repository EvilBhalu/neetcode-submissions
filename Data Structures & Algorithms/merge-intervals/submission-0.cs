public class Solution {
    public int[][] Merge(int[][] intervals) 
    {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        List<int[]> result = new ();
        result.Add (intervals[0]);

        foreach (int[] i in intervals)
        {
            int start = i[0];
            int end = i[1];
            int lastEnd = result[result.Count - 1][1];

            if (start <= lastEnd)
            {
                result [result.Count - 1][1] = Math.Max (lastEnd, end);
            }
            else
            {
                result.Add (new int[] {start, end});
            }
        }

        return result.ToArray();
    }
}
