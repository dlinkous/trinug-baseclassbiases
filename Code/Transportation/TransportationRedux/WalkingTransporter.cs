using System;

namespace TransportationRedux
{
	public class WalkingTransporter : Transporter
	{
		public int Kilocalories { get; set; }
		protected override void CalculateDepletion(int weight) => Kilocalories -= weight * 100;
		protected override int GetRate() => 3;
		protected override string GetVerb() => "walking";
	}
}
