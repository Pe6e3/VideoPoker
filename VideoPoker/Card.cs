using static System.Console;

namespace VideoPoker;

public class Card : Deck
{
    public static string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    public static string[] suits = { "\u2660", "\u2665", "\u2666", "\u2663" }; //♠ ♥ ♦ ♣ 

    public string rank;
    public string suit;

    public Card(string rank, string suit)
    {
        this.rank = rank;
        this.suit = suit;
    }

    public override string ToString()
    {
        return $"{rank}{suit}";
    }

}

