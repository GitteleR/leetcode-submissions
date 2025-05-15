public class Solution 
{
    public bool IsPalindrome(int x) 
{
        int reverse = 0;
        int tempNum = x;

        int digit = 0;

        while(tempNum != 0)
        {
           digit = tempNum % 10;
           tempNum/= 10; 
           try 
           {
                checked
                {
            reverse = reverse * 10 + digit;
                }
           }
           catch(OverflowException)
           {
                return false;
           }
        }
    
        if (reverse == x && reverse > 0 || x == 0)
        {
            return true;
        }
        else
        return false;
    }
}
