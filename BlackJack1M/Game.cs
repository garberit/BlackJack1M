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
		public static Deck CreateNEwDeck()
		{
			Deck d = new Deck();
			return d;
		} 

		public static List<Card> UserHand()
		{
			PlayerHand userHand = new PlayerHand();
			return userHand.PlayersHand;
		}

		public static List<Card> DealerHand()
		{
			PlayerHand dealerHand = new PlayerHand();
			return dealerHand.PlayersHand;
		}

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
			else
			{
				Console.WriteLine($"You Won!!!! Your hand: {sumPlayer}. Dealer: {sumDealer}");

			}
		}

		public static void HitCard(List<Card> l, List<Card> d)
		{
			if (l != null)
			{
				l.Add(d[0]);
				d.Remove(d[0]);
			}
		}

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
						Console.WriteLine($"Your deck sum is curretly {HandSum}. Please choose value for Ace: 1 or 11:");
						var answer = Console.ReadLine().ToString();
						if (answer == "1")
						{
							HandSum += 1;

						}
						else if ((answer == "11"))
						{
							HandSum += 11;
						}
						else
						{
							HandSum += 1;
						}
						break;
					default:
						break;
				}
			}
			return HandSum;
		}
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
