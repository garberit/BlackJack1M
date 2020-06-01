using System;

namespace BlackJack1M
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("*********************");
			Console.WriteLine($"Welcome to the best BlackJack console app ever! JK LOL \\(^o^)/ it\'s ok\nPlease select from the options below:");
			

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
							int dealerHandSum = Game.SumHandValue(dealerCards);
							int playerHandSum = Game.SumHandValue(userCards);
							Console.WriteLine("Your cards are:");
							foreach (var card in userCards)
							{
								Console.Write($"{card.cardVal}, {card.cardNum}. ");
							}
							Console.WriteLine($"Your total is: {playerHandSum}");
							Console.WriteLine($"Dealer's first card: {dealerCards[0].cardVal}, {dealerCards[0].cardNum}");

							if (dealerHandSum == 21 && playerHandSum != 21)
							{
								Console.WriteLine($"Sorry, dealer won, got {dealerHandSum}. Dealer's hand:");
								foreach (var card in dealerCards)
								{
									Console.Write($"{card.cardVal}, {card.cardNum}. ");
								}
								Console.WriteLine($"You, on the other hand, got {playerHandSum}:");
								foreach (var card in userCards)
								{
									Console.Write($"{card.cardVal}, {card.cardNum}. ");
								}
								break;
							}
							if (playerHandSum < 21 && dealerHandSum < 21)
							{
							while (answer != "0")
							{							
									Console.WriteLine($"Hit or stay? h/s");
									string ans = Console.ReadLine().ToLower();
									switch (ans)
									{
										case "h":
											Game.HitCard(userCards, d.GameDeck);
											Game.HitCard(dealerCards, d.GameDeck);
											int lastIndexUser = userCards.Count - 1;
											int lastIndexDealer = dealerCards.Count - 1;
											Console.WriteLine($"Your card: {userCards[lastIndexUser].cardVal}, {userCards[lastIndexUser].cardNum}, sum: {Game.SumHandValue(userCards)}");
											Console.WriteLine($"Dealer's card: {dealerCards[lastIndexDealer].cardVal}, {dealerCards[lastIndexDealer].cardNum}");
											if (Game.SumHandValue(dealerCards) == 21 && Game.SumHandValue(userCards) != 21)
											{
												Console.WriteLine($"Sorry, dealer won, got {Game.SumHandValue(dealerCards)}. Dealer's hand:");
												foreach (var card in dealerCards)
												{
													Console.Write($"{card.cardVal}, {card.cardNum}. ");
												}
												Console.WriteLine($"You, on the other hand, got {Game.SumHandValue(userCards)}:");
												foreach (var card in userCards)
												{
													Console.Write($"{card.cardVal}, {card.cardNum}. ");
												}
												answer = "0";
												break;
												
										} else if (Game.SumHandValue(dealerCards) < 21 && Game.SumHandValue(userCards) > 21)
										{
											Console.WriteLine($"Sorry, dealer won, got {Game.SumHandValue(dealerCards)}. Dealer's hand:");
											foreach (var card in dealerCards)
											{
												Console.Write($"{card.cardVal}, {card.cardNum}. ");
											}
											Console.WriteLine($"You, on the other hand, got {Game.SumHandValue(userCards)}:");
											foreach (var card in userCards)
											{
												Console.Write($"{card.cardVal}, {card.cardNum}. ");
											}
											answer = "0";
											break;
										} else if (Game.SumHandValue(dealerCards) > 21 && Game.SumHandValue(userCards) < 21)
										{
											Console.WriteLine($"You won. Dealer busted. You: {Game.SumHandValue(userCards)}, Dealer: {Game.SumHandValue(dealerCards)}");
											answer = "0";
											break;

										} else if (Game.SumHandValue(dealerCards) < 21 && Game.SumHandValue(userCards) > 21)
										{
											Console.WriteLine($"Sorry, dealer won, got {Game.SumHandValue(dealerCards)}. Dealer's hand:");
											foreach (var card in dealerCards)
											{
												Console.Write($"{card.cardVal}, {card.cardNum}. ");
											}
											Console.WriteLine($"You, on the other hand, got {Game.SumHandValue(userCards)}:");
											foreach (var card in userCards)
											{
												Console.Write($"{card.cardVal}, {card.cardNum}. ");
											}
											answer = "0";
											break;
										} else if (Game.SumHandValue(dealerCards) > 21 && Game.SumHandValue(userCards) > 21)
										{
											Console.WriteLine($"Sorry, you are both losers!! Dealer: {Game.SumHandValue(dealerCards)}. Dealer's hand:");
											foreach (var card in dealerCards)
											{
												Console.Write($"{card.cardVal}, {card.cardNum}. ");
											}
											Console.WriteLine($"You: {Game.SumHandValue(userCards)}:");
											foreach (var card in userCards)
											{
												Console.Write($"{card.cardVal}, {card.cardNum}. ");
											}
											answer = "0";
											break;
										}

											break;
										case "s":
											Game.Stay(userCards, dealerCards);
											if (Game.CheckWinner(userCards, dealerCards))
											{
											answer = "0";
											break;
										} else
										{
											answer = "0";
											break;
										}
									default:
											break;
									}
							}

						} else if (Game.SumHandValue(dealerCards) == 21 && Game.SumHandValue(userCards) != 21)
						{
							Console.WriteLine($"Sorry, dealer won, got {Game.SumHandValue(dealerCards)}. Dealer's hand:");
							foreach (var card in dealerCards)
							{
								Console.Write($"{card.cardVal}, {card.cardNum}. ");
							}
							Console.WriteLine($"You, on the other hand, got {Game.SumHandValue(userCards)}:");
							foreach (var card in userCards)
							{
								Console.Write($"{card.cardVal}, {card.cardNum}. ");
							}
							break;
						}
						{

						}
							break;
						default:
							Console.WriteLine("Sorry, not a valid option!");
							break;
					}
				
			}
		}
	}
}
