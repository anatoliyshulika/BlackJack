using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class CardDistributor
    {
        List<Card> cardDeck;
        public CardDistributor(List<Card> CardDeck)
        {
            cardDeck = CardDeck;
        }
        public List<Card> newDistribute(int quantity)
        {
            if(20 >= cardDeck.Count)
            {
                cardDeck = CardDeckMaker.GetCardDeck();
            }
            int numberOfCard;
            Random rnd = new Random();
            List<Card> returnedCardList = new List<Card>();
            for(int i = quantity; 0 != i; i--)
            {
                numberOfCard = rnd.Next(0, cardDeck.Count);
                int j = 0;
                int k = 0;
                Card remuvedCardFromCardList = new Card();
                foreach(var card in cardDeck)
                {
                    if(j == numberOfCard)
                    {
                        returnedCardList.Add(card);
                        remuvedCardFromCardList = card;
                        k = 1;
                    }
                    j++;
                }
                if (0 != k)
                {
                    cardDeck.Remove(remuvedCardFromCardList);
                }
            }
            return returnedCardList;
        }
        public Card GetOneCard()
        {
            int numberOfCard;
            Card returnedCard = new Card();
            Random rnd = new Random();
            numberOfCard = rnd.Next(0, cardDeck.Count);
            int j = 0;
            foreach (var card in cardDeck)
            {
                if (j == numberOfCard)
                {
                    returnedCard = card;
                }
                j++;
            }
            cardDeck.Remove(returnedCard);
            return returnedCard;
        }
    }
}
