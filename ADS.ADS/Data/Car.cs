using System;

namespace ADS.ADS.Data
{
    class Car : IData
    {
        private string _name;

        public Car(string name)
        {
            this._name = name;
        }

        int IData.Compare(IData dataToCompare)
        {
            throw new NotImplementedException();
        }

        string IData.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
