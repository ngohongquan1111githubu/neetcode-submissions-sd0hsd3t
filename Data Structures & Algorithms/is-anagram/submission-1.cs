public class Solution {
    public bool IsAnagram(string s, string t) {
                   if (s.Length != t.Length) return false;
            var result = true;

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (var i in s)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                }
                else
                {
                    keyValuePairs.Add(i, 1);
                }
            }


            foreach (var c in t)
            {
                int repeatNumber = t.Count(x => x == c);
                
                if (!keyValuePairs.ContainsKey(c))
                {
                    result = false;
                    break;
                }

                if (repeatNumber != keyValuePairs[c]) {
                    result = false;
                    break;
                }
            }

            return result;
    }
}
