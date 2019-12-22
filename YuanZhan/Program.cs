using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
//_17bang和feige都是必须的

namespace YuanZhan
{


    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();


            string slagon = "大神小班，拎包入住";
            say(slagon);

            Console.WriteLine(slagon);

            //Enum.Parse()

        }

        static void say(string words)
        {
            words += "oh，yeah！";
        }

        [Obsolete("", true)]
        static void getArray(int length)
        {
            //int[] array = new int[length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    //生成随机数填充数组
            //}
            //注释掉真正的代码
            //int[] array = { 7, 3, 5, 9, 2, 6 };
            //return array;
        }

        static void getRandomArray(int length)
        {

        }
    }

    [Obsolete]
    enum Role
    {
        Student = 1,
        TeacherAssist = 2,
        TeamLeader = 4,
        DormitoryHead = 8
    }
}
