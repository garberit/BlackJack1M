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
		
		/// <summary>
		/// Instantiates the hand with sum = 0
		/// </summary>
		public PlayerHand()
		{
			HandSum = 0;
			PlayersHand = new List<Card>();
		}		

		#endregion
	}
}
