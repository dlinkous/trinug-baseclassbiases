using System;

namespace TransportationRedux
{
    public class DrivingTransporter : Transporter
    {
		public int Gas { get; set; }
		protected override void CalculateDepletion(int weight) => Gas -= weight * 23;
		protected override int GetRate() => 35;
		protected override string GetVerb() => "driving";
	}
}
