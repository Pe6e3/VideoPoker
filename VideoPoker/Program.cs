using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace VideoPoker;
class Program
{

    public static void Main()
    {
        CursorVisible = false;

        Deck deck = new Deck();
        deck.NewDeck();
        deck.Shuffle();

        Hand hand = new Hand(deck);
        hand.ShowHand();
        Replace(hand, deck);




        ReadKey();





        void Replace(Hand hand, Deck deck)
        {

            for (int i = 1; i <= 42; i++)
            {
                bool[] replacedCards = new bool[6];
                int replace;

                while (true)
                {
                ForegroundColor = ConsoleColor.Black;
                    SetCursorPosition(0, 0);
                    replace = Convert.ToInt32(ReadKey().Key) - 48;

                    if (replace >= 1 && replace <= 5)
                    {
                        replacedCards[replace] = !replacedCards[replace];
                        hand.SelectCard(replace);
                    }

                    if (replace == -35) break;
                }

                ForegroundColor = ConsoleColor.White;

                for (int k = 1; k <= 5; k++)
                {
                    if (replacedCards[k])
                    {
                        hand.ChangeCard(deck, k);
                        hand.ShowHand(k);
                    }
                }

                //deck.ShowDeck();   // можно раскомментировать, чтобы убедииться, что карты берутся из одной колоды
                ForegroundColor = ConsoleColor.Black; // это чтобы текст системный в конце не было видно
            }

        }
    }
}

