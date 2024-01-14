namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher of event
            var mailService = new MailService(); // subscriber of event


            videoEncoder.WasEncoded += mailService.OnVideoEncoded; //Subscription

            videoEncoder.Encode(video);
        }
    }
}
