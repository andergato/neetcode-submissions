/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null){
            return root;
        }
        
        TreeNode left = root.right;
        TreeNode right = root.left;

        root.right = InvertTree(right);
        root.left = InvertTree(left);
    
        return root;
    }
}
