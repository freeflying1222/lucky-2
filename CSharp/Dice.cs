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
            string[] names =
            {
                "彭志强",
                "于维谦",
                //"刘江平",
                "王新",
                //"赵敬春",
                //"杨敬文",
                //"侯涛",
                "陈元",
                "曾俊清",
                "幸龙泰",
            };
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
