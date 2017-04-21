using System;

namespace StopWatchEx
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isStart;

        public void Start()
        {
            if (_isStart)
                throw new InvalidOperationException("You must stop before restart!");
            
          _startTime = DateTime.Now;
          _isStart = true;
          Console.WriteLine("Start...");
            
        }
        public void Stop()
        {
            if (!_isStart)
            
                throw new InvalidOperationException("You must stop before restart!");

          _endTime = DateTime.Now;
          _isStart = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}