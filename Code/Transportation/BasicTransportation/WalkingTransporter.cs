using System;
using System.Threading;

namespace BasicTransportation
{
    public class WalkingTransporter
    {
		public int Kilocalories { get; set; }

		public void Transport(Package package, IJournal journal, int distance)
		{
			Kilocalories -= package.GetWeight() * 100;
			journal.Write($"Walking with {package.Name}...");
			var time = distance / 3;
			TransportFor(time);
			journal.Write("Finished walking!");
		}

		private void TransportFor(int time)
		{
			const int millisecondsPerSecond = 1000;
			Thread.Sleep(time * millisecondsPerSecond);
		}
    }
}
