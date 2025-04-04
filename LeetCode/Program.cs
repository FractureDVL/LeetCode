class Program
{
    public static void Main(string [] args)
    {
        Solution solution = new Solution();
        
        Solution.ListNode l3 = new Solution.ListNode(3 );
        Solution.ListNode l2 = new Solution.ListNode(4, l3);
        Solution.ListNode l1 = new Solution.ListNode(2, l2);
        
        Solution.ListNode l6 = new Solution.ListNode(4 );
        Solution.ListNode l5 = new Solution.ListNode(6, l6);
        Solution.ListNode l4 = new Solution.ListNode(5, l5);

        solution.AddTwoNumbers(l4, l1);
    }
}

class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next = null) {
            this.val = val;
            this.next = next;
            
            
        }
    }

    /*
     * 2. Add Two Numbers
     * https://leetcode.com/problems/add-two-numbers/description/
     */
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) // l1 = [2,4,3], l2 = [5,6,4] == 342 564 
    {
        int a = GetSumListNode(ToString(l1));
        int b = GetSumListNode(ToString(l2));
        int sum = a + b;
        
        string cad = Convert.ToString(sum);
        
        int i = cad.Length - 1;
        
        ListNode next = null;
        while (i > 0)
        {
            if (i == cad.Length - 1)
            {
                next = new ListNode(cad[i] - '0');
            }
            else
            {
                next = new ListNode(cad[i] - '0', next);
            }
        }
        return new ListNode(1, null);
    }
    
    // To get Length of ListNode 
    public string ToString(ListNode list)
    {
        string cad = "";
        while (list != null)
        {
            cad += list.val + "";
            list = list.next;
        }
        return cad; 
    }
    
    // To get inverse value of ListNode [3,0,5] == 503 
    public int GetSumListNode(string cad)
    {
        int result = 0;
        for (int i = 0; i < cad.Length; i++)
        { 
            int mult = Convert.ToInt32(Math.Pow(10, i));
            int sum = (cad[i] - '0' ) * mult;
            result += sum;
        }
        return result;
    }



}