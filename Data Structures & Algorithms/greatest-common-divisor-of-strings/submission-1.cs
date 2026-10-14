public class Solution {
    public string GcdOfStrings(string str1, string str2) 
    {
        int len1 = str1.Length, len2 = str2.Length;

        bool IsDivisor(int l)
        {
            if (len1 % l != 0 || len2 % l != 0)
                return false;

            int f1 = len1/l, f2 = len2/l;

            string baseSt = str1.Substring(0,l);

            return new StringBuilder().Insert (0, baseSt, f1).ToString() == str1
            && new StringBuilder().Insert (0, baseSt, f2).ToString() == str2;
        }

        for (int l = Math.Min(len1, len2); l>=1; l--)
        {
            if (IsDivisor(l))
            {
                return str1.Substring(0,l);
            }
        }

        return "";
    }
}