using System;

namespace SharedTransportation
{
	public interface IJournal
	{
		void Write(string message);
	}
}
