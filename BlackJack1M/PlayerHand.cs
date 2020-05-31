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

		//public int SumHandValue(List<Card> l)
		//{
		//	foreach (var card in l)
		//	{
		//		switch (card.cardNum)
		//		{
		//			case "Two":
		//				HandSum += 2;
		//				break;
		//			case "Three":
		//				HandSum += 3;
		//				break;
		//			case "Four":
		//				HandSum += 4;
		//				break;
		//			case "Five":
		//				HandSum += 5;
		//				break;
		//			case "Six":
		//				HandSum += 6;
		//				break;
		//			case "Seven":
		//				HandSum += 7;
		//				break;
		//			case "Eight":
		//				HandSum += 8;
		//				break;
		//			case "Nine":
		//				HandSum += 9;
		//				break;
		//			case "Ten":
		//				HandSum += 10;
		//				break;
		//			case "Jack":
		//				HandSum += 10;
		//				break;
		//			case "Queen":
		//				HandSum += 10;
		//				break;
		//			case "King":
		//				HandSum += 10;
		//				break;
		//			case "Ace":
		//				Console.WriteLine($"Your deck sum is curretly {HandSum}. Please choose value for Ace: 1 or 11:");
		//				var answer = Console.ReadLine().ToString();
		//				if (answer =="1")
		//				{
		//					HandSum += 1;

		//				} else if ((answer == "11"))
		//				{
		//					HandSum += 11;
		//				} else {
		//					HandSum += 1;
		//						}
		//				break;
		//			default:
		//				break;
		//		}
		//	}
		//	return HandSum;
		//}


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
