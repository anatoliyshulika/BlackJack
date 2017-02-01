using System;
using System.Collections.Generic;
using System.IO;

namespace BlackJack
{
    static class CardDeckMaker
    {
        public static List<Card> GetCardDeck(int numberOfCards)
        {
            Card card;
            List<Card> CardDeck = new List<Card>();
            string pathToCardInfo = "InfoAboutCards.txt";
            FileInfo chekExistFile = new FileInfo(pathToCardInfo);
            if (chekExistFile.Exists)
            {
                using (StreamReader sr = new StreamReader(pathToCardInfo, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < numberOfCards; i++)
                    {
                        try
                        {
                            card.name = sr.ReadLine();
                            card.cardValue = int.Parse(sr.ReadLine());
                            CardDeck.Add(card);
                        }
                        catch
                        {
                            Console.WriteLine("Извините, файл с данными был поврежден, попробуйте переустановить приложение");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл с данными о картах не найден");
            }
            return CardDeck;
        }
    }
}
