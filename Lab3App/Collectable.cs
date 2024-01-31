using System;
using System.Collections.Generic;

namespace Lab3App
{
	abstract internal class Collectable : Displayable
	{
		public CollectionBoard Board;
		public string Description;
		public abstract void AddMe(List<Collectable> list);
		public abstract void Display();
	}
}

