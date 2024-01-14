using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class VideoEncoder
    {
        // 1 - Define a delegate
        public delegate void VideoEncodeEventHandler();

        // 2 - Define an event based on that delegate
        public event VideoEncodeEventHandler? WasEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            // 4 - Call the method that call the event
            OnVideoEncoded();
        }

        // 3 - Raise the event
        protected void OnVideoEncoded()
        {
            // 5 - Verify subscribers for that event
            if (WasEncoded != null) // if not null, is because there is a subscriber for that event
            {
                WasEncoded();
            }
        }
    }
}
