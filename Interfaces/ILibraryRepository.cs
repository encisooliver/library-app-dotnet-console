using System;
using playground.Models;

namespace playground.Interfaces;

public interface ILibraryRepository
{
    public void CreateLibrary(LibraryModel library);
    public LibraryModel GetLibraryDetail();
    public string? AddName(string name);
    public string? GetName();
    public string GetLibrarian();
    public List<MemberModel> GetMembers();
    public void AddMember(PersonModel person);
    public void AddLibrarian(PersonModel librarian);
    public List<BookModel> GetBooks();
    public void AddBook(BookModel book);
    public BookModel? BorrowBook(int id);
    public string ReturnBook(int id, PersonModel borrower);
}
