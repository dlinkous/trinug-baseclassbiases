using System;
using System.Threading;

namespace BasicTransportation
{
    public class DrivingTransporter
    {
		public int Gas { get; set; }

		public void Transport(Package package, IJournal journal, int distance)
		{
			Gas -= package.GetWeight() * 23;
			journal.Write($"Driving with {package.Name}...");
			var time = distance / 35;
			TransportFor(time);
			journal.Write("Finished driving!");
		}

		private void TransportFor(int time)
		{
			const int millisecondsPerSecond = 1000;
			Thread.Sleep(time * millisecondsPerSecond);
		}
	}
}
