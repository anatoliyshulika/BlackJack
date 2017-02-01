using System;
using System.Collections.Generic;
using System.IO;

namespace BlackJack
{
    static class CardDeckMaker
    {
        public static List<Card> GetCardDeck()
        {
            string[] name = { "Двойка", "Тройка", "Четверка", "Пятерка", "Шестерка", "Семерка", "Восьмерка",
            "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };
            string[] suit = { "Червы", "Пики", "Бубны", "Трефы" };
            int[] cardValue = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            Card card;
            List<Card> CardDeck = new List<Card>();
            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    card.name = name[i];
                    card.suit = suit[j];
                    card.cardValue = cardValue[i];
                    CardDeck.Add(card);
                }
            }
            return CardDeck;
        }
    }
}
