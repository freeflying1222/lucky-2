using System;
using System.Collections.Generic;
using System.Text;

namespace YuanZhan
{
    ///用于类，获取时将: 
    ///1. 调用OnlineAttribute的无参构造函数
    ///2. 给OnlineAttribute对象的Version属性赋值
    [Online(Version = 3)]
    public class Student /*: Person*/
    {
        internal int Age;
    }


    //指定只能用于类和方法
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class OnlineAttribute : Attribute
    {
        //可以无参也可以有参
        public OnlineAttribute() { }
        public OnlineAttribute(int version)
        {
            Version = version;
        }

        //还可以使用属性
        public int Version { get; set; }

        public Teacher Teacher { get; set; }
    }

    internal class Teacher
    {
    }
}
