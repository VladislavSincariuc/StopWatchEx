using System;
using System.Dynamic;

namespace StopWatchEx
{
    using System;

    namespace Exercises1
    {
        class Program
        {
            static void Main(string[] args)
            {
                var stopWatch = new StopWatch();
                Console.WriteLine("Type 1 to Start. n/ Type 0 to Stop.");
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            stopWatch.Start();
                            break;
                        case "0":
                            stopWatch.Stop();
                            Console.WriteLine("Duration was: " + stopWatch.GetInterval().Seconds + "s");
                            break;
                        default:
                            Console.WriteLine("Make sure you Type the correct Key!");
                            Console.WriteLine("Type 1 to Start. n/ Type 0 to Stop.");
                            break;
                    }
                }
            }
        }
    }
}