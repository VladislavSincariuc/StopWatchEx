using System;

namespace StopWatchEx
{
    public class StopWatch
    {
        private DateTime _startTime;
        private bool _isStart;
        private int _timeSpan;
        public void Start()
        {
            if (_isStart)
            {
                Console.WriteLine("You must stop before restart!");
            }
            else
            {
                _startTime = DateTime.Now;
                _isStart = true;
                Console.WriteLine("Start...");
            }
        }
        public void Stop()
        {
            if (_isStart)
            {
                _timeSpan = (int)(DateTime.Now - _startTime).TotalSeconds;
                Console.WriteLine("Time: {0}s.", _timeSpan);
            }
            else
                Console.WriteLine("You must star before stop!");

        }
    }
}