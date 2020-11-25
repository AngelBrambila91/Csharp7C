using System;
namespace Libraries
{
    public interface IPlayable
    {
         void Play();
         void Pause();
         void Stop()
         {
            Console.WriteLine("Default");
         }
    }
}