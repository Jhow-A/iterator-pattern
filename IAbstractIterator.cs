namespace IteratorPattern
{
    // Iterator
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
    }
}
