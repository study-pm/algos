using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Teacher_Simulator
{
    public partial class Form_Main : Form
    {
        private Character _character = new Character();
        private Dictionary<Character, Character> _actionMap;
        private Dictionary<Characteristic, string> _propMap;
        private Dictionary<Control, Characteristic> _ctrlMap;
        private string[] _evtList = {
            "Посылка в EduApp'е",
            "Вопрос от ученика",
            "Повышение квалификации",
            "Проверка д/з",
            "Прием экзамена",
            "Прием зачета",
            "Проверка курсовика"
        };
        private Random _random = new Random();
        private (int Index, Timer Timer)[] _events = new (int Index, Timer Timer)[2];
        private Control GetFormatControl(object sender, ConvertEventArgs cevent)
        {
            Binding binding = (sender as Binding);
            if (binding == null) return null;

            return binding.Control;
        }
        private void FormatLabel(object sender, ConvertEventArgs cevent)
        {
            Control ctrl = GetFormatControl(sender, cevent);
            if (ctrl == null) return;

            switch(_ctrlMap[ctrl].Level)
            {
                case Intensity.High:
                    ctrl.ForeColor = Color.Green;
                    break;
                case Intensity.Moderate:
                    ctrl.ForeColor = Color.Blue;
                    break;
                case Intensity.Low:
                    ctrl.ForeColor = Color.DarkOrange;
                    break;
                case Intensity.Critical:
                    ctrl.ForeColor = Color.Red;
                    break;
                default:
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void FormatLabelReversed(object sender, ConvertEventArgs cevent)
        {
            Control ctrl = GetFormatControl(sender, cevent);
            if (ctrl == null) return;

            switch (_ctrlMap[ctrl].Level)
            {
                case Intensity.High:
                    ctrl.ForeColor = Color.Red;
                    break;
                case Intensity.Moderate:
                    ctrl.ForeColor = Color.DarkOrange;
                    break;
                case Intensity.Low:
                    ctrl.ForeColor = Color.Blue;
                    break;
                case Intensity.Critical:
                    ctrl.ForeColor = Color.Green;
                    break;
                default:
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void FormatLabelSpecial(object sender, ConvertEventArgs cevent)
        {
            Control ctrl = GetFormatControl(sender, cevent);
            if (ctrl == null) return;

            int amt = (int)cevent.Value;

            if (amt > 100_000) ctrl.ForeColor = Color.Green;
            else if (amt > 50_000) ctrl.ForeColor = Color.Blue;
            else if (amt > 25_000) ctrl.ForeColor = Color.DarkOrange;
            else ctrl.ForeColor = Color.Red;
        }
        public Form_Main()
        {
            InitializeComponent();

            _propMap = new Dictionary<Characteristic, string>
            {
                { _character.food_pts, "Еда" },
                { _character.health_pts, "Здоровье" },
                { _character.laziness_pts, "Лень" },
                { _character.members_pts, "Оценки участников" },
                { _character.money_pts, "Деньги" },
                { _character.mood_pts, "Настроение" },
                { _character.respect_pts, "Уважение" },
                { _character.sleep_pts, "Сон" },
                { _character.strength_pts, "Сила" },
            };

            _ctrlMap = new Dictionary<Control, Characteristic>()
            {
                { label_foodValue, _character.food_pts },
                { label_gradesValue, _character.members_pts },
                { label_healthValue, _character.health_pts },
                { label_lazinessValue, _character.laziness_pts },
                { label_moneyValue, _character.money_pts },
                { label_moodValue, _character.mood_pts },
                { label_respectValue, _character.respect_pts },
                { label_sleepValue, _character.sleep_pts },
                { label_strengthValue, _character.strength_pts },
            };

            foreach (var item in new[]{
                label_foodValue,
                label_healthValue,
                label_moodValue,
                label_respectValue,
                label_sleepValue,
                label_strengthValue
                })
            {
                Binding binding = new Binding("Text", _ctrlMap[item], "Value", false, DataSourceUpdateMode.OnPropertyChanged);
                binding.Format += new ConvertEventHandler(FormatLabel);
                item.DataBindings.Add(binding);
            }

            foreach (var item in new[] { label_lazinessValue })
            {
                Binding binding = new Binding("Text", _ctrlMap[item], "Value", false, DataSourceUpdateMode.OnPropertyChanged);
                binding.Format += new ConvertEventHandler(FormatLabelReversed);
                item.DataBindings.Add(binding);
            }

            foreach (var item in new[] { label_moneyValue })
            {
                Binding binding = new Binding("Text", _ctrlMap[item], "Value", false, DataSourceUpdateMode.OnPropertyChanged);
                binding.Format += new ConvertEventHandler(FormatLabelSpecial);
                item.DataBindings.Add(binding);
            }

            label_gradesValue.DataBindings.Add("Text", _character.members_pts, "Value", false, DataSourceUpdateMode.OnPropertyChanged);

            RunTimer(0);
            RunTimer(1);
        }
        private void HandleEvent(int i)
        {
            (Characteristic, int)[] pts = Array.Empty<(Characteristic, int)>();
            string evt = "";
            switch (i)
            {
                case 0:
                    pts = new (Characteristic, int)[] {
                        (_character.mood_pts, 16),
                    };
                    evt = "Получена посылка в EduApp'е";
                    break;
                case 1:
                    pts = new (Characteristic, int)[] {
                        (_character.laziness_pts, -16),
                        (_character.money_pts, 128),
                        (_character.respect_pts, 32),
                    };
                    evt = "Отвечен вопрос ученика";
                    break;
                case 2:
                    pts = new (Characteristic, int)[] {
                        (_character.laziness_pts, -32),
                        (_character.members_pts, 128),
                        (_character.respect_pts, 128),
                    };
                    evt = "Пройдено повышение квалификации";
                    break;
                case 3:
                    pts = new (Characteristic, int)[] {
                        (_character.laziness_pts, -16),
                        (_character.money_pts, 512),
                        (_character.respect_pts, 16),
                    };
                    evt = "Проверка д/з";
                    break;
                case 4:
                    pts = new (Characteristic, int)[] {
                        (_character.laziness_pts, -32),
                        (_character.money_pts, 2056),
                        (_character.respect_pts, 64),
                    };
                    evt = "Приём экзамена";
                    break;
                case 5:
                    pts = new (Characteristic, int)[] {
                        (_character.laziness_pts, -32),
                        (_character.money_pts, 1028),
                        (_character.respect_pts, 32),
                    };
                    evt = "Приём зачёта";
                    break;
                case 6:
                    pts = new (Characteristic, int)[] {
                        (_character.laziness_pts, -16),
                        (_character.money_pts, 512),
                        (_character.respect_pts, 16),
                    };
                    evt = "Проверка куросовика";
                    break;
            }
            ChangePropAndPrint(evt, pts);
        }
        private void PrintEvent(string text)
        {
            label_eventValue.Text = text;
        }
        private void ChangeCharacterstics((Characteristic Prop, int Val)[] pts)
        {
            foreach (var item in pts)
            {
                item.Prop.Up(item.Val);
            };
        }
        private void PrintEvt(string evtName, (Characteristic Prop, int Val)[] pts)
        {

            string text = evtName + " -";
            foreach (var item in pts)
            {
                text += " " + _propMap[item.Prop] + "/" + (item.Val > 0 ? "+" : "") + item.Val;
            };
            label_eventValue.Text = text;
        }
        private void ChangePropAndPrint(string evt, (Characteristic, int)[] pts)
        {
            ChangeCharacterstics(pts);
            PrintEvt(evt, pts);
        }
        private void RunEvt(int left, Button button, int i)
        {
            _events[i].Index = _random.Next(0, _evtList.Length);
            Evt evt = new Evt(_evtList[_events[i].Index], left, 19, 341);
            button.Text = evt.Title;
            _events[i].Timer = new Timer();
            _events[i].Timer.Interval = _random.Next(1, 100);
            _events[i].Timer.Tick += Timer_Tick;
            _events[i].Timer.Start();

            void Timer_Tick(object sender, EventArgs e)
            {
                evt.Top++;
                button.Top = evt.Top;
                if (evt.Top >= evt.maxTop)
                {
                    _events[i].Timer.Stop();
                    RunEvt(left, button, i);
                }
            }
        }
        private void RunTimer(int i)
        {
            RunEvt(i == 0 ? 6 : 185, i == 0 ? button_evtLeft : button_evtRight, i);
        }
        private void button_sleep_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.sleep_pts, 32),
                (_character.health_pts, 16),
                (_character.mood_pts, 16),
                (_character.strength_pts, 16),
            };
            ChangePropAndPrint("Сон", pts);
        }

        private void button_watchingMovies_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.mood_pts, 16),
            };
            ChangePropAndPrint("Просмотр фильма", pts);
        }
        private void button_healthyFood_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.food_pts, 32),
                (_character.health_pts, 16),
                (_character.mood_pts, 16),
                (_character.money_pts, -512),
                (_character.respect_pts, 16),
                (_character.strength_pts, 16),
            };
            ChangePropAndPrint("Приём здоровой пищи", pts);
        }
        private void button_regularFood_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.food_pts, 16),
                (_character.health_pts, 8),
                (_character.mood_pts, 8),
                (_character.money_pts, -256),
                (_character.respect_pts, -8),
            };
            ChangePropAndPrint("Приём обычной пищи", pts);
        }
        private void button_casualFood_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.food_pts, 8),
                (_character.health_pts, -8),
                (_character.laziness_pts, 8),
                (_character.money_pts, -128),
                (_character.respect_pts, -8),
            };
            ChangePropAndPrint("Приём фастфуда", pts);
        }
        private void button_meetingWithFriends_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.members_pts, 10),
                (_character.mood_pts, 32),
            };
            ChangePropAndPrint("Встреча с друзьями", pts);
        }
        private void button_goingToGym_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.health_pts, 32),
                (_character.laziness_pts, -16),
                (_character.money_pts, -1028),
                (_character.mood_pts, 16),
                (_character.respect_pts, 32),
                (_character.strength_pts, 32),
            };
            ChangePropAndPrint("Поход в спортзал", pts);
        }
        private void button_courses_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.laziness_pts, -16),
                (_character.money_pts, -512),
                (_character.respect_pts, 128),
                (_character.members_pts, 64),
            };
            ChangePropAndPrint("Занятие на курсах", pts);
        }
        private void button_playingInBand_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.laziness_pts, -8),
                (_character.money_pts, -128),
                (_character.mood_pts, 32),
                (_character.respect_pts, 512),
                (_character.members_pts, 1028),
            };
            ChangePropAndPrint("Игра в группе", pts);
        }
        private void button_knitting_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.laziness_pts, -8),
                (_character.mood_pts, 8),
            };
            ChangePropAndPrint("Вязание", pts);
        }
        private void button_makingGame_Click(object sender, EventArgs e)
        {
            (Characteristic, int)[] pts =
            {
                (_character.laziness_pts, -64),
                (_character.mood_pts, 32),
                (_character.respect_pts, 512),
                (_character.members_pts, 2056),
            };
            ChangePropAndPrint("Создание игры", pts);
        }

        private void button_evtLeft_Click(object sender, EventArgs e)
        {
            _events[0].Timer.Stop();
            HandleEvent(_events[0].Index);
            RunTimer(0);
        }
        private void button_evtRight_Click(object sender, EventArgs e)
        {
            _events[1].Timer.Stop();
            HandleEvent(_events[1].Index);
            RunTimer(1);
        }
    }
}
