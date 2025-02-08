// See https://aka.ms/new-console-template for more information
using playground.Models;
using playground.Repositories;

LibraryRepository library = new LibraryRepository();

PersonModel person1 = new PersonModel {
    Name = "Oliver Enciso",
    Age = 34
};

PersonModel person2 = new PersonModel {
    Name = "David Enciso",
    Age = 16
};

PersonModel person3 = new PersonModel {
    Name = "Devoura Enciso",
    Age = 32
};

BookModel book1 = new BookModel{
    Id = 1,
    Title = "Rich Dad, Poor Dad",
    Author = "Rober Keyosaki",
};

BookModel book2 = new BookModel{
    Id = 2,
    Title = "Four Quadrants",
    Author = "Rober Keyosaki",
};

BookModel book3 = new BookModel{
    Id = 3,
    Title = "More than Money",
    Author = "Rober Keyosaki",
};

library.CreateLibrary(new LibraryModel{
    Name = "Devs Library"
});

library.AddLibrarian(person3);
library.AddMember(person2);
library.AddMember(person1);

library.AddBook(book1);

library.AddBook(book2);
library.AddBook(book3);

Console.WriteLine("Library: {0}", library.GetName());
Console.WriteLine("Status: {0}", library.GetLibraryDetail().IsOpen == false ? "Close" : "Open");

var _members = library.GetMembers();
var _books = library.GetBooks();
        Console.WriteLine("Book Count {0}",_books.Count());

Console.WriteLine("Members List");
if(_members.Count() > 0)
foreach(var m in _members){
        Console.WriteLine("{0}",m.Member.Name);
}

Console.WriteLine("\nBook List");
if(_books.Count() > 0)
foreach(var b in _books){
        Console.WriteLine("{0}",b.Title);
}

Console.WriteLine("\n Hi! It's your librarian: {0}", library.GetLibrarian());

