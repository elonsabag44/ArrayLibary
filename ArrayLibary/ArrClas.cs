using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibary
{
    public class ArrClas
    {
        public class MyArrayLibary
        {
            /// <summary>
            /// פעולה מקבלת מערך מספרים שלמים 
            /// פעולה ממלאה מערך בנתונים 
            /// </summary>
            /// <param name="arr"></param>
            public void InputArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter the value for index " + i + ":");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            public void RandomArray(int[] arr, int min, int max)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter the value for index " + i + ":");
                    arr[i] = new Random().Next(min, max + 1);
                }
            }
        }
    }
}
