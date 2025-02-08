using System;

namespace playground.Models;

public class MemberModel
{
    public required int Id {get;set;}
    public required PersonModel Member {get; set;}
}
