public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

 for (int i = 0; i < nums.Length;i++)
 {
     if (keyValuePairs.ContainsKey(nums[i]))
     {
         keyValuePairs[nums[i]]++;
     }
     else {
         keyValuePairs.Add(nums[i],1);
     }
 }

 var result = new int[k];

 for (int i = 0; i < k; i++)
 {
      result[i] = keyValuePairs.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray()[i];
 }

 return result;
    }
}
