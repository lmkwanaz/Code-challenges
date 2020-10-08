

using System;

public class Kata
{
  public static int CountBits(int n)
  {
    //int num = 1234;
		string val = n.ToString();
		int from = 10;
		int to = 2;
    int res;
    int count = 0;

		string binary = Convert.ToString(Convert.ToInt32(val, from), to);
    
    foreach(char i in binary){
      if(i.Equals('1')){
        count++;
      }
    }
    
    return count;

  }
}


/*

Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.

Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

*/
