namespace EventsAndDelegates;

public class MailService
{
    public void OnVideoEncoded()
    {
        Console.WriteLine("MailService: Sending an email...");
    }
}