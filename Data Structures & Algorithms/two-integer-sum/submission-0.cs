public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numDict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            numDict[nums[i]] = i;
        }
        for(int i = 0; i < nums.Length; i++){
            int compliment = target - nums[i];
            if(numDict.ContainsKey(compliment) && numDict[compliment] != i){
                return new int[]{i, numDict[compliment]};
            }
        }
        return new int[0];
    }
}
