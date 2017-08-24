using System.Threading.Tasks;

namespace TaskDelay
{
    public class TaskDelay
    {
        public void Example()
        {
            Task.Delay(500).GetAwaiter().OnCompleted( () => System.Console.WriteLine("Task A completed") );
        }
    }
}