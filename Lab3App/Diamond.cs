using System;
namespace Lab3App
{
	internal class Diamond: Treasure
    {
		int score;
		public int Value { get; set; }

		public Diamond(string name,int score):base (name,score)
		{
			this.name = name;
			this.score = score;
		}
		
		public override void Display()
		{
			Console.WriteLine($"Diamond{name} is displayed");
		}
		public override void UpdateTotalValue()
		{
			Board.UpdateTotalValue(Value);
		}
	}
}

