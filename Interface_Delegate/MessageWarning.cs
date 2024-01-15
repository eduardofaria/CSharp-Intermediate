namespace Interface_Delegate;

public class MessageWarning : IConsole
{
    public void MsgInConsole(string message)
    {
        System.Console.WriteLine($"Warning: {message}");
    }
}