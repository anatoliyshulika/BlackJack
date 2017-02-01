using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack
{
    class Diller
    {
        int money = 1000000000;
        int numberOfPlayers = 0;
        bool cardsDisplayFlag = false;
        List<Card> cards = new List<Card>();
        Player connectWithPlayer;
        CardDistributor cardDistributor;
        public Diller(CardDistributor cardDistributor, int numberOfPlayers)
        {
            this.cardDistributor = cardDistributor;
            this.numberOfPlayers = numberOfPlayers;
        }
        public bool CardsDisplayFlag
        {
            get
            {
                return cardsDisplayFlag;
            }
        }
        public int Money
        {
            set
            {
                if (0 < value)
                {
                    money += value;
                }
            }
        }
        public Player ConnectWithPlayer
        {
            set
            {
                connectWithPlayer = value;
            }
        }
        public List<Card> Cards
        {
            get
            {
                return cards;
            }
        }
        public void newDistribut()
        {
            cardsDisplayFlag = false;
            cards.Clear();
            List<Card> playerCards = new List<Card>();
            int i = 0;
            foreach (var c in cardDistributor.newDistribute(numberOfPlayers * 2)) // Здесь магическое число 2 означает что сдается в начале игры всегда по 2 карты
            {
                if (i < 2)
                {
                    cards.Add(c);
                    i++;
                }
                else
                {
                    playerCards.Add(c);
                }
            }
            connectWithPlayer.MakeABet();
            connectWithPlayer.Cards = playerCards;
        }
        public void GetOneCard()
        {
            cards.Add(cardDistributor.GetOneCard());
        }
        public void ShowCards()
        {
            if (cardsDisplayFlag)
            {
                foreach (var c in cards)
                {
                    Console.WriteLine("\t" + c.name);
                }
            }
            else
            {
                Console.WriteLine("\t" + cards[0].name);
                Console.WriteLine("\tСкрытая карта");
            }
        }
        public void ScoreCount()
        {
            if (cardsDisplayFlag)
            {
                Thread.Sleep(2000);
                int score = 0;
                int playerScore = 0;
                foreach (var c in cards)
                {
                    score += c.cardValue;
                }
                foreach (var c in connectWithPlayer.Cards)
                {
                    playerScore += c.cardValue;
                }
                if (16 >= score)
                {
                    GetOneCard();
                }
                else if (21 == playerScore && playerScore > score && 2 == connectWithPlayer.Cards.Count)
                {
                    Console.WriteLine("\tПоздравляем!!! У Вас Black Jack!!! :) Ваш выиграш составляет 2:1 к вашей ставке \n\tХотите сыграть еще раз Y/N");
                    money -= connectWithPlayer.Bet * 2;
                    connectWithPlayer.ReturnBet(connectWithPlayer.Bet * 2);
                    string[] key = Console.ReadLine().Split(' ');
                    switch (key[0].ToLower())
                    {
                        case "y":
                            newDistribut();
                            break;
                        case "n":
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("\tДля выхода нажмите Alt+F4");
                                Console.ReadKey();
                            }
                    }
                }
                else if (playerScore == score)
                {
                    Console.WriteLine("\tНичья!!! :) Хотите сыграть еще раз Y/N");
                    connectWithPlayer.ReturnBet();
                    string[] key = Console.ReadLine().Split(' ');
                    switch (key[0].ToLower())
                    {
                        case "y":
                            newDistribut();
                            break;
                        case "n":
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("\tДля выхода нажмите Alt+F4");
                                Console.ReadKey();
                            }
                    }
                }
                else if(playerScore > score && 19 > score)
                {
                    GetOneCard();
                }
                else if(playerScore > score || 21 < score)
                {
                    Console.WriteLine("\tПоздравляем!!! Вы выиграли!!! :) Ваш выиграш составляет 1:1 к вашей ставке \n\tХотите сыграть еще раз Y/N");
                    money -= connectWithPlayer.Bet;
                    connectWithPlayer.ReturnBet(connectWithPlayer.Bet);
                    string[] key = Console.ReadLine().Split(' ');
                    switch (key[0].ToLower())
                    {
                        case "y":
                            newDistribut();
                            break;
                        case "n":
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("\tДля выхода нажмите Alt+F4");
                                Console.ReadKey();
                            }
                    }
                }
                else if(playerScore < score)
                {
                    Console.WriteLine("\tК сожалению Вы проиграли!!! :) \n\tХотите сыграть еще раз Y/N");
                    money += connectWithPlayer.Bet;
                    string[] key = Console.ReadLine().Split(' ');
                    switch (key[0].ToLower())
                    {
                        case "y":
                            newDistribut();
                            break;
                        case "n":
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("\tДля выхода нажмите Alt+F4");
                                Console.ReadKey();
                            }
                    }
                }
            }
        }
        public void OpenDiller()
        {
            cardsDisplayFlag = true;
        }
    }
}
