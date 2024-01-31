using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Axe : Tool
	{
		private string Name;

		public Axe(string name)
		{
			this.Name = name;
		}

		public override void AddMe(List<Collectable> list)
		{
			Console.WriteLine(Name + " Collected, Congrats!!!!");
			list.Add(this);
			DoAction();
		}

		public override void Display() 
		{
			Console.WriteLine("Axe " + Name + " is displayed");
		}

		public override void DoAction() // have to override this still 
		{
			Console.WriteLine("Axe is used");
		}
	}
}

