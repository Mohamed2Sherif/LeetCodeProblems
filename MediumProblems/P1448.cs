public class Solution {
    public int GoodNodes(TreeNode root) {
        if(root.left == null && root.right ==null){
            return 1;
        }
        int dfs(TreeNode node,int maxVal){
            int result=0;
            if (node ==null){
                return 0;
            }
            if(node.val >= maxVal){
                 result=1;
            }
             maxVal = Math.Max(maxVal,node.val);
             result += dfs(node.left,maxVal);
             result += dfs(node.right,maxVal);
            return result;
        }
        return dfs(root,root.val);
        
    }
}