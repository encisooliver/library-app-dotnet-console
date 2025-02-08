using System;

namespace playground.Models;

public class BorrowedBook
{
    public required BookModel Book {get; set;}
    public required PersonModel Borrower{get; set;}
}
