using System;
using System.Collections.Generic;

class User : IEquatable<User>
{
    public int Id { get; set; }
    public string Email { get; set; }

    public bool Equals(User other)
    {
        if (other is null) return false;
        return Id == other.Id;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as User);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        var users = new HashSet<User>();

        users.Add(new User { Id = 1, Email = "abama@test.com" });
        users.Add(new User { Id = 1, Email = "tramp@test.com" }); 
        users.Add(new User { Id = 2, Email = "biden@test.com" });

        foreach (var user in users)
            Console.WriteLine($"{user.Id} - {user.Email}");
    }
}