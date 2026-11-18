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
    public bool CanAttendMeetings(List<Interval> intervals) 
    {
        intervals.Sort((x,y) => x.start.CompareTo(y.start));
        for (int i=1; i<intervals.Count; i++)
        {
            var prevEnd = intervals[i-1].end;
            var currStart = intervals[i].start;

            if (currStart < prevEnd)
            {
                return false;
            }
        }
        return true;
    }
}
