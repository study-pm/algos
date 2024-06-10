using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Teacher_Simulator
{
    enum Intensity
    {
        High,
        Moderate,
        Low,
        Critical,
    }
    internal class Characteristic : INotifyPropertyChanged
    {
        private int _value;
        private int _min;
        private int _max;
        private int _step;
        private int _tick;
        private System.Windows.Forms.Timer _timer;
        private Intensity _level;
        public Intensity Level
        {
            get
            {
                return _level;
            }
        }
        public int Value
        {
            get {
                return _value;
            }
            set
            {
                if (value < _min) _value = _min;
                else if (value > _max) _value = _max;
                else _value = value;
                SetIntensity();
                OnPropertyChanged();
            }
        }
        internal Characteristic()
        {
            _min = 0;
            _max = 100;
            _step = 10;
            _tick = -1;
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            Value = _max;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        internal Characteristic(bool noTimer)
        {
            _min = 0;
            _max = int.MaxValue;
            _step = 1;
            Value = _min;
        }
        internal Characteristic(int min, int max) : this()
        {
            _min = min;
            _max = max;
            Value = _max;
        }
        internal Characteristic(int min, int max, int val) : this(min, max)
        {
            Value = val;
        }
        internal Characteristic(int min, int max, int val, int interval) : this(min, max, val)
        {
            _timer.Interval = interval;
        }
        internal Characteristic(int min, int max, int val, int interval, int step) : this(min, max, val, interval)
        {
            _step = step;
        }
        internal Characteristic(int min, int max, int val, int interval, int step, int tick) : this(min, max, val, interval, step)
        {
            _tick = tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Value += _tick;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public void SetIntensity()
        {
            if (Value > 0.75 * _max) _level = Intensity.High;
            else if (Value > 0.5 * _max) _level = Intensity.Moderate;
            else if (Value > 0.25 * _max) _level = Intensity.Low;
            else _level = Intensity.Critical;
        }
        public void Up()
        {
            Value += _step;
        }
        public void Up(int step)
        {
            Value += step;
        }
    }
    internal class Character
    {
        public Characteristic food_pts = new Characteristic(0, 100, 100, 1000, 10);
        public Characteristic health_pts = new Characteristic(0, 100, 100, 10000, 10);
        public Characteristic laziness_pts = new Characteristic(0, 100, 0, 1000, 10, 1);
        public Characteristic members_pts = new Characteristic(true);
        public Characteristic money_pts = new Characteristic(0, int.MaxValue, 60_000, 100_000, 1000, 10_000);
        public Characteristic mood_pts = new Characteristic(0, 100, 100, 500, 10);
        public Characteristic respect_pts = new Characteristic(0, 1_000, 750);
        public Characteristic sleep_pts = new Characteristic(0, 100, 100, 5000, 10);
        public Characteristic strength_pts = new Characteristic(0, 100, 100, 750, 10);
    }
}
