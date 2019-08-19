using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp
{
    public class Dice
    {
        internal static void call()
        {
            string[] names = { "彭志强", "于维谦", "王枫", "王一格", "薛明林", "杨庆龙", "冉雪珂", "刘子祥","幸龙泰", "陈元" };
            int random = new Random().Next(names.Length);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "...");
                Thread.Sleep(200);
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"恭喜：O(∩_∩)O~");
            Console.WriteLine("---------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(names[random]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
            Console.WriteLine($"同学！");
        }
    }
}
