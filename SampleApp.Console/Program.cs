using SampleApp.Core.IoC;
using SampleApp.Core.Interfaces;
using System;

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
            try
            {
                rocket.Launch(2);
            }
            catch (Exception ex)
            {

            }
            System.Console.ReadKey();
           
        }
    }
}
