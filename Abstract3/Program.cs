using System;

namespace Abstract3
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();
            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecordable).Stop();

        }
    }
}
