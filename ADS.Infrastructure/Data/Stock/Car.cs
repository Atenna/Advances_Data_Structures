using System;

namespace ADS.ADS.Data.Stock
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

        public int Compare(Car x, Car y)
        {
            throw new NotImplementedException();
        }
    }
}
