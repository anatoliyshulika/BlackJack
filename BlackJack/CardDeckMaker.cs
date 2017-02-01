using System;
using System.Collections.Generic;
using System.IO;

namespace BlackJack
{
    static class CardDeckMaker
    {
        public static List<Card> GetCardDeck()
        {
            Card card;
            List<Card> CardDeck = new List<Card>();
            card.name = "Двойка червы";
            card.cardValue = 2;
            CardDeck.Add(card);
            card.name = "Двойка бубны";
            card.cardValue = 2;
            CardDeck.Add(card);
            card.name = "Двойка трефы";
            card.cardValue = 2;
            CardDeck.Add(card);
            card.name = "Двойка пики";
            card.cardValue = 2;
            CardDeck.Add(card);

            card.name = "Тройка червы";
            card.cardValue = 3;
            CardDeck.Add(card);
            card.name = "Тройка бубны";
            card.cardValue = 3;
            CardDeck.Add(card);
            card.name = "Тройка трефы";
            card.cardValue = 3;
            CardDeck.Add(card);
            card.name = "Тройка пики";
            card.cardValue = 3;
            CardDeck.Add(card);

            card.name = "Четверка червы";
            card.cardValue = 4;
            CardDeck.Add(card);
            card.name = "Четверка бубны";
            card.cardValue = 4;
            CardDeck.Add(card);
            card.name = "Четверка трефы";
            card.cardValue = 4;
            CardDeck.Add(card);
            card.name = "Четверка пики";
            card.cardValue = 4;
            CardDeck.Add(card);

            card.name = "Пятерка червы";
            card.cardValue = 5;
            CardDeck.Add(card);
            card.name = "Пятерка бубны";
            card.cardValue = 5;
            CardDeck.Add(card);
            card.name = "Пятерка трефы";
            card.cardValue = 5;
            CardDeck.Add(card);
            card.name = "Пятерка пики";
            card.cardValue = 5;
            CardDeck.Add(card);

            card.name = "Шестерка червы";
            card.cardValue = 6;
            CardDeck.Add(card);
            card.name = "Шестерка бубны";
            card.cardValue = 6;
            CardDeck.Add(card);
            card.name = "Шестерка трефы";
            card.cardValue = 6;
            CardDeck.Add(card);
            card.name = "Шестерка пики";
            card.cardValue = 6;
            CardDeck.Add(card);

            card.name = "Семерка червы";
            card.cardValue = 7;
            CardDeck.Add(card);
            card.name = "Семерка бубны";
            card.cardValue = 7;
            CardDeck.Add(card);
            card.name = "Семерка трефы";
            card.cardValue = 7;
            CardDeck.Add(card);
            card.name = "Семерка пики";
            card.cardValue = 7;
            CardDeck.Add(card);

            card.name = "Восьмерка червы";
            card.cardValue = 8;
            CardDeck.Add(card);
            card.name = "Восьмерка бубны";
            card.cardValue = 8;
            CardDeck.Add(card);
            card.name = "Восьмерка трефы";
            card.cardValue = 8;
            CardDeck.Add(card);
            card.name = "Восьмерка пики";
            card.cardValue = 8;
            CardDeck.Add(card);

            card.name = "Девятка червы";
            card.cardValue = 9;
            CardDeck.Add(card);
            card.name = "Девятка бубны";
            card.cardValue = 9;
            CardDeck.Add(card);
            card.name = "Девятка трефы";
            card.cardValue = 9;
            CardDeck.Add(card);
            card.name = "Девятка пики";
            card.cardValue = 9;
            CardDeck.Add(card);

            card.name = "Десятка червы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Десятка бубны";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Десятка трефы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Десятка пики";
            card.cardValue = 10;
            CardDeck.Add(card);

            card.name = "Валет червы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Валет бубны";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Валет трефы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Валет пики";
            card.cardValue = 10;
            CardDeck.Add(card);

            card.name = "Дама червы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Дама бубны";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Дама трефы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Дама пики";
            card.cardValue = 10;
            CardDeck.Add(card);

            card.name = "Король червы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Король бубны";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Король трефы";
            card.cardValue = 10;
            CardDeck.Add(card);
            card.name = "Король пики";
            card.cardValue = 10;
            CardDeck.Add(card);

            card.name = "Туз червы";
            card.cardValue = 11;
            CardDeck.Add(card);
            card.name = "Туз бубны";
            card.cardValue = 11;
            CardDeck.Add(card);
            card.name = "Туз трефы";
            card.cardValue = 11;
            CardDeck.Add(card);
            card.name = "Туз пики";
            card.cardValue = 11;
            CardDeck.Add(card);

            return CardDeck;
        }
    }
}
