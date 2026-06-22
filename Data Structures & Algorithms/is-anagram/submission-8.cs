public class Solution {
   public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var m1 = new Dictionary<char, int>();
        var m2 = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            char cs = s[i];
            char ct = t[i];

            if(!m1.ContainsKey(cs))
                m1[cs] = 0;

            m1[cs]++;
            
            if(!m2.ContainsKey(ct))
                m2[ct] = 0;

            m2[ct]++;
        }

        foreach(var c in m1)
            if(!m2.TryGetValue(c.Key, out var _) || m2[c.Key] != m1[c.Key])
                return false;
        return true;
    }
}
