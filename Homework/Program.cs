using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string slagon = "源栈欢迎您！！！";
            Console.WriteLine(slagon.IndexOf("！"));       //10
            Console.WriteLine(slagon.LastIndexOf("！"));   //12


            //Console.WriteLine(slagon.EndsWith("欢迎您！"));   //True

            string[] students = { "王新", "陈元", "彭志强" };
            for (int i = 1; i < students.Length; i++)
            {
                students[0] += students[i];
            }





            ////string result = slagon.Remove(1);
            ////string result = slagon.Remove(1, 1);
            ////string result = slagon.Insert(2, "@");
            //string result = string.Join(",", new List<string> { "a", "b", "c" });
            //Console.WriteLine(result);
            //Console.WriteLine(slagon);

            //string[] splitted = result.Split(',');

            //Console.WriteLine(slagon.Contains('神'));    //true
            //Console.WriteLine(slagon.Contains("神"));    //true
            //Console.WriteLine(slagon.EndsWith("入住"));  //true
            //Console.WriteLine(slagon.IndexOf("神"));     //1
            //Console.WriteLine(slagon.IndexOfAny(new char[] { '小', '中' }));
            //Console.WriteLine(slagon.LastIndexOf('@'));
            //Console.WriteLine(slagon.PadLeft(20));

            //Console.WriteLine(slagon.Replace('大','小'));
            //Console.WriteLine(slagon.Substring(1, 3));

            ////string a = "源栈";
            //////string b = "源栈";
            ////string b = a;
            ////Console.WriteLine(a == b);

            ////实例化一个StringBuilder对象
            //StringBuilder sb = new StringBuilder();
            ////一直往StringBuilder对象上添加（Append）字符串
            //sb.Append("源栈");
            //sb.Append("，");
            //sb.Append("欢迎您！");
            ////sb.Append("源栈").Append("，").Append("欢迎您！");
            ////不要忘了使用ToString()将StringBuilder对象转换成字符串
            ////string slagon = sb.ToString();

            ////Console.WriteLine(slagon);
            ////Console.WriteLine(sb);


            //Console.WriteLine(new Student());


            //string a = string.Empty;

        }

        static void say(string words)
        {
            words = words + "oh，yeah！";
        }
    }

    class Content
    {

    }

    class Problem : Content
    {
        public User Author { get; set; }

    }

    class Comment : Content, IAppraise
    {
        public void Agree(User voter)
        {
            throw new NotImplementedException();
        }

        public void Disagree(User voter)
        {
            throw new NotImplementedException();
        }
    }

    class User
    {

    }

    interface IAppraise
    {
        void Agree(User voter/*, Content content*/);
        void Disagree(User voter);
    }
}
