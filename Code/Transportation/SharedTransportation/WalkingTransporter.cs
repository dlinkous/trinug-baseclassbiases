using System;

namespace SharedTransportation
{
    public class WalkingTransporter : Transporter
    {
		public int Kilocalories { get; set; }

		public void Transport(Package package, IJournal journal, int distance)
		{
			Kilocalories -= base.CalculateDepletion(package, 100);
			journal.Write($"Walking with {package.Name}...");
			var time = base.CalculateTime(distance, 3);
			base.TransportFor(time);
			journal.Write("Finished walking!");
		}
	}
}
