using System;
using System.Threading;

namespace SharedTransportation
{
    public abstract class Transporter
    {
		protected int CalculateTime(int distance, int rate) => distance / rate;
		protected void TransportFor(int time) => Thread.Sleep(time * 1000);
		protected int CalculateDepletion(Package package, int multiplier) => package.GetWeight() * multiplier;
	}
}
