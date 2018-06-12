using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] freq = new int[nums.Length];
            int maxValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > maxValue)
                {
                    maxValue = nums[i];
                }
            }
            int[] freq = new int[maxValue + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                freq
            }
        }

        
    }
}
