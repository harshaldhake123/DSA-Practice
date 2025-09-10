// Last updated: 9/10/2025, 10:22:59 PM
public class Solution
{
    public int ClimbStairs(int n)
    {
        int a = 0;
        int b = 1;
        int c = 1;
        while (n>0)
        {
            c = a + b;
            a = b;
            b = c;
            n--;
        }
        return c;
    }
}