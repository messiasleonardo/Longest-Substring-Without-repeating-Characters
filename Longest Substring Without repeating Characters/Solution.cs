// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        string text = "";
        char[] characters = s.ToCharArray();
        int count = 0;
        int result = 0;

        for (int i = 0; i < characters.Length; i++)
        {
            if (!text.Contains(characters[i]))
            {
                text += characters[i];
            }
            else
            {
                count = text.Length;
                if (count > result)
                {

                    result = count;
                }

                text = "";
                text += characters[i];
            }


        }

        return result;
    }
}