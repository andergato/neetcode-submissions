public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> numMap = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            if(numMap.ContainsKey(nums[i])){
                return true;
            }
            numMap.Add(nums[i], i);
        }

        return false;
    }
}