using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dop_Zadanie
{
    internal class Program
    {
        public static void Array(ref int[] nums)
        {
            Console.WriteLine("Введите нужную сумму");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива");
            for (int i=0; i < nums.Length; i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
            }
            int left=0;
            int right=nums.Length-1;
            while (left != right)
            {
                int sum = nums[left] + nums[right];
                if (sum < k)
                {
                    left++;
                }
                else if (sum > k)
                {
                    right--;
                }
                else
                {
                    Console.WriteLine($"Сумму дают элементы {nums[left]} и {nums[right]}");
                    break;
                }
            }
            

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите количество элементов массива");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            Array(ref nums);
        }
    }
}