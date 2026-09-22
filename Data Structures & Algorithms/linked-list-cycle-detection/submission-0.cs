/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        var res = new Dictionary<int, ListNode>();
        int i = 0;
        while(head != null){
            if(res.ContainsValue(head)){
                return true;
            }
            res.Add(i, head);
            head = head.next;
            i++;
        }

        return false;
    }
}
