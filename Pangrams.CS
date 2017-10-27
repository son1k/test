using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        HashSet<char> s = new HashSet<char>(Console.ReadLine().ToLower().Replace(" ", ""));
        Console.WriteLine(s.Count == 26 ? "pangram" : "not pangram");
    }
}
}
