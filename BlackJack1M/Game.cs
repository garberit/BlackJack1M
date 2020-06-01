using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack1M
{
	 static class Game
	{

		#region Properties

		#endregion

		#region Methods
		
		/// <summary>
		/// Create a new deck
		/// </summary>
		/// <returns>Returns a new deck with 52 unique cards</returns>
		public static Deck CreateNEwDeck()
		{
			Deck d = new Deck();
			return d;
		} 

		/// <summary>
		/// Creates a list to store player's cards
		/// </summary>
		/// <returns>Returns a new list to store the player's cards</returns>
		public static List<Card> UserHand()
		{
			PlayerHand userHand = new PlayerHand();
			return userHand.PlayersHand;
		}

		/// <summary>
		/// Creates a list to store dealer's cards
		/// </summary>
		/// <returns>Returns a new list to store the dealer's cards</returns>
		public static List<Card> DealerHand()
		{
			PlayerHand dealerHand = new PlayerHand();
			return dealerHand.PlayersHand;
		}

		/// <summary>
		/// Checks sum of cards if player choses to stay and not be dealt more cards
		/// </summary>
		/// <param name="player">The player's name of list(hand)</param>
		/// <param name="dealer">The dealer's name of list(hand)</param>
		public static void Stay(List<Card> player, List<Card> dealer)
		{
			int sumPlayer = SumHandValue(player);
			int sumDealer = SumHandValue(dealer);

			if (sumPlayer > 21 && sumDealer <= 21)
			{
				Console.WriteLine($"Sorry mate, you lost. Your hand: {sumPlayer}. Dealer: {sumDealer}");
			}
			else if (sumPlayer < sumDealer && sumDealer <= 21)
			{
				Console.WriteLine($"Sorry mate, you lost. Your hand: {sumPlayer}. Dealer: {sumDealer}");

			}
			else if (sumDealer > 21 && sumPlayer <= 21)
			{
				Console.WriteLine($"You Won!!!! Your hand: {sumPlayer}. Dealer: {sumDealer}");

			}
			else if (sumPlayer > 21)
			{
				Console.WriteLine($"Sorry mate, you lost.Your hand: { sumPlayer}. Dealer: { sumDealer}");

			}
			else
			{
				Console.WriteLine($"You Won!!!! Your hand: {sumPlayer}. Dealer: {sumDealer}");
				

			}
		}

		/// <summary>
		/// Hit's another card
		/// </summary>
		/// <param name="l">The hand which is dealt a card</param>
		/// <param name="d">The para which stores the deck</param>
		public static Card HitCard(List<Card> l, List<Card> d)
		{
			if (l != null)
			{
				l.Add(d[0]);
				d.Remove(d[0]);
			}
			return d[0];
		}

		/// <summary>
		/// Sums the value of a hand
		/// </summary>
		/// <param name="l">The list which sum will be calculated for (hand)</param>
		/// <returns>Returns the int sum of the cards in a hand</returns>
		public static int SumHandValue(List<Card> l)
		{
			int HandSum = 0;
			foreach (var card in l)
			{
				switch (card.cardNum)
				{
					case "Two":
						HandSum += 2;
						break;
					case "Three":
						HandSum += 3;
						break;
					case "Four":
						HandSum += 4;
						break;
					case "Five":
						HandSum += 5;
						break;
					case "Six":
						HandSum += 6;
						break;
					case "Seven":
						HandSum += 7;
						break;
					case "Eight":
						HandSum += 8;
						break;
					case "Nine":
						HandSum += 9;
						break;
					case "Ten":
						HandSum += 10;
						break;
					case "Jack":
						HandSum += 10;
						break;
					case "Queen":
						HandSum += 10;
						break;
					case "King":
						HandSum += 10;
						break;
					case "Ace":
						if (HandSum >= 11)
						{
							HandSum += 1;
						}						
						else
						{
							HandSum += 11;
						}
						break;
					default:
						break;
				}
			}
			return HandSum;
		}
		/// <summary>
		/// Checks if player won
		/// </summary>
		/// <param name="player">The list which stores player's cards</param>
		/// <param name="dealer">The list which stores dealer's cards</param>
		/// <returns></returns>
		public static bool CheckWinner(List<Card> player, List<Card> dealer)
		{
			int sumPlayer = SumHandValue(player);
			int sumDealer = SumHandValue(dealer);

			bool playerWon = false;
			if (sumPlayer > 21 && sumDealer <= 21)
			{
				playerWon = false;
			}
			else if (sumPlayer < sumDealer && sumDealer <= 21)
			{
				playerWon = false;

			}
			else if (sumDealer > 21 && sumPlayer <= 21)
			{
				playerWon = true;

			}
			else
			{
				playerWon = true;

			}
			return playerWon;
		}


		#endregion


	}
}
