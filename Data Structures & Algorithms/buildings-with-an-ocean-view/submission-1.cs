public class Solution {
    public int[] FindBuildings(int[] heights) {
        int n = heights.Length;
        var res = new List<int>{n - 1};

        for(int i = n - 2; i >= 0; i--){
            if(heights[i] > heights[res[res.Count - 1]]){
                res.Add(i);
            }
        }
        res.Reverse();
        return res.ToArray();
    }
}