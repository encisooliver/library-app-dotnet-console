using System;
using playground.Interfaces;
using playground.Models;

namespace playground.Repositories;

public class LibraryRepository: ILibraryRepository
{
    private LibraryModel _library = new LibraryModel();
    
    public string GetName(){
        return _library.Name == null ? "No Name": _library.Name;
    }
    public string AddName(string name){
        _library.Name = name;
        return _library.Name;
    }
    public void CreateLibrary(LibraryModel library){
        _library = library;
    }
    public LibraryModel GetLibraryDetail(){
        return _library;
    }
    public void AddMember(PersonModel person){
        _library.AddMember(person);
    }
    public void AddLibrarian(PersonModel librarian){
        _library.Librarian = librarian;
    }
    public string GetLibrarian(){
        return _library.Librarian != null ? _library.Librarian.Name : "Add librian";
    }
     public List<MemberModel> GetMembers(){
        return _library.MemberList;
    }

    public List<BookModel> GetBooks(){
        return _library.BookList;
    }
    public void AddBook(BookModel book){
        _library.AddBook(book);
    }
    public BookModel BorrowBook(int id)
    {
        var book = _library.BookList.Find(b => b.Id == id);
        return book ?? book;
    }
    public string ReturnBook(int id, PersonModel borrower)
    {
        return "";
    }
}
