

using System.Collections.Generic;

public class SplitString
{
  public static string[] Solution(string str)
  {
    List<char> list = new List<char>();
    List<char> list1 = new List<char>();
    List<string> list2 = new List<string>();
    string[] strArray;
    char character = '_';
    
    if(str.Length % 2 == 0){
      for(var i = 0; i<str.Length; i++){
                list.Add(str[i]);
			          i++;
                list1.Add(str[i]);
			}
      
      string merge = null;
            
            for(int i=0; i<list.Count; i++){
                for(int n=i; n<list1.Count; n++){
                    merge += list[i];
                    merge+= list1[n];
                    
                    for(int m=0; m<list1.Count; m++){                      
                        list2.Add(merge);
                        merge = null;
                        break;
                    }
                    break;
                }
            }
           
           return strArray = list2.ToArray();
      
    }else{
      
              str += character;
                
                 for(var i = 0; i<str.Length; i++){
                list.Add(str[i]);
			          i++;
                list1.Add(str[i]);
              }
                
                string see = null;
            
                for(int i=0; i<list.Count; i++){
                    for(int n=i; n<list1.Count; n++){
                        see += list[i];
                        see+= list1[n];

                        for(int m=0; m<list1.Count; m++){                      
                            list2.Add(see);
                            see = null;
                            break;
                        }
                        break;
                    }
                }
                
                    return strArray = list2.ToArray();
               
      
    }
    return null;
  }
}


/*
Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').


SplitString.Solution("abc"); // should return ["ab", "c_"]
SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]

*/

/*
##### BEST PRACTICE

if (str.Length % 2 == 1)
    str += "_";
  
    List<string> list = new List<string>();
    for (int i = 0; i < str.Length; i += 2)
    {
      list.Add(str[i].ToString() + str[i+1]);
    }
    
    return list.ToArray(); 

*/
