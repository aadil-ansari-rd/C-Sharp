using System.Runtime.Serialization;

class Program
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User already logged in. Duplicate session is not alowed");
        }catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base() { }
    public UserAlreadyLoggedInException(string message) : base(message) { }

    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException) { }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}