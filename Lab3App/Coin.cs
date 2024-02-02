using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Coin: Treasure
    {
		public int Value { get; set; }

        public Coin(string name, int score, int value): base(name,score)
        {
            this.Value = value;
            this.Score = score;
        }

        public override void UpdateTotalValue()
		{
            Board.UpdateTotalValue(Value);
        }

        
		public override void Display()
		{
            Console.WriteLine($"Coin {name} is displayed");

		}
	}
}

