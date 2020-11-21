using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1project
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { -999, - 999, - 999, - 999, - 999, - 999, - 999, - 999, - 999 ,-999 };
            int count = 0;
            int input;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите цифру");
                foreach (int i in a)
                {
                    Console.Write(" " + i + " ");
                }
                Console.WriteLine();
                string temp = Console.ReadLine();
                if (temp == "q") { break; }
                if (temp == "sort")
                {
                    sort(a, count);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    foreach(int i in a)
                    {
                        Console.Write(" " + i +" ");
                    }
                    Console.WriteLine();
                }
                if (temp == "delete")
                {
                    a[count - 1] = -999;
                    count--;
                    continue;
                }
                if (temp == "del")
                {
                    swap2(count, ref a);
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (int i in a)
                    {
                        Console.Write(" " + i + " ");
                    }
                    Console.WriteLine();


                    continue;
                }

                int.TryParse(temp, out input);
                if (count > a.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Массив переполнися");
                }
                else {
                    swap(count, ref a);
                    a[0] = input;
                    count++;
                }
                
               

              
               
            }
        }
        static void swap(int count,ref int [] a)
        {
            for(int i = count;i> 0; i--)
            {
                int temp = a[i];
                a[i] = a[i - 1];
                a[i - 1] = temp;
            }
        }
        static void swap2(int count, ref int[] a)
        {
            for(int i = 0; i < count-1; i++)
            {
                a[i] = a[i+1];
                a[i+1] = -999;
            }
        }
        static int[] sort(int[] a, int count= 0)
        {
            
          
            for (int i = 0; i < count; i++)
            {
             for(int j = 0; j< count; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
         
            return a;
        }
    }
}

