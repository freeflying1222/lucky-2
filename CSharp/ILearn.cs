using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //规范/标准
    //访问修饰符
    //约定俗成，命名前缀I
    public interface ILearn<T> : IActivity/*, Student*/
    {
        //接口中的成员不能有访问修饰符
        void Teach();
        int Study(T name);
        int Score { get; set; }
    }

    public interface IActivity
    {

    }

    public abstract class Room
    {
        void hahaha()
        {
            Console.WriteLine("");
        }
        internal abstract void MoveIn();

        public void Teach()
        {
            throw new NotImplementedException();
        }

        public int Study(string name)
        {
            throw new NotImplementedException();
        }
    }

    abstract class BedRoom: Room { }

}
