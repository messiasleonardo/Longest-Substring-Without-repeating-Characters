// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {

        int n = s.Length;

        int res = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (CheckDictionary(s, i, j))
                {
                    res = Math.Max(res, j - i + 1);
                }
            }
        }
        return res;
    }


    private bool CheckDictionary(string s, int start, int end)
    {
        Dictionary<int, char> chars = new Dictionary<int, char>();

        for (int i = start; i <= end; i++)
        {
            char c = s[i];
            chars.Add(i, c);
            if (chars.Where(x => x.Value == c).ToList().Count > 1)
            {
                return false;
            }
        }
        return true;
    }


}