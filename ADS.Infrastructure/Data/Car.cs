using ADS.ADS.Data;
using System;

namespace ADS.ADS.Data
{
    class Car : IData<Car>
    {
        private string _name;

        public Car(string name)
        {
            this._name = name;
        }

        public int CompareTo(Car other)
        {
            throw new NotImplementedException();
        }
    }
}
