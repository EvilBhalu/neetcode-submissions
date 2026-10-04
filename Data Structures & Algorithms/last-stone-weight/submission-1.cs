public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int,int>();

        foreach(var v in stones)
        {
            pq.Enqueue(v, -v);
        }     

        while(pq.Count > 1)
        {
            int max1 = pq.Dequeue();
            int max2 = pq.Dequeue();

            if(max1 == max2)
                continue;
            else
            {
                int diff = Math.Abs(max1-max2);
                pq.Enqueue(diff, -diff);
            } 
        }

        return pq.Count == 1 ? pq.Dequeue() : 0;
    }
}
