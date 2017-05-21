using System;

namespace TransportationRedux
{
	public class SolarTransporter : Transporter
	{
		protected override void CalculateDepletion(int weight) { }
		protected override int GetRate() => 140;
		protected override string GetVerb() => "flying";
	}
}
