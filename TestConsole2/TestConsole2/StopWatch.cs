using System;
namespace TestConsole2
{
    public class StopWatch
    {
        private bool isClockRunning;
        private DateTime startTime;
        private DateTime stopTime;

        public void StartClock()
        {
            if (this.isClockRunning)
                throw new InvalidOperationException("Clock is already running");

            this.startTime = DateTime.Now;
            this.isClockRunning = true;
        }
        public void StopClock()
        {
            if (!this.isClockRunning)
                throw new InvalidOperationException("Clock is not started yet");

            this.stopTime = DateTime.Now;
            this.isClockRunning = false;
        }
        public TimeSpan TickedTime()
        {
            if (this.isClockRunning)
                throw new InvalidOperationException("Clock is running. Stop it before calcuating ticked time");

            return (this.stopTime - this.startTime);

            
        }
    }
}

