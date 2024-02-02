using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Tool: Collectable
	{
        public Tool(string name)
		{
			this.name = name;
		}
		public abstract void DoAction();
	
		public override void AddMe(List<Collectable> list)
		{
            list.Add(this);
			Console.WriteLine($"{name} Collected, Congrats!!!!");
			DoAction();

        }
    }
}

