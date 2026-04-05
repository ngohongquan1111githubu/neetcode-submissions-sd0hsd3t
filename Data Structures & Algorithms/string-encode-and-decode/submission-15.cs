public class Solution {

    public string Encode(IList<string> strs) {
       if(strs.Count() < 1) return null;
       string output = string.Empty;
       for(int i = 0; i < strs.Count(); i ++){
            if(i == strs.Count() - 1){
                output += strs[i];
            }else{
                output += strs[i] + "(VeryComplexString)";
            }
       }
        return output;
    }

    public List<string> Decode(string s) {
        return s == null? new List<String>() : s.Split("(VeryComplexString)").ToList();
   }
}
