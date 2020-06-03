using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack1M
{
	class Deck
	{

		#region Properties

		public List<Card> GameDeck { get; private set; }
		#endregion


		#region Methods



		/// <summary>
		/// Shuffling algorithm (Fisher–Yates shuffle) to be used when instantiating the new game deck
		/// </summary>
		/// <typeparam name="Card">Objects in the deck list</typeparam>
		/// <param name="l">The list of cards to be shuffled (AKA the deck)</param>
		public void ShuffleDeck<Card> (IList<Card> l)
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

		#region Instancing

		/// <summary>
		/// Creates a card deck with 52 unique cards and shuffles their order using the Shuffle method
		/// </summary>
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

		#endregion
	}
}
