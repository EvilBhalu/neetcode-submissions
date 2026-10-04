public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(var v in nums)
        {
            if(!dict.ContainsKey(v))
                dict.Add(v,1);
            else
                dict[v]++;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var kvp in dict)
        {
            pq.Enqueue(kvp.Key, -kvp.Value);
        }

        int[] arr = new int[k];
        for(int i=0; i<k; i++)
        {
            arr[i] = pq.Dequeue();
        }

        return arr;
    }
}
