namespace Domain.Exceptions;


public class InvalidNameException : Exception
{
    public InvalidNameException() : base("Movie name is not valid.") { }
}

