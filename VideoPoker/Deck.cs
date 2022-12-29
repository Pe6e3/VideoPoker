using System.Security.Cryptography.X509Certificates;
using static System.Console;


namespace VideoPoker;

public class Deck
{
    public int countOfShuffle = 0;
    public Card[] cardDeck = new Card[52];    // cardDeck - это массив из 52 карт типа Card. В каждом элементе хранится карта с инфой о rank и suit
    public int indexOfTopCard = 0;            // Здесь хранится инфа о индексе карты, которая являтся на данный момент самой верхней. (остальные вышли из колоды)



    public Card GetCard()
    {
        Card tempCard = cardDeck[indexOfTopCard];
        indexOfTopCard++;
        return tempCard;
    } // Берет на себя значение самой верхней карты. А также меняет индекс самой верхней карты в колоде на следующую.
    public void NewDeck()   // создаем новую колоду, в которой все карты попорядку. Нужно запустить 1 раз, а потом только перемешивать ее.
    {
        int x = 0;
        foreach (string r in Card.ranks)
        {
            foreach (string s in Card.suits)
            {
                cardDeck[x] = new Card(r, s);
                x++;
            }
        }
    }
    public void Shuffle()   //Мешаем готовую колоду
    {
        countOfShuffle++;
        indexOfTopCard = 0;
        Random rnd = new Random();
        for (int i = 0; i < cardDeck.Length; i++)
        {
            int randomOfArray = rnd.Next(52);
            Card temp = cardDeck[i];
            cardDeck[i] = cardDeck[randomOfArray];
            cardDeck[randomOfArray] = temp;
        }

    }
    public void ShowDeck()
    {
        Console.Write("\n" + countOfShuffle + ": ");
        Console.ForegroundColor = ConsoleColor.Red;
        int countCardIndex = 0;

        foreach (Card c in cardDeck)
        {
            if (countCardIndex >= indexOfTopCard)
                Console.Write(c.ToString() + " ");
            countCardIndex++;
        }
        Console.ForegroundColor = ConsoleColor.White;

    }

}
