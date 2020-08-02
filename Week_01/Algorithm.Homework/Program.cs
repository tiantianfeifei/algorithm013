using System;
using System.Linq;

namespace Algorithm.Homework
{
    /// <summary>
    /// 第一周作业
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region --26、删除排序数组中的重复项
            int[] nums = //new int[] { 1, 1, 2 };
                         new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //new int[] { 0, 1, 2, 3, 4, 0, 1, 2, 3, 1 };
            int r = RemoveDuplicates(nums);
            Console.WriteLine("r：" + r);
            #endregion


            #region --189. 旋转数组 
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 5;
            int[] _nums = Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, k);
            #endregion

            Console.ReadKey();
        }

        /*
         * 26. 删除排序数组中的重复项
         * 返回移除后数组的新长度。
         思路：  
             从左到右，两者比较，记不重复的；相邻的不重复，后者替换前者，依次类推 
         问题：
               数组中的元素都是建立在排序之后，所以执行前应先排序。
         */
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }

        /*
         * 189. 旋转数组
         * 思路：
              通过把下标i的值放到下标为(i + k) % nums.Length 新的数组中
        */
        public static int[] Rotate(int[] nums, int k)
        {
            int[] newNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                //Console.WriteLine((i + k) % nums.Length);
                newNums[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = newNums[i];
            }
            return nums;
        }
    }
}
