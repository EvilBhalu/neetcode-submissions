public class Solution {
    public int[][] Merge(int[][] intervals) 
    {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        List<int[]> result = new ();
        
        foreach (var cur in intervals)
        {
            if (result.Count == 0 || result[^1][1] < cur[0])
                result.Add(cur);    // no overlap
            else
                result [^1][1] = Math.Max (result[^1][1], cur [1]); //overlap
        }

        return result.ToArray();
    }
}
