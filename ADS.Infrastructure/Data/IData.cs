using System;
using System.Collections;
using System.Collections.Generic;

namespace ADS.ADS.Data
{
    public interface IData<T> : IComparer<T>
    {
        string ToString();


    }
}
