namespace IteratorPattern.Interface;

// Iterator Interface
public interface IIterator
{
    bool HasNext();
    object Next();
}