
public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
      
      char p1 = '(';
      int p = 0;
      char p2 = ')';
      int pp =0;
      string valid = "";
    
      foreach(var i in input){
        if(p1 == i){
          p++;
        }
        if(p2 == i){
          pp++;
        }
      }
      
     if(input.Length == 0){
       return true;
     }else if(p == pp){
       return true;
     }else if(p != pp){
       return false;
     }
        return false;
    }
}


/*

Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.

Examples
"()"              =>  true
")(()))"          =>  false
"("               =>  false
"(())((()())())"  =>  true
Constraints
0 <= input.length <= 100

*/
