using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace playground.Models;

public class BookModel
{
    public required int Id {get; set;}
    public required string Title {get; set;}
    public string? Author {get; set;}
    // public int Pages {get; set;}
    // public Boolean IsOpen {get; set;}
    // public string? ISBN {get; set;}
    // public int CurrentPage {get; set;}
}
