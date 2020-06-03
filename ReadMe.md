# This is just a homework project

## Classes:

### Card
Define face and numeric value via enum

### Deck
Defines the list of cards, the game deck. Whenever a new game starts, a new deck of 52 uniqe cards will be created and shuffled.

### PlayerHand
Defines the atttributes of a player's hand (dealer and end user).
It creates a list of cards for each player and holds the sum of all cards in a hand.

### Game
This is where all the classes are called. It is sort of the factory class although I don't know enough to create it properly with the right access modifiers.
When this class is called, it can:
- Create a new deck
- Instantiate a hand (list of cards) for user
- Instantiate a hand (list of cards) for dealer
- Hit a card from deck to dealer or user (and remove it from the deck)
- Stay, which will then check the sum of both cards and determine who won
- Sum the cards in a hand
- Return a true or false to determine if the user won or lost


### Program
This is where all the slopy code happens. Sorry :-)

Here's a photo from [Imgur](https://imgur.com/r/funny/yEPpw)

![This is from Imgur](https://i.imgur.com/yEPpw.gif)