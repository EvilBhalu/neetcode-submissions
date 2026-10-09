public class Solution {

    public string Encode(IList<string> strs) 
    {
        if (strs.Count == 0)
            return "";

        List<int> size = new();
        foreach(string s in strs)
        {
            size.Add(s.Length);
        }

        StringBuilder sb = new();
        foreach(var num in size)
        {
            sb.Append(num).Append(',');
        }
        sb.Append('#');
        foreach(var s in strs)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        if (s.Length == 0)
            return new List<string>();

        List <int> size = new();
        List<string> res = new();

        int i=0;
        while(s[i] != '#')
        {
            int j=i;
            while (s[j] != ',')
            {
                j++;
            }
            size.Add(int.Parse(s.Substring(i,j-i)));
            i = j+1;
        }
        i++;
        foreach(var num in size)
        {
            res.Add(s.Substring(i,num));
            i += num;
        }
        return res;
    }
}
