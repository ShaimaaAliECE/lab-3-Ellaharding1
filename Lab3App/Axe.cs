using System;
namespace Lab3App
{
	internal class Axe:Tool
	{
		public Axe(string name):base(name)
		{
		}
		
		public override void Display()
		{
			Console.WriteLine($"Axe {name} is displayed");
		}
		public override void DoAction()
		{
			Console.WriteLine("Axe is Used");
		}
	}
}
