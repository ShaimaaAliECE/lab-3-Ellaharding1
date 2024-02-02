using System;
using System.Collections.Generic;
namespace Lab3App
{
	internal abstract class Collectable:Displayable
	{
		public string name { get; set;}
        public CollectionBoard Board;

        public abstract void Display();


		public abstract void AddMe(List<Collectable> list);
		
	}
}

