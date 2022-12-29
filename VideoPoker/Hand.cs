using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net.Http.Json;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
using static VideoPoker.Print;

namespace VideoPoker;

internal class Hand : Deck
{

    private bool check1Pair { get; set; }
    private bool check2Pair { get; set; }
    private bool checkTriple { get; set; }
    private bool checkFullHouse { get; set; }
    private bool checkFlush { get; set; }
    private bool checkStraight { get; set; }
    private bool checkFour { get; set; }
    private bool checkStraightFlush { get; set; }
    private bool checkRoyalFlush { get; set; }
    public bool[] replacedCards = new bool[6];

    string gapLeft = "";
    string gapRight = "";
    int leftGap;
    int countLines;
    int linesAnimation;


    public Card[] cardHand = new Card[5];
    public Deck deck = new Deck();              // создали поле, в которое будет попадать та колода, с которой будем работать
    public Hand(Deck cardDeck)                  // передаем в метод именно Ту колоду, которую мы намешали методом Deck()
    {
        Deck deck = cardDeck;                   // передаем полученную колоду карт в поле класса
        for (int i = 0; i < 5; i++)
        {
            cardHand[i] = deck.GetCard();
        }
    }

    Card[] pair = new Card[5];   //первая пустая, чтобы начинать счет с 1 - мне таку удобнее )
    Card[] triple = new Card[4];



    public void ShowHand(int cardIndex = 0) // Выбираем, какую карту добавляем. Если все - ставить "0"
    {
        int cardIndex2;

        if (cardIndex == 0)
            cardIndex2 = 5;
        else cardIndex2 = --cardIndex + 1;

        for (int i = cardIndex; i < cardIndex2; i++)
        {
            leftGap = i * 15 + 41;

            for (int _linesAnimation = 0; _linesAnimation < 15; _linesAnimation++)
            {
                linesAnimation = _linesAnimation;
                countLines = 1;

                switch (cardHand[i].suit)
                {
                    case "\u2660": ForegroundColor = ConsoleColor.Black; break;
                    case "\u2663": ForegroundColor = ConsoleColor.Black; break;
                    default: ForegroundColor = ConsoleColor.Red; break;
                }

                BackgroundColor = ConsoleColor.White;
                SetCursorPosition(leftGap, 1);
                PaintLine(cardHand[i].suit, "left");
                PaintLine();
                PaintLine();
                PaintLine();
                PaintLine(cardHand[i].rank + cardHand[i].suit);
                PaintLine();
                PaintLine();
                PaintLine();
                PaintLine(cardHand[i].suit, "right");

                Thread.Sleep(1);

                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Green;

                PaintLine(Convert.ToString(i + 1), marginTop: -1);
                SetCursorPosition(leftGap, countLines + linesAnimation - 1);
                Console.WriteLine("           ");


                BackgroundColor = ConsoleColor.Black;
                SetCursorPosition(leftGap, countLines - 12 + linesAnimation + 1);
                Console.WriteLine("           ");

            }
        }

        CheckCombo();
    }

    public void PaintLine(string text = "", string aligment = "", int marginLeft = 0, int marginTop = 0, int zero = 1)
    {
        switch (aligment)
        {
            case "left": gapLeft = new string(' ', 1); gapRight = new string(' ', 10 - text.Length); break;
            case "right": gapRight = new string(' ', 1); gapLeft = new string(' ', 10 - text.Length); break;
            default: gapRight = new string(' ', 5); gapLeft = new string(' ', 6 - text.Length); break;
        }
        SetCursorPosition(leftGap * zero + marginLeft, countLines + linesAnimation - marginTop);
        if (text == " ")
            WriteLine(" ");
        WriteLine(gapLeft + text + gapRight);

        countLines++;
    }

    public void SelectCard(int cardIndex)
    {
        cardIndex--;
        int select;


        if (replacedCards[cardIndex] == true)
        {
            select = 0;
            replacedCards[cardIndex] = false;
        }
        else
        {
            select = 1;
            replacedCards[cardIndex] = true;
        }


        switch (cardHand[cardIndex].suit)
        {
            case "\u2660": ForegroundColor = ConsoleColor.Black; break;
            case "\u2663": ForegroundColor = ConsoleColor.Black; break;
            default: ForegroundColor = ConsoleColor.Red; break;
        }


        int _countlines = countLines;
        int mLeft = cardIndex * 15 + 41;
        int mTop = 10 + select;
        BackgroundColor = ConsoleColor.White;
        PaintLine(cardHand[cardIndex].suit, "left", marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(cardHand[cardIndex].rank + cardHand[cardIndex].suit, marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);
        PaintLine(cardHand[cardIndex].suit, "right", marginTop: mTop, marginLeft: mLeft, zero: 0);


        BackgroundColor = ConsoleColor.Black;
        //ForegroundColor = ConsoleColor.Green;
        PaintLine(marginTop: mTop, marginLeft: mLeft, zero: 0);

        //PaintLine(Convert.ToString(cardIndex + 1), marginLeft: mLeft, zero: 0);

        BackgroundColor = ConsoleColor.Black;

        PaintLine(text: "      ", marginTop: (1 - select) * mTop + mTop + 1, marginLeft: mLeft, zero: 0);

        countLines = _countlines;
        ///
    }


    public void ChangeCard(Deck cardDeck, int index)
    {
        cardHand[index - 1] = cardDeck.GetCard();
        replacedCards[index - 1] = false;
    }   // выбрасывает выбранную карту из руки и берет вместо нее самую верхнюю из колоды

    public void NullCombination(Deck[] decks1, Deck[] decks2 = null, Deck[] decks3 = null) // метод для быстрого обнуления массивов с выигрышными наборами карт
    {
        for (int i = 0; i < decks1.Length; i++)
            decks1[i] = null;
        if (decks2 != null)
            for (int i = 0; i < decks2.Length; i++)
                decks2[i] = null;
        if (decks3 != null)
            for (int i = 0; i < decks3.Length; i++)
                decks3[i] = null;
    }



    public void Check1Pair()
    {
        for (int first = 0; first < 5; first++)
        {
            for (int second = first + 1; second < 5; second++)
            {
                if (cardHand[first].rank == cardHand[second].rank)
                {
                    pair[1] = cardHand[first];
                    pair[2] = cardHand[second];
                    check1Pair = true;
                    return;
                }
            }
        }
        pair[1] = pair[2] = null;
        check1Pair = false;
    }
    public void Check2Pair() // проверка на вторую пару
    {
        if (check1Pair)
        {
            for (int first = 0; first < 5; first++)
            {
                for (int second = first + 1; second < 5; second++)
                {
                    if (cardHand[first].rank == cardHand[second].rank && cardHand[first].rank != pair[1].rank)
                    {
                        pair[3] = cardHand[first];
                        pair[4] = cardHand[second];
                        check2Pair = true;
                        return;
                    }
                }
            }
        }
        pair[3] = pair[4] = null;
        check2Pair = false;
    }

    public void CheckTriple()
    {
        checkFullHouse = false;
        for (int first = 0; first < 5; first++)
        {
            for (int second = first + 1; second < 5; second++)
            {
                for (int third = second + 1; third < 5; third++)
                {
                    if (cardHand[first].rank == cardHand[second].rank && cardHand[first].rank == cardHand[third].rank)
                    {

                        triple[1] = cardHand[first];
                        triple[2] = cardHand[second];
                        triple[3] = cardHand[third];

                        for (int fourth = 0; fourth < 5; fourth++)   // здесь мы находим индексы двух оставшихся карт
                        {
                            if (fourth != first && fourth != second && fourth != third)
                            {
                                for (int fiveth = fourth + 1; fiveth < 5; fiveth++)
                                    if (fiveth != first && fiveth != second && fiveth != third)
                                        if (cardHand[fourth].rank == cardHand[fiveth].rank)
                                        {
                                            checkFullHouse = true;
                                            checkTriple = false;
                                            return;
                                        }
                            }
                        }
                        checkTriple = true;
                        checkFullHouse = false;

                        return;
                    }
                }
            }
        }
        triple[1] = triple[2] = triple[3] = null;
        checkTriple = false;
    }

    public void CheckFlush()
    {
        for (int first = 0; first < 5; first++)
        {
            for (int second = first + 1; second < 5; second++)
            {
                for (int third = second + 1; third < 5; third++)
                {
                    for (int fourth = third + 1; fourth < 5; fourth++)
                        if (cardHand[first].suit == cardHand[second].suit && cardHand[first].suit == cardHand[third].suit && cardHand[first].suit == cardHand[fourth].suit)
                        {
                            NullCombination(pair, triple);
                            checkFlush = true;
                            return;
                        }
                    checkFlush = false;
                }
            }
        }
    }

    public void CheckStraight()
    {
        int[] handRanks = new int[6];
        for (int i = 1; i <= 5; i++)   // 1. Записываем в массив handRanks "очки" каждой карты (чтобы можно было сравнивать)
        {
            switch (cardHand[i - 1].rank)
            {
                case "2": handRanks[i] = 2; break;
                case "3": handRanks[i] = 3; break;
                case "4": handRanks[i] = 4; break;
                case "5": handRanks[i] = 5; break;
                case "6": handRanks[i] = 6; break;
                case "7": handRanks[i] = 7; break;
                case "8": handRanks[i] = 8; break;
                case "9": handRanks[i] = 9; break;
                case "10": handRanks[i] = 10; break;
                case "J": handRanks[i] = 11; break;
                case "Q": handRanks[i] = 12; break;
                case "K": handRanks[i] = 13; break;
                case "A": handRanks[i] = 14; break;
                default: handRanks[i] = 0; break;
            }
        }

        for (int i = 1; i < 5; i++) // 2. Расставляем в этом массиве карты попорядку
        {
            for (int j = i + 1; j < 6; j++)
            {
                if (handRanks[i] > handRanks[j])
                {
                    handRanks[0] = handRanks[i];
                    handRanks[i] = handRanks[j];
                    handRanks[j] = handRanks[0];
                }
            }
        }

        checkStraight = true; // заочно ставим Стрит - Истина, а дальше если не пройдет проверку - присвоим Ложь
        for (int i = 1; i <= 4; i++)
        {
            if (handRanks[i + 1] - handRanks[i] != 1 && handRanks[i] - handRanks[i + 1] != 1) checkStraight = false; // проверяем, есть ли хоть одна карта, которая идет не попорядку
            if (handRanks[5] == 14 && handRanks[1] == 2 && handRanks[2] == 3 && handRanks[3] == 4 && handRanks[4] == 5) // проверяем Стрит от Туза до 5. Это единственный вариант исключения, поэтому быстрее прописать отдельную строку для него
                checkStraight = true;
        }
    }


    public void CheckFour()
    {

    }

    public void CheckStraightFlush()
    {

    }

    public void CheckRoyalFlush()
    {

    }

    public void CheckCombo()
    {
        Check1Pair();
        Check2Pair();
        CheckTriple();
        CheckStraight();
        CheckFlush();
        CheckFour();
        CheckStraightFlush();
        CheckRoyalFlush();

        if (checkFullHouse)
        {
            NullCombination(pair, triple);
            check1Pair = check2Pair = checkTriple = false; // Если есть Фул Хауз, значит нет пар и трех одинковых
        }

        if (checkTriple)   // Если есть три одинаковых, но нет Фул Хауза - значит больше нет пар
        {
            NullCombination(pair);
            check1Pair = check2Pair = false;
        }

        if (check1Pair && !check2Pair)
        {
            if (pair[1].rank == "J" || pair[1].rank == "Q" || pair[1].rank == "K" || pair[1].rank == "A")
            {
            }
            else
            {
                NullCombination(pair);
                check1Pair = false;
            }
            pair[3] = pair[4] = null;
        }


        SetCursorPosition(0, 12);
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        Console.WriteLine("                                         ");
        SetCursorPosition(0, 12);

        Console.Write("Pairs: ");
        if (check1Pair || check2Pair)
            foreach (var p in pair) Console.Write(p + " ");
        Console.WriteLine("\nTriples: ");
        foreach (var t in triple)
            if (t != null) Console.Write($" {t}");

        if (check1Pair)
            Print.Text("\n1 Pair is :\t\t", Convert.ToString(check1Pair), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (check2Pair)
            Print.Text("2 Pair is :\t\t", Convert.ToString(check2Pair), colorText1: Color.Blue, colorText2: Color.Yellow);

        if (!check1Pair)
            Print.Text("\n1 Pair is :\t\t", Convert.ToString(check1Pair), colorText1: Color.Blue, colorText2: Color.Red);
        if (!check2Pair)
            Print.Text("2 Pair is :\t\t", Convert.ToString(check2Pair), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkTriple)
            Print.Text("Triple is :\t\t", Convert.ToString(checkTriple), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkTriple)
            Print.Text("Triple is :\t\t", Convert.ToString(checkTriple), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkFullHouse)
            Print.Text("Full House is :\t\t", Convert.ToString(checkFullHouse), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkFullHouse)
            Print.Text("Full House is :\t\t", Convert.ToString(checkFullHouse), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkFlush)
            Print.Text("Flush is :\t\t", Convert.ToString(checkFlush), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkFlush)
            Print.Text("Flush is :\t\t", Convert.ToString(checkFlush), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkStraight)
            Print.Text("Straight is :\t\t", Convert.ToString(checkStraight), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkStraight)
            Print.Text("Straight is :\t\t", Convert.ToString(checkStraight), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkFour)
            Print.Text("Four of a Kind is :\t", Convert.ToString(checkFour), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkFour)
            Print.Text("Four of a Kind is :\t", Convert.ToString(checkFour), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkStraightFlush)
            Print.Text("Straight Flush is :\t", Convert.ToString(checkStraightFlush), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkStraightFlush)
            Print.Text("Straight Flush is :\t", Convert.ToString(checkStraightFlush), colorText1: Color.Blue, colorText2: Color.Red);

        if (checkRoyalFlush)
            Print.Text("Royal Flush is :\t", Convert.ToString(checkRoyalFlush), colorText1: Color.Blue, colorText2: Color.Yellow);
        if (!checkRoyalFlush)
            Print.Text("Royal Flush is :\t", Convert.ToString(checkRoyalFlush), colorText1: Color.Blue, colorText2: Color.Red);
    }

}


