/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) 
    {
        List<int> starts = new ();
        List<int> ends = new();
        foreach (var i in intervals)
        {
            starts.Add(i.start);
            ends.Add(i.end);
        }

        starts.Sort();
        ends.Sort();
        
        int result = 0, e = 0;

        for(int s=0; s<starts.Count; s++)
        {
            if (starts[s] >= ends[e])
            {
                e++;
            }
            else
            {
                result++;
            }
        }

        return result;
    }
}
