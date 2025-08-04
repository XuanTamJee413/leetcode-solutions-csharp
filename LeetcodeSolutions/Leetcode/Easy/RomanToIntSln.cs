using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class RomanToIntSln
    {
        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>()
            {
                { 'I', 1},
                { 'V', 5},
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}
            };
            int number = 0;
            for(int i= 0; i < s.Length; i++)
            {
                if(i < s.Length - 1 && map[s[i]] < map[s[i+1]])
                        number -= map[s[i]];
            else number += map[s[i]];
            }
            return number;
        }
    }
    
}
