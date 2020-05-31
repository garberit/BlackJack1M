using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack1M
{
	class Deck
	{

		#region Properties

		public List<Card> GameDeck { get; set; }
		#endregion


		#region Methods

		public Deck()
		{
			//List<Card> gameDeck = new List<Card>();
			GameDeck = new List<Card>();
			foreach (var suit in Enum.GetValues(typeof(suits)))
			{
				foreach (var number in Enum.GetNames(typeof(number)))
				{
					var c = new Card()
					{
						cardVal = suit.ToString(),
						cardNum = number.ToString()
					};
					GameDeck.Add(c);
				}

			}
			ShuffleDeck<Card>(GameDeck);
		}

		public void ShuffleDeck<Card>(IList<Card> l)
		{
			Random rand = new Random();
			int n = l.Count;
			while (n > 1)
			{
				n--;
				int k = rand.Next(n + 1);
				Card c = l[k];
				l[k] = l[n];
				l[n] = c;
			}
		}

		

		#endregion
	}
}
