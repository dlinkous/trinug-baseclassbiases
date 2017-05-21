using System;
using BasicTransportation;
using redux = TransportationRedux;

namespace ExampleRunner
{
	public class ConsoleJournal : IJournal, redux.IJournal
	{
		public void Write(string message)
		{
			Console.WriteLine(message);
		}
	}
}
