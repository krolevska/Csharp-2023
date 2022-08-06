using System;

namespace Abstract3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();

    }
}
