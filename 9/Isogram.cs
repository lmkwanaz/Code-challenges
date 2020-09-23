using System;

public class Kata
{
  public static bool IsIsogram(string s) 
  {
    string str = s.ToLower();
    string check = "";
    for(int i = 0; i< str.Length; i++){
      
      for(int n = i +1; n<str.Length; n++){
        
        if(str[i] == str[n]){
          
          check += str[i];
        }
      }
    }
    
    if(check.Length <= 0){
      return true;
    }else{
      return false;
    }
  }
}



/*

An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

isIsogram "Dermatoglyphics" == true
isIsogram "aba" == false
isIsogram "moOse" == false -- ignore letter case

*/
