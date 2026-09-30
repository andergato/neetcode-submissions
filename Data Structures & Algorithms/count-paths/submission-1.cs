public class Solution {
    int[,] memo;
    public int UniquePaths(int m, int n) {
        memo = new int[m+1,n+1];
        for(int i = 0; i <= m; i++){
            for(int j = 0; j <= n; j++){
                memo[i,j] = 0;
            }
        }
        memo[m-1,n-1] = 1;
        for(int i = m - 1; i >= 0; i--){
            for(int j = n - 1; j >= 0; j--){
                if(memo[i,j] != 0){
                    continue;
                }
                memo[i,j] = memo[i+1,j] + memo[i,j+1];
            }
        }
        return memo[0,0];
    }

    // int dfs(int i, int j, int m, int n){
    //     if(i == (m - 1) && j == (n - 1)){
    //         return 1;
    //     }
    //     if(i > m - 1 || j > n - 1){
    //         return 0;
    //     }
    //     if(memo[i,j] != -1){
    //         return memo[i,j];
    //     }
    //     else{
    //         memo[i,j] = dfs(i,j+1,m,n) + dfs(i+1,j,m,n);
    //         return memo[i,j];
    //     }
    // }
}
