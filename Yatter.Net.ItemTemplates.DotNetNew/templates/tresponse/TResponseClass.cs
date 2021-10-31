using System;
using Yatter.Invigoration.TResponse;

namespace InvigorationTResponses.TResponse
{
	public class TRClass : ITResponse /*, [Extract this class's interface, when finished, here!] */
	{
		public string TResponseType { get; set; }

		#region Add your response properties here. If any of them correspond to another interface, add the interface above.


		#endregion

		public bool IsSuccess { get; set; }
		public string Message { get; set; }

		public TRClass()
		{
			TResponseType = GetType().ToString();
		}
	}
}
