using System;

namespace TransportationRedux
{
	public interface IJournal
	{
		void Write(string message);
	}
}
