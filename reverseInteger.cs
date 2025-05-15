
public class Solution {
    public int Reverse(int x) {
        int reverse = 0;
        int tempNum = x;

        int digit = 0;

        while(tempNum != 0)
        {
           digit = tempNum % 10;
           tempNum/= 10; 

  //Test Case x = 1534236469 Expected = 0
  // Expected zero because of overflow error, try checked to correct and return 0;
           try 
           {
                checked
                {
            reverse = reverse * 10 + digit;
                }
           }
           catch(OverflowException)
           {
                return 0;
           }
        }
        
    return reverse;
    }
}
