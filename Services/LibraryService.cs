using IteratorPattern.Interface;
using System.Collections;

namespace IteratorPattern.Services;

// Aggregate
public class LibraryService
{
    private ArrayList _books = new ArrayList();

    public void AddBook(string book)
    {
        _books.Add(book);
    }

    public IIterator CreateIterator()
    {
        return new BookIteratorService(_books);
    }
}