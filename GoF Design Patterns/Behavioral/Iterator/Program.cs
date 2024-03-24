using Iterator;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IBooksCollection, BooksCollection>();

using var serviceProvider = services.BuildServiceProvider();

var booksCollection = serviceProvider.GetRequiredService<IBooksCollection>();

booksCollection.AddBook("dlsncpw", "lamxmdl", 1900);
booksCollection.AddBook("lzmdolp", "apoets", 1930);
booksCollection.AddBook("akmdxlk", "pqkdxi", 1960);
booksCollection.AddBook("xvfdsyu", "lfxgoe", 2010);

var nameIterator = booksCollection.GetNameIterator();
var authorIterator = booksCollection.GetAuthorIterator();
var yearIterator = booksCollection.GetYearIterator();

foreach (var book in nameIterator.Iterate()) 
 Console.WriteLine(book.ToString());

Console.WriteLine("-----------------------------");

foreach (var book in authorIterator.Iterate()) 
 Console.WriteLine(book.ToString());

Console.WriteLine("-----------------------------");

foreach (var book in yearIterator.Iterate())
 Console.WriteLine(book.ToString());
