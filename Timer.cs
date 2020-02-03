#pragma warning disable IDE1006
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Timer
{
    //The code for this class has been taken from: https://stackoverflow.com/questions/9228313/most-accurate-timer-in-net.
    /// <summary>Provides a timer controlled by Windows Multimedia API (winmm).</summary>
    public class Timer
    {
        #region Fields
        private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
        private const int TimePeriodic = 1;
        private const int EventType = TimePeriodic;
        [DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int ms);
        [DllImport("winmm.dll")]
        private static extern int timeEndPeriod(int ms);
        [DllImport("winmm.dll")]
        private static extern int timeSetEvent(int delay, int resolution, TimerEventDel handler, IntPtr user, int eventType);
        [DllImport("winmm.dll")]
        private static extern int timeKillEvent(int id);

        private readonly int _delay;
        private readonly Action _action;
        private readonly Form _form;
        private int _timerId;
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private readonly TimerEventDel _handler; //Needs to be here so the Garbage Collector won't collect it.
        #endregion

        #region Methods
        public Timer(Form form, Action action, int delay)
        {
            _delay = delay;
            _action = action;
            _form = form;
            _handler = TimerCallback;
            //timeBeginPeriod(1);
            //_handler = TimerCallback;
            //_timerId = timeSetEvent(delay, 0, _handler, IntPtr.Zero, EventType);
        }

        /// <summary>Stops the timer.</summary>
        public void Stop()
        {
            timeKillEvent(_timerId);
            timeEndPeriod(1);
            Thread.Sleep(100); //Used to ensure callbacks are drained.
        }

        /// <summary>Starts the timer.</summary>
        public void Start()
        {
            timeBeginPeriod(1);
            _timerId = timeSetEvent(_delay, 0, _handler, IntPtr.Zero, EventType);
        }

        /// <summary>Runs the method represented by <see cref="_action"/> every tick.</summary>
        private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2)
        {
            if (_timerId != 0)
                _form.BeginInvoke(_action);
        }
        #endregion
    }
}
