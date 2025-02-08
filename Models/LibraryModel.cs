using System;

namespace playground.Models;

public class LibraryModel
{
    public string? Name {get;set;}
    public bool IsOpen {get;set;} = false;
    public List<BookModel> BookList {get; set;} = new List<BookModel>();
    public List<MemberModel> MemberList {get; set;} = new List<MemberModel>();
    public PersonModel? Librarian;
    public void AddMember(PersonModel person){
        int id = MemberList.Count() == 0 ? 1 : MemberList.Count() + 1;
        MemberList.Add(new MemberModel{
            Id = id,
            Member = person
        });
    }
    public void AddBook(BookModel book){
        BookList.Add(book);
        Console.WriteLine("Debug: {0}", BookList.Count());
    }
}
