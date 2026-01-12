using System;

class Program
{
    static void Main()
    {
        IValidator password = new PasswordValidator("Test1234");
        Console.WriteLine("Пароль валідний: " + password.Validate());

        IValidator email = new EmailValidator("user_abema@mail.com");
        Console.WriteLine("Email валідний: " + email.Validate());
    }
}