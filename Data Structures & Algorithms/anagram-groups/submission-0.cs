public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         List<List<string>> output = new List<List<string>>();
 List<string> addedString = new List<string>();

 for (int i = 0; i < strs.Length; i++)
 {
     if (addedString.Contains(strs[i])) { continue; }
     List<string> childArray = new List<string>();
     childArray.Add(strs[i]);
     for (int j = i + 1; j < strs.Length; j++)
     {
         var curr = strs[i];
         var child = strs[j];
         if (IsAnagram(strs[i], strs[j]))
         {
             childArray.Add(strs[j]);
             addedString.Add(strs[j]);
         }
     }
     output.Add(childArray);
 }
 return output;
    }

    public static bool IsAnagram(string s, string t)
{
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

        if (repeatNumber != keyValuePairs[c])
        {
            result = false;
            break;
        }
    }
    return result;
}
}
