#pragma warning disable IDE1006 //Disable the "lowerCamelCase" message from VS
using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        #region Fields
        /// <summary>A <see cref="TimeSpan"/> structure that holds remaining time.</summary>
        private TimeSpan _remaining;
        /// <summary>Indicates the state of the start/pause/continue button where <see langword="true"/> stands for "Start" and <see langword="false"/> stands for "Pause".</summary>
        private bool _startElsePause;
        /// <summary>Indicates whether the timer is running.</summary>
        private bool _timerIsRunning;
        /// <summary>A non-resume-able timer.</summary>
        private Timer _timer;
        #endregion

        #region Methods
        public Form1()
        {
            InitializeComponent();
            _startElsePause = true;
            _timerIsRunning = false;
            _remaining = TimeSpan.Zero;
        }

        /// <summary>Checks whether the time set on <see cref="NumericUpDown"/>s is more than zero seconds, and if valid, sets <see cref="_remaining"/> to the specified time and initializes the timer (<see cref="_timer"/>).</summary>
        /// <returns><see langword="true"/> if the validation succeeds, otherwise <see langword="false"/>.</returns>
        private bool AssignTimer()
        {
            //Do all three NumericUpDowns have value greater than zero?
            // ReSharper disable once InvertIf
            if (numericUpDownHour.Value > 0 || numericUpDownMinute.Value > 0 || numericUpDownSecond.Value > 0)
            {
                _remaining =
                    TimeSpan.FromSeconds((double)numericUpDownHour.Value * 3600 + (double)numericUpDownMinute.Value * 60 + (double)numericUpDownSecond.Value);
                _timer = new Timer(this, TimerTick, 100);

                return true;
            }

            return false;
        }

        #region Events
        /// <summary>Resets the UI back to the initial state.</summary>
        private void OnTimerStopped()
        {
            _timerIsRunning = false;
            _remaining = TimeSpan.Zero;
            _startElsePause = true;
            Text = "Countdown Timer";
            labelTimer.Text = "00.00.00.0";
            buttonStop.Enabled = false;
            numericUpDownHour.Enabled = true;
            numericUpDownMinute.Enabled = true;
            numericUpDownSecond.Enabled = true;
            buttonStartPause.Text = "&Start";
        }

        /// <summary>Updates the remaining time and the UI if time remaining, otherwise stops the timer and displays a <see cref="MessageBox"/>.</summary>
        private void TimerTick()
        {
            //Is there time remaining?
            if (_remaining.TotalMilliseconds > 0)
            {
                _remaining = _remaining.Subtract(TimeSpan.FromSeconds(0.1));
                labelTimer.Text =
                    $"{_remaining.Hours:D2}.{_remaining.Minutes:D2}.{_remaining.Seconds:D2}.{_remaining.Milliseconds / 100}";

                //Update only if required to avoid sending redundant messages. (micro-optimization?)
                if (Text != $"{_remaining.Hours:D2}.{_remaining.Minutes:D2}.{_remaining.Seconds:D2}")
                    Text = $"{_remaining.Hours:D2}.{_remaining.Minutes:D2}.{_remaining.Seconds:D2}";
            }
            else
            {
                _timer.Stop();
                OnTimerStopped();
                MessageBox.Show("The time is up!", "Countdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>Runs the timer if paused or not started, or pauses if already started, and updates the UI accordingly.</summary>
        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if (!_timerIsRunning && !AssignTimer()) return;

            if (!buttonStop.Enabled) buttonStop.Enabled = true;
            if (numericUpDownHour.Enabled) numericUpDownHour.Enabled = false;
            if (numericUpDownMinute.Enabled) numericUpDownMinute.Enabled = false;
            if (numericUpDownSecond.Enabled) numericUpDownSecond.Enabled = false;

            if (_startElsePause)
            {
                //_timer = new AccurateTimer(this, TimerTick, 100);
                _timer.Start();
                _timerIsRunning = true;
                buttonStartPause.Text = "&Pause";
            }
            else
            {
                _timer.Stop();
                buttonStartPause.Text = "&Continue";
            }
            _startElsePause = !_startElsePause;
        }

        /// <summary>Stops the timer and resets the UI.</summary>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            OnTimerStopped();
        }

        //The six following NumericUpDown events are used to remove "0" from the boxes automatically when they achieve focus, and put them back if nothing entered.
        private void numericUpDownHour_Enter(object sender, EventArgs e)
        {
            if (numericUpDownHour.Value == 0)
                numericUpDownHour.Text = "";
        }

        private void numericUpDownHour_Leave(object sender, EventArgs e)
        {
            if (numericUpDownHour.Text == "")
                numericUpDownHour.Text = "0";
        }

        private void numericUpDownMinute_Enter(object sender, EventArgs e)
        {
            if (numericUpDownMinute.Value == 0)
                numericUpDownMinute.Text = "";
        }

        private void numericUpDownMinute_Leave(object sender, EventArgs e)
        {
            if (numericUpDownMinute.Text == "")
                numericUpDownMinute.Text = "0";
        }

        private void numericUpDownSecond_Enter(object sender, EventArgs e)
        {
            if (numericUpDownSecond.Value == 0)
                numericUpDownSecond.Text = "";
        }

        private void numericUpDownSecond_Leave(object sender, EventArgs e)
        {
            if (numericUpDownSecond.Text == "")
                numericUpDownSecond.Text = "0";
        }
        #endregion
        #endregion
    }
}
