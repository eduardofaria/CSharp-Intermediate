namespace Interface_Delegate;

public class MessageError : IConsole
{
    public void MsgInConsole(string message)
    {
        System.Console.WriteLine($"Error: {message}");
    }
}