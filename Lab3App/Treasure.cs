using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Treasure:Collectable
	{
		public int Score;
		protected Treasure(string name,int score){
			this.name = name;
			this.Score = score;
			}

		public void UpdateTotalScore()
		{
			Board.UpdateTotalScore(Score);
        }
		public abstract void UpdateTotalValue();
		
		public override void AddMe(List<Collectable> list)
		{
            list.Add(this);
			Console.WriteLine($"{name} Collected, Congrats!!!!");
			UpdateTotalScore();
			if (this is Coin)
			{
				Board.UpdateTotalValue((this as Coin).Value);
			}
        }
    }
}

