namespace Domain.Exceptions;


public class RatesNotFoundException : Exception
{
    public RatesNotFoundException() : base("Rates cannot be provided for the given date.") { }
}

