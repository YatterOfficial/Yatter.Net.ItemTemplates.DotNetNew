using System;
using Yatter.Invigoration;

namespace InvigorationTObjects.TObject
{
	public class TOClass : ObjectBase
	{
		public string TObjectType { get; set; }

		/*
		*  Add your additional properties here
		*
		* n.b. You should have already installed the Nuget package Yatter.Invigoration
		*/

		public TOClass()
		{
			TObjectType = GetType().ToString();
		}
	}
}

