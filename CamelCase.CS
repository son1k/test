using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        Console.Write(s.Count(char.IsUpper) + 1);
    }
}
