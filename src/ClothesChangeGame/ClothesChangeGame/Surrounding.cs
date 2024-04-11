using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesChangeGame
{
    internal class Surrounding
    {
        private bool _hasCloudsOn = true;
        public bool HasCloudsOn {
            get => _hasCloudsOn;
            set
            {
                _hasCloudsOn = value;
                if (value == true) _hasTableOn = false;
            }
        }
        private bool _hasTableOn = false;
        public bool HasTableOn
        {
            get => _hasTableOn;
            set
            {
                _hasTableOn = value;
                if (value == true) _hasCloudsOn = false;
            }
        }
    }
}
