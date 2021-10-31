using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yatter.Invigoration;
using Yatter.Invigoration.Exceptions;
using Yatter.Invigoration.TObject;
using Yatter.Invigoration.TResponse;

namespace InvigorationTActors.TActor
{
	/// <summary>
	/// [Short statement of role], invigorates a TODefault and responds with a TRNotImplemented
	/// </summary>
	public class TAClass : Yatter.Invigoration.ActionBase
	{
		public TODefault TODefault { get { return (TODefault)base.Object; } }

		public TAClass()
		{
			TActorType = GetType().ToString();
		}

		public void AddTObject(TODefault tObject)
		{
			base.Object = tObject;
		}

#if (IsAsync)
        public async override Task ActionAsync()
		{
			try
			{
				var input = TODefault;

           		/*
                * n.b. You should have already installed the Nuget package Yatter.Invigoration
                */

				// DO WORK HERE, DEFINING IsSuccess = true, and IsSuccess = false, AS APPROPRIATE      

				IsSuccess = true;

				if (IsSuccess)
				{
					Message = $"{GetType().ToString()} reports that [statement of what work was done] and has a Response type of {typeof(TRNotImplemented)}.";
				}
				else
				{
					Message = $"{GetType().ToString()} reports that it failed with the Message [statement of any chained failure messages]] and has a Response type of {typeof(TRNotImplemented)}";
				}

				base.Response = new TRNotImplemented { IsSuccess = IsSuccess, Message = Message };

				throw new TActorNotImplementedException(TActorType);

			}
			catch (Exception ex)
			{
				IsSuccess = false;
				Message = $"{GetType().ToString()}'s ActionAsync failed with the following Exception: [{ex.Message}] and has a Response type of {typeof(TRNotImplemented)}";
				base.Response = new TRNotImplemented { IsSuccess = IsSuccess, Message = Message };
			}
		}
#else
		public override void Action()
		{
			try
			{
				var input = TODefault;

				/*
			* n.b. You should have already installed the Nuget package Yatter.Invigoration
			*/

				// DO WORK HERE, DEFINING IsSuccess = true, and IsSuccess = false, AS APPROPRIATE

				IsSuccess = true;

				if (IsSuccess)
				{
					Message = $"{GetType().ToString()} reports that [statement of what work was done] and has a Response type of {typeof(TRNotImplemented)}.";
				}
				else
				{
					Message = $"{GetType().ToString()} reports that it failed with the Message [statement of any chained failure messages]] and has a Response type of {typeof(TRNotImplemented)}";
				}

				base.Response = new TRNotImplemented { IsSuccess = IsSuccess, Message = Message };

				throw new TActorNotImplementedException(TActorType);

			}
			catch (Exception ex)
			{
				IsSuccess = false;
				Message = $"{GetType().ToString()}'s Action failed with the following Exception: [{ex.Message}] and has a Response type of {typeof(TRNotImplemented)}";
				base.Response = new TRNotImplemented { IsSuccess = IsSuccess, Message = Message };
			}
		}
#endif
	}
}

