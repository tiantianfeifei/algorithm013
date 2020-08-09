using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Algorithm.Homework
{
    /// <summary>
    /// 242. 有效的字母异位词
    /// </summary>
    public class LC_242_Valid_Anagram
    {

        /*
        1.将2个字段串转换为字符数组并排序。
        2.比较2个字符数组的大小。
        */
        public bool isAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            s.Equals(t);

            char[] s1 = s.ToCharArray();
            char[] s2 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);
            return Enumerable.SequenceEqual(s1, s2);
        }


        /*
         用字典的方式处理
        */
        private bool isAnagram2(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                    dict.Add(s[i], 1);
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                {
                    if (dict[t[i]] != 1)
                    {
                        dict[t[i]]--;
                    }
                    else
                        dict.Remove(t[i]);
                }
                else
                    return false;
            }
            return true;
        }
    }
}
