public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> complementMap = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length; i++)
            {
               int complement = target - nums[i];

               if (complementMap.ContainsKey(complement))
               {
                return new int[]{complementMap[complement], i};
               }
               //adds the complement to the original map to search for with each iteration
               complementMap.Add(nums[i],i);
            }

            return new int []{};

  
    }
}
