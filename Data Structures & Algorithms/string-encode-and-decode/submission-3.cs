public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();

        foreach(var s in strs)
            sb.Append(s.Length).Append("#").Append(s);

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int len = s.Length;
        int i = 0;

        while(i < len)
        {
            int j = i;

            while(s[j] != '#')
                j++;

            int wLen = int.Parse(s.Substring(i, j-i));
            i = j + 1;
            j = i + wLen;
            result.Add(s.Substring(i, wLen));
            i = j;
        }
        return result;
   }
}
