using SampleApp.Core.Interfaces;
using System;
using System.Threading;

namespace SampleApp.Core.Types
{
    public class Rocket: IRocket
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public void Launch(int delaySeconds)
        {

            Console.WriteLine(string.Format("Launching rocket in {0} seconds",delaySeconds));
            Thread.Sleep(1000 * delaySeconds);
            Console.WriteLine("Congratulations! You have successfully launched the rocket");
        }
    }
}
