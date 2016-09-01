namespace ADS.ADS
{
    public interface IDataStructure<T>
    {
        void Insert(T node);

        bool Delete(T node);
    }
}
