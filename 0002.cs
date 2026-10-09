public static class Solution0002 {

    // Definition for singly-linked list.
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;
    }

    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2) {

        // iterate all nodes
        var carry = 0;
        var output = new List<ListNode>();
        do {
            var v1 = l1?.val ?? 0;
            var v2 = l2?.val ?? 0;
            // sum (with carry)
            var sum = v1 + v2 + carry;
            //var v3 = sum > 9 ? sum - 10 : sum;
            carry = sum > 9 ? 1 : 0;
            // create new node and push onto queue
            AppendNode(output, sum % 10);
           // advance to next nodes
            l1 = l1?.next;
            l2 = l2?.next;
        } while (l1 != null || l2 != null);
        if(carry > 0)
        {            
            AppendNode(output, carry);
        }   
        return output.FirstOrDefault();
    }

    private static void AppendNode(List<ListNode> list, int value) {
        var node = new ListNode(value, null);
        if(list.Count > 0)
        {
            list.Last().next = node;
        }
        list.Add(node);
    }
}
