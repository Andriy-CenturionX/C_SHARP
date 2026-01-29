using System;

enum HttpStatusCode
{
    Ok = 200,
    NotFound = 404,
    InternalServerError = 500
}

class Program
{
    static void Main()
    {
        HandleResponse(HttpStatusCode.Ok);
        HandleResponse(HttpStatusCode.NotFound);
        HandleResponse(HttpStatusCode.InternalServerError);
    }

    static void HandleResponse(HttpStatusCode statusCode)
    {
        if (statusCode == HttpStatusCode.Ok)
            Console.WriteLine("OK");

        else if (statusCode == HttpStatusCode.NotFound)
            Console.WriteLine("Not Found");

        else if (statusCode == HttpStatusCode.InternalServerError)
            Console.WriteLine("Internal Server Error");
    }
}
