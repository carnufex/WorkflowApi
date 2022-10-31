namespace App1.Data.Exceptions;

using System.Runtime.Serialization;

[Serializable]
public class PersonNotSavedException : Exception
{
    public PersonNotSavedException()
    {
    }

    public PersonNotSavedException(string? message) : base(message)
    {
    }

    public PersonNotSavedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected PersonNotSavedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}