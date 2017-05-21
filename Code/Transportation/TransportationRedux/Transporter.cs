using System;
using System.Threading;

namespace TransportationRedux
{
	public abstract class Transporter
	{
		protected abstract void CalculateDepletion(int weight);
		protected abstract int GetRate();
		protected abstract string GetVerb();

		public void Transport(Package package, IJournal journal, int distance)
		{
			CalculateDepletion(package.GetWeight());
			journal.Write($"{ToTitleCase(GetVerb())} with {package.Name}...");
			var time = distance / GetRate();
			TransportFor(time);
			journal.Write($"Finished {GetVerb().ToLower()}!");
		}

		private string ToTitleCase(string original) => original.Substring(0, 1).ToUpper() + original.Substring(1);
		private void TransportFor(int time) => Thread.Sleep(time * 1000);
	}
}
