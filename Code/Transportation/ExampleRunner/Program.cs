using System;
using BasicTransportation;
using redux = TransportationRedux;

namespace ExampleRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Example1();
			Example2();
			Console.ReadKey();
		}

		private static void Example1()
		{
			var package = new Package() { Name = "Example1" };
			var journal = new ConsoleJournal();
			var walkingTransporter = new WalkingTransporter() { Kilocalories = 2000 };
			walkingTransporter.Transport(package, journal, 6);
			var drivingTransporter = new DrivingTransporter() { Gas = 3000 };
			drivingTransporter.Transport(package, journal, 75);
		}

		private static void Example2()
		{
			var package = new redux.Package() { Name = "Example2" };
			var journal = new ConsoleJournal();
			var walkingTransporter = new redux.WalkingTransporter() { Kilocalories = 2000 };
			walkingTransporter.Transport(package, journal, 6);
			var drivingTransporter = new redux.DrivingTransporter() { Gas = 3000 };
			drivingTransporter.Transport(package, journal, 75);
		}
    }
}