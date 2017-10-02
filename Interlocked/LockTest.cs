using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace InterlockedTest
{
    public class LockTest
    {
        private readonly string[] strings1 = new string[] { "aaa", "bbb", "ccc", "ddd", "eee" };
        private readonly string[] strings2 = new string[] { "111", "222", "333", "444", "555" };

        public static int totalCount = 0;

        public void Run()
        {
            Task task1 = Task.Run( () => DoStuff(strings1) );
            Task task2 = Task.Run( () => DoStuff(strings2) );
            Task.WaitAll(task1, task2);
        }

        static void DoStuff(string[] strings) 
        {
            foreach (var str in strings)
            {
                System.Console.WriteLine(str);
                Interlocked.Increment(ref totalCount);
            }
        }
    }
}