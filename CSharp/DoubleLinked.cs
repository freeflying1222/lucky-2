using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //链表的节点
    public class DoubleLinked<T> : IEnumerable<T>
    {
        public DoubleLinked()
        {

        }

        public DoubleLinked(T value)
        {
            Value = value;
        }


        public DoubleLinked<T> Previous { get; set; }
        public DoubleLinked<T> Next { get; set; }
        public T Value { get; set; }

        public bool IsHead
        {
            get
            {
                return Previous == null;
            }
        }

        public bool IsTail
        {
            get
            {
                return Next == null;
            }
        }

        /// <summary>
        /// 根据当前节点向上向下找到指定value的第一个链表节点
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DoubleLinked<T> FindBy(T value)
        {
            //向上找一次
            //向下找一次

            return null;
        }

        /// <summary>
        /// 在node之后插入当前节点
        /// </summary>
        /// <param name="node">在哪一个节点之后插入</param>
        public void InsertAfter(DoubleLinked<T> node)
        {
            if (node.Next == null)
            {
                node.Next = this;
                this.Previous = node;

                this.Next = null;
            }
            else
            {

                this.Next = node.Next;
                this.Previous = node;
                node.Next = this;
                this.Next.Previous = this;
            }
        }

        public void InsertBefore(DoubleLinked<T> old)
        {
            if (old.Previous == null)
            {
                old.Previous = this;
                this.Next = old;
                this.Previous = null;
            }
            else
            {

                this.Previous = old.Previous;
                this.Previous.Next = this;
                old.Previous = this;
                this.Next = old;
            }
        }

        /// <summary>
        /// 删除当前节点
        /// </summary>
        public void Delete()
        {
            if (this.IsHead && this.IsTail)
            {
                throw new Exception("最后一个无法删除掉");
            }

            if (Previous != null)
            {
                Previous.Next = Next;
            }//else nothing
            if (Next != null)
            {
                Next.Previous = Previous;
            }//else nothing

            Previous = null;
            Next = null;
        }

        public void Swap(DoubleLinked<T> a, DoubleLinked<T> b)
        {
            if (a == b)
            {
                //throw 
            }

            //DoubleLinked beforeA = a.Previous;
            DoubleLinked<T> afterA = a.Next;

            DoubleLinked<T> beforeB = b.Previous;
            DoubleLinked<T> afterB = b.Next;

            b.Delete();
            b.InsertAfter(a);

            a.Delete();
            if (beforeB == null)
            {
                a.InsertBefore(afterB);
            }
            else
            {
                if (afterA == b)
                {
                    a.InsertAfter(b);
                }
                else
                {
                    a.InsertAfter(beforeB);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DLEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        class DLEnumerator : IEnumerator<T>
        {
            private DoubleLinked<T> _node;
            private bool _hasEnd;
            public DLEnumerator(DoubleLinked<T> node)
            {
                _node = node;
            }

            public bool MoveNext()
            {
                return !_hasEnd;
            }

            public T Current
            {
                get
                {
                    T value = _node.Value;
                    _hasEnd = _node.Next == null;
                    _node = _node.Next;
                    return value;
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                //throw new NotImplementedException();
            }



            public void Reset()
            {
                //throw new NotImplementedException();
            }
        }
    }



}
