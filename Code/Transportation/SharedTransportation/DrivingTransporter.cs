using System;

namespace SharedTransportation
{
	public class DrivingTransporter : Transporter
	{
		public int Gas { get; set; }

		public void Transport(Package package, IJournal journal, int distance)
		{
			Gas -= base.CalculateDepletion(package, 23);
			journal.Write($"Driving with {package.Name}...");
			var time = base.CalculateTime(distance, 35);
			base.TransportFor(time);
			journal.Write("Finished driving!");
		}
	}
}
