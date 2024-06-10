using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Teacher_Simulator
{
    internal class Evt
    {
        private int _left;
        private int _top;
        public int maxTop;
        public string Title { get; set; }
        public int Top {
            get {
                return _top;
            }
            set
            {
                if (value > maxTop) _top = maxTop;
                else _top = value;
            }
        }
        public Evt(string title, int left, int top, int maxTop)
        {
            _left = left;
            _top = top;
            this.maxTop = maxTop;
            Title = title;
        }
    }
}
