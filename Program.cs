using IteratorPattern.Interface;
using IteratorPattern.Services;

namespace IteratorPattern;
class Program
{
    public static void Main(string[] args)
    {
        LibraryService library = new LibraryService();
        library.AddBook("Book 1");
        library.AddBook("Book 2");
        library.AddBook("Book 3");

        IIterator iterator = library.CreateIterator();

        while (iterator.HasNext())
        {
            string book = (string)iterator.Next();
            Console.WriteLine("Reading: " + book);
        }
    }
}