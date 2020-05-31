using System;

namespace BlackJack1M
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("*********************");
			Console.WriteLine($"Wlcome to the best BlackJack console app ever! JK LOL \\(^o^)/ it\'s ok\nPlease select from the options below:");

			while (true)
			{
				Console.WriteLine("0 - Exit");
				Console.WriteLine("1 - Play");

				var answer = Console.ReadLine();

				switch (answer)
				{
					case "0":
						return;
					case "1":
						Deck d = Game.CreateNEwDeck();					
						var dealerCards = Game.DealerHand();
						var userCards = Game.UserHand();
						Game.HitCard(dealerCards, d.GameDeck);
						Game.HitCard(dealerCards, d.GameDeck);
						Game.HitCard(userCards, d.GameDeck);
						Game.HitCard(userCards, d.GameDeck);
						Console.WriteLine("Your cards are:");
						foreach (var card in userCards)
						{
							Console.WriteLine($"{card.cardVal}, {card.cardNum}");
						}
						Console.WriteLine($"Dealer's first card: {dealerCards[0].cardVal}, {dealerCards[0].cardNum}");
						int dealerHandSum = Game.SumHandValue(dealerCards);
						int playerHandSum = Game.SumHandValue(userCards);
						if (dealerHandSum == 21 && playerHandSum != 21)
						{
							Console.WriteLine($"Sorry, dealer won, got {dealerHandSum}. Dealer's hand:");
							foreach (var card in dealerCards)
							{
								Console.WriteLine($"{card.cardVal}, {card.cardNum}");
							}
							Console.WriteLine($"You, on the other hand, got {playerHandSum}:");
							foreach (var card in userCards)
							{
								Console.WriteLine($"{card.cardVal}, {card.cardNum}. GAME OVER!");
							}
							return;
						}

						Console.WriteLine($"Hit or stay? h/s");
						string ans = Console.ReadLine().ToLower();
						switch (ans)
						{
							case "h":
								Game.HitCard(userCards, d.GameDeck);
								Game.HitCard(dealerCards, d.GameDeck);
								int lastIndexUser = userCards.Count - 1;
								int lastIndexDealer = dealerCards.Count - 1;
								Console.WriteLine($"Your card: {userCards[lastIndexUser].cardVal}, {userCards[lastIndexUser].cardNum}");
								Console.WriteLine($"Dealer's card: {dealerCards[lastIndexDealer].cardVal}, {dealerCards[lastIndexDealer].cardNum}");
								if (dealerHandSum == 21 && playerHandSum != 21)
								{
									Console.WriteLine($"Sorry, dealer won, got {dealerHandSum}. Dealer's hand:");
									foreach (var card in dealerCards)
									{
										Console.WriteLine($"{card.cardVal}, {card.cardNum}");
									}
									Console.WriteLine($"You, on the other hand, got {playerHandSum}:");
									foreach (var card in userCards)
									{
										Console.WriteLine($"{card.cardVal}, {card.cardNum}. GAME OVER!");
									}
									return;
								}

								break;
							case "s":
								Game.Stay(userCards, dealerCards);
								if (Game.CheckWinner(userCards, dealerCards))
								{
									Console.WriteLine($"You Won!");
									return;
								}
								break;
							default:
								break;
						}

						break;
					default:
						break;
				}
			}
		}
	}
}
