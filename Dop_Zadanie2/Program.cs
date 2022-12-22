using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dop_Zadanie2
{
    internal class Program
    {
        public static void Array(ref int[] temp, ref int[] day, ref int cnt)
        {
            int k = temp[cnt];
            int a = cnt;
            for (int i = a + 1; i < temp.Length; i++)
            {
                if (temp[i] > k)
                {
                    day[cnt] = i - a;
                    break;
                }
            }
            cnt++;

        }
        public static int[] QuickDay(ref int[] temp, ref int[] day, ref int cnt)
        {
            if (cnt == temp.Length)
            {
                return day;
            }
            Array(ref temp, ref day, ref cnt);
            QuickDay(ref temp, ref day, ref cnt);

            return day;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число дней");
            int n = int.Parse(Console.ReadLine());
            int[] temp = new int[n];
            Console.WriteLine("Введите температуру");
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = int.Parse(Console.ReadLine());
            }
            int[] day = new int[temp.Length];
            int cnt = 0;
            QuickDay(ref temp, ref day, ref cnt);
            foreach (var i in day)
            {
                Console.WriteLine(i);
            }
        }
    }
}