using SharpLib.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLib
{
    public class Timer : IDisposable
    {
        public Timer()
        {
            state = TimerState.TS_STOPPED;
            clockTicks = 0;
        }

        public Timer(long _clockTicks)
        {
            state = TimerState.TS_STOPPED;
            clockTicks = _clockTicks;
        }

        public void Dispose() 
        {
            this.Clear();
        }

        public static Timer operator +(Timer t1, Timer t2)
        {
            AssertAssistant.Assert(t1 != null);
            AssertAssistant.Assert(t2 != null);
            AssertAssistant.Assert(t1.state == TimerState.TS_STOPPED);
            AssertAssistant.Assert(t2.state == TimerState.TS_STOPPED);

            return new Timer(t1.clockTicks + t2.clockTicks);
        }

        public static Timer operator -(Timer t1, Timer t2)
        {
            AssertAssistant.Assert(t1 != null);
            AssertAssistant.Assert(t2 != null);
            AssertAssistant.Assert(t1.state == TimerState.TS_STOPPED);
            AssertAssistant.Assert(t2.state == TimerState.TS_STOPPED);

            return new Timer(t1.clockTicks - t2.clockTicks);
        }

        public void Start()
        {
            AssertAssistant.Assert(state == TimerState.TS_STOPPED);
            state = TimerState.TS_STARTED;
            start = DateTime.Now.Ticks;
        }

        public void Stop()
        {
            AssertAssistant.Assert(state == TimerState.TS_STARTED);
            clockTicks += DateTime.Now.Ticks - start;
            state = TimerState.TS_STOPPED;
        }

        public void Clear()
        {
            clockTicks = 0;
        }

        public double ClockTicks()
        {
            AssertAssistant.Assert(state == TimerState.TS_STOPPED);
            return clockTicks;
        }

        public double Milliseconds()
        {
            throw new NotImplementedException("Milliseconds not Implemented!");
        }

        private enum TimerState
        {
            TS_STARTED,
            TS_STOPPED
        };

        TimerState state;

        private long start;
        private long clockTicks;
    }

    public class TimerReport : IDisposable
    {
        public TimerReport() { }

        public void Dispose()
        {

        }
    }
}
