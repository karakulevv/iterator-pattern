using IteratorPattern.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Services;

// Concrete Iterator
public class BookIteratorService : IIterator
{
    private ArrayList _books;
    private int _index = 0;

    public BookIteratorService(ArrayList books)
    {
        _books = books;
    }

    public bool HasNext()
    {
        return _index < _books.Count;
    }

    public object Next()
    {
        object book = null;
        if (HasNext())
        {
            book = _books[_index];
            _index++;
        }
        return book;
    }
}