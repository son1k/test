using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string h = "hackerrank";
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            int j = 0;
            string s = Console.ReadLine();
            for(int i = 0; i <= s.Length; i++){
                if(i == s.Length){
                    Console.WriteLine("NO");
                    break;
                }
                if(s[i] == h[j]){
                    j++;
                }
                if(j == h.Length){
                    Console.WriteLine("YES");
                    break;
                }
                
            }
        }
    }
}
