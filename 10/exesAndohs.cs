
using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string inp)
  {
    int o = 0;
    int x = 0;
    int xo = 0;
    String input = inp.ToLower();
    
    for(int i=0; i<input.Length; i++){
      
      if(input[i] == 'o'){
        
        o++;
      }else if(input[i] == 'x'){
        
        x++;
      }
    }
    
    foreach(char n in input){
      if(!(n !='o' && n !='x')){
        xo++;
      }
    }
    
    if(x == o){
      return true;
    }
    if(xo == 0){
      return true;
    }
    if(x != o){
      return false;
    }
    
    return false;
  }
}


/*

Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false

*/
