using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack1M
{
	class PlayerHand
	{

		#region Properties
		public List<Card> PlayersHand { get; set; }

		public int HandSum { get; set; }

		#endregion

		#region Methods
		public PlayerHand()
		{
			HandSum = 0;
			PlayersHand = new List<Card>();
		}


		public void  ShowHand(List<Card> l)
		{
			Console.WriteLine("Your Hand: ");
			foreach (var card in l)
			{
				Console.WriteLine($"{card.cardVal}, {card.cardNum} |");
			}
		}

		

		

		#endregion
	}
}
