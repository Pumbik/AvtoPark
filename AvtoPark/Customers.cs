using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark
{
    class Customers
    {
        private string _avto;
        private string _custName;
        private string _phone;

        public Customers(string avto, string custName, string phone)
        {
            _avto = avto;
            _custName =custName;
            _phone = phone;
        }

        public string Avto { get {return _avto; } }
        public string CustName { get { return _custName; } }
        public string Phone { get { return _phone; } }

        public override string ToString()
        {
            return String.Format("Клент: {0}, номер телефона: {1}, купил автомобиль: {2}", _custName, _phone, _avto);
        }
    }
}
