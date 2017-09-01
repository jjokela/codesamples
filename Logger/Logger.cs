using System;

namespace Logger
{
    public class LoggerTest
    {
        public LoggerTest()
        {
            /*
            Console.WriteLine("Starting operation Extract");
            Extract();
            Console.WriteLine("End operation Extract");

            Console.WriteLine("Starting operation Transform");
            Transform();
            Console.WriteLine("End operation Transform");

            Console.WriteLine("Starting operation Load");
            Load();
            Console.WriteLine("End operation Load");
            */
            Log(Extract);
            Log(Transform);
            Log(Load);
        }

        private void Log(Action etlMethod)
        {
            //Console.WriteLine($"Start operation {etlMethod.Method.Name}");
            etlMethod.Invoke();
            //Console.WriteLine($"End operation {etlMethod.Method.Name}");

        }

        private void Extract()
        {
            Console.WriteLine("Extract");
        }

        private void Transform()
        {
            Console.WriteLine("Transform");
        }

        private void Load()
        {
            Console.WriteLine("Load");
        }
    }
}