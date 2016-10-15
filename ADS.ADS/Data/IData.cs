using System;

namespace ADS.ADS.Data
{
    public interface IData<T> :IComparable<T>
    {
        string ToString();
    }
}
