namespace ADS.ADS.Data
{
    public interface IData
    {
        int Compare(IData dataToCompare);

        string ToString();
    }
}
