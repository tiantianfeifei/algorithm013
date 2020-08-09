using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Algorithm.Homework
{
    /// <summary>
    /// 两数之和
    /// </summary>
    public class LC_1_Two_Sum
    {

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
