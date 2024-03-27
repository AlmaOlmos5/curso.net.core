using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Estructuras
{
    struct Coordinate2
    {
        private int _x, _y;

        public event Action<int> CoordinatesChanged;

        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                CoordinatesChanged(this._x);
            }
        }

        public int y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                CoordinatesChanged(this._y);
            }
        }

    }
}
