using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        int money = 1000;
        int bet = 0;
        List<Card> cards;
        Diller diller;
        CardDistributor cardDistributor;
        public Player(Diller diller, CardDistributor cardDistributor)
        {
            this.diller = diller;
            this.cardDistributor = cardDistributor;
        }
        public int Bet
        {
            get
            {
                return bet;
            }
        }
        public List<Card> Cards
        {
            set
            {
                cards = value;
            }
            get
            {
                return cards;
            }
        }
        public void GetOneCard()
        {
            cards.Add(cardDistributor.GetOneCard());
        }
        public void ShowCards()
        {
            foreach (var c in cards)
            {
                Console.WriteLine("\t" + c.name);
            }
            Console.WriteLine();
            Console.WriteLine("\tВаши деньги " + money + "$");
            Console.WriteLine("\tВаша ставка " + bet + "$");
        }
        public void MakeABet()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tВаши деньги " + money + "$");
                if (0 == money)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("\tИзвинте, но Вы проиграли все свои деньги\n\tОхрана казино просит Вас покинуть помещение\n\tДля выхода нажмите Alt+F4");
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("\tСделайте свою ставку");
                try
                {
                    bet = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\tВы ввели не верные данные, попробуйте еще раз");
                    Console.ReadKey();
                    continue;
                }
                if (0 >= bet)
                {
                    Console.WriteLine("\tВы не можете сделать ставку меньше 1");
                    Console.ReadKey();
                    continue;
                }
                if (money >= bet)
                {
                    money -= bet;
                    break;
                }
                else
                {
                    Console.WriteLine("\tУ вас не достаточно денег для такой ставки, сделайте ставку меньше");
                    Console.ReadKey();
                }
            }
        }
        public void ScoreCount()
        {
            int score = 0;
            foreach (var c in cards)
            {
                score += c.cardValue;
            }
            if (21 < score)
            {
                diller.Money = bet;
                bet = 0;
                Console.WriteLine("\tВы проиграли набрав больше чем 21 очко. Ваша ставка уходит в пользу казино.\n\tХотите сыграть еще раз Y/N");
                string[] key = Console.ReadLine().Split(' ');
                switch (key[0].ToLower())
                {
                    case "y":
                        diller.newDistribut();
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
        public void ReturnBet()
        {
            money += bet;
            bet = 0;
        }
        public void ReturnBet(int b)
        {
            money += bet;
            money += b;
            bet = 0;
        }
    }
}
