using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark
{
    class Avto
    {
        private string _marka;
        private string _model;
        private int _year;
        private string _color;

        public Avto (string marka, string model, int year, string color)
        {
            _marka = marka;
            _model = model;
            _year = year;
            _color = color;
        }

        public string Marka { get { return _marka; } }
        public string Model { get { return _model; } }
        public int Year { get { return _year; } }
        public string Color { get { return _color; } }

        public override string ToString()
        {
            return String.Format("{0} {1}, год выпуска {2}, цвет {3}", _marka, _model, _year, _color);
        }

    }
}
