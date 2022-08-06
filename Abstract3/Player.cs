using System;

namespace Abstract3
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play the track. ");
        }
        public void Record()
        {
            Console.WriteLine("Record the track. ");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause the track. ");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop the track. ");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Pause the recording. ");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Stop the recording. ");
        }
    }
}
