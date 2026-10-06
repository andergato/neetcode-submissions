public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();
        int[] res = new int[2];

        for(int i = 0; i < nums.Length; i++){
            dict[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target-nums[i]) && dict[target-nums[i]] != i){
                res[0] = i;
                res[1] = dict[target-nums[i]];
                break;
            }
        }
        return res;
    }
}
