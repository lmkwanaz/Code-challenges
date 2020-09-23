using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    
    
    if(name.Length == 0){
      return "no one likes this";
      
    }else if(name.Length == 1){
      return name[0] +" likes this";
      
    }else if(name.Length == 2){
      
      return name[0]+" and "+name[1]+" like this";
    }else if(name.Length == 3){
      
      return name[0]+", "+name[1]+" and "+name[2]+" like this";
      
    }else{
      if(name.Length > 3){
        
        int len = name.Length - 2;
        
        return name[0]+", "+name[1]+" and "+ len+" others like this";
      }
    }
    
    return "";
  }
}

/* You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. It must return the display text as shown in the examples: */	

/*

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"

*/
