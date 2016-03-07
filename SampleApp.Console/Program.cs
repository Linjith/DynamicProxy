using SampleApp.Core.IoC;
using SampleApp.Core.Interfaces;

namespace SampleApp.Console
{
    internal class Program
    {
        public  static void Main(string[] args)
        {
            //Initialize the dependency resolver
            DependencyResolver.Initialize();

            //resolve the type:Rocket
            var rocket = DependencyResolver.For<IRocket>();

            //method call
            rocket.Launch(10);

            System.Console.ReadKey();
           
        }
    }
}
