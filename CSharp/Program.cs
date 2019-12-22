using CSharp.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp
{
    class MajorSum
    {
        public string Name { get; set; }
        public int Sum { get; set; }
    }

    class Program
    {

        //public static async Task Getup()
        //{
        //    Console.WriteLine($"before await-1 with thread {Thread.CurrentThread.ManagedThreadId}");
        //    //throw new Exception("");
        //    Console.WriteLine($"before await-2 with thread {Thread.CurrentThread.ManagedThreadId}");
        //    //await 之前的代码，在主线程上运行

        //    //await 开始异步执行，方法从这里开始返回调用者
        //    Task task = Task.Run(() =>
        //    {
        //        Thread.Sleep(50);
        //        Console.WriteLine($"in await with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");
        //    });

        //    //直到await中内容执行完毕，才开始（但不是立即或同步的）执行await之后的代码
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"after task-{i} with thread {Thread.CurrentThread.ManagedThreadId} ");
        //    }

        //    await task;
        //    //task.Wait();
        //    Console.WriteLine($"after await-4 with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");
        //    return;
        //}

        public static async Task<int> Getup()
        {
            int result = await Task<int>.Run(() =>
            {
                Thread.Sleep(30);
                Console.WriteLine($"at await in Getup() with thread {Thread.CurrentThread.ManagedThreadId}");
                return new Random().Next();
            });

            //int result = Task<int>.Run(() =>
            //{
            //    Thread.Sleep(500);
            //    Console.WriteLine($"at await in Getup() with thread {Thread.CurrentThread.ManagedThreadId}");
            //    return new Random().Next();
            //}).Result;

            //方法体内，返回的是int
            return result;

        }

        static void Main(string[] args)
        {
            //Dice.call();

            Parallel.For(0, 10, x => { Console.WriteLine(x); });

            Task.Delay(100);
            //Task<int> task = Task.FromResult(()=>21);

            

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine();

            //    //Parallel.Invoke(
            //    //    () =>
            //    //    {
            //    //        Console.WriteLine(i + $":task-{Task.CurrentId} in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //        Console.WriteLine($"task-{Task.CurrentId} begin in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //        Console.WriteLine($"task-{Task.CurrentId} in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //        Console.WriteLine($"task-{Task.CurrentId} end in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //    },
            //    //    () =>
            //    //    {
            //    //        Console.WriteLine(i + $":task-{Task.CurrentId} in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //        Console.WriteLine($"task-{Task.CurrentId} in begin in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //        Console.WriteLine($"task-{Task.CurrentId} in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //        Console.WriteLine($"task-{Task.CurrentId} in end in thread-{Thread.CurrentThread.ManagedThreadId}");
            //    //    }
            //    //);
            //}




            //GoClass();

            //Getup();
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(33);
            //    Console.WriteLine($"他来了……with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");
            //}





            #region old


            //Func<long> getup = () =>
            //{
            //    Thread.Sleep(100);
            //    Console.WriteLine($"getUp(): TaskId:{Task.CurrentId}, " +
            //        $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");

            //    //long now = DateTime.Now.Ticks;
            //    //Console.WriteLine(now);
            //    //return now;

            //    Console.WriteLine(DateTime.Now.Ticks);
            //    return DateTime.Now.Ticks;
            //};

            ////task是一个线程
            //Task<long> task = Task.Run(getup);
            //Console.WriteLine(task.Result);






            ////Task<TResult>   TResult=>DateTime
            ///

            //Console.WriteLine("in main thread:");
            //Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId} " +
            //    $"Task-{Task.CurrentId}：起床啦！....");
            //try
            //{
            //    Task<DateTime> getup = Task<DateTime>.Run(() =>
            //    {
            //        //for (int i = 0; i < 10; i++)
            //        //{
            //        Thread.Sleep(100);
            //        Console.WriteLine("in task thread:");
            //        Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId} " +
            //            $"Task-{Task.CurrentId}：起床啦！....");
            //        //}
            //        throw new Exception("抓我呀");
            //        return DateTime.Now;
            //    });
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //Task[] getups = new Task[10];
            ////Thread.Sleep(10);

            //for (int i = 0; i < 10; i++)
            //{
            //    //Thread.Sleep(10);
            //    getups[i] = Task.Run(() =>
            //    {
            //        throw new Exception(i.ToString());
            //    });
            //}

            //try
            //{
            //    Task.WaitAll(getups);
            //}
            //catch (AggregateException ae)
            //{
            //    foreach (var item in ae.InnerExceptions)
            //    {
            //        Console.WriteLine(item.Message);
            //    }
            //}


            ////Action<Task<TResult>> continuationAction
            ////x => Task<TResult>
            ////TResult => DateTime
            ////x => Task<DateTime>
            //getup.ContinueWith((x) =>
            //{
            //    Console.WriteLine(DateTime.Now);
            //    Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId} " +
            //        $"Task-{Task.CurrentId}：起床结束");
            //    Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId} " +
            //        $"Task-{Task.CurrentId}：刷牙洗脸....");
            //    Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId} " +
            //        $"Task-{Task.CurrentId}： {x.Result}");
            //});

            #endregion

            Console.ReadLine();
        }

        public static async void GoClass()
        {
            Console.WriteLine("in GoClass()");

            long start = DateTime.Now.Ticks;

            //Task<byte[]> task = File.ReadAllBytesAsync(@"C:\debug.txt");
            //byte[] result = await task;

            int random = await Getup();
            //int random = Getup().Result;
            Thread.Sleep(30);

            Console.WriteLine($"random={random}");

            Console.WriteLine((DateTime.Now.Ticks - start) / TimeSpan.TicksPerMillisecond);

            //int result = await Getup();

            //int result = Getup().Result;

            Console.WriteLine("afeter Getup()");
        }

        //Task
        //public static async /*void*/ Task Getup()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(10);
        //        Console.WriteLine($"before await-{i} with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");

        //    }
        //    //Console.WriteLine($"before await-1 with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");
        //    //Task.Delay(100);
        //    //await 之前的代码，在主线程上运行

        //    //await 开始异步执行，方法从这里开始返回调用者
        //    await /*Task t1 =*/ Task.Run(() =>
        //    {
        //        Thread.Sleep(77);
        //        //throw new Exception("exception in Getup()");

        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"{i}: in await with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");
        //        }
        //    });

        //    //直到await中内容执行完毕，才开始（但不是立即或同步的）执行await之后的代码
        //    Console.WriteLine($"after await-3 with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");
        //    Console.WriteLine($"after await-4 with thread {Thread.CurrentThread.ManagedThreadId} and task {Task.CurrentId}");

        //    //t1.Wait();
        //}

        static void Show(Task task)
        {
            Console.WriteLine("Show():");
            Console.WriteLine($"task-{task.Id}.Start()...." +
                $"status:{task.Status}，" +
                $"task.IsCompleted:{task.IsCompleted}，" +
                $"task.AsyncState:{task.AsyncState}，" +
                $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
