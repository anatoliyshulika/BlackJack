using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = 2;
            CardDistributor cardDistributor = new CardDistributor(CardDeckMaker.GetCardDeck());
            Diller diller = new Diller(cardDistributor, numberOfPlayers);
            Player player = new Player(diller, cardDistributor);
            diller.ConnectWithPlayer = player;
            diller.newDistribut();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tКарты диллера");
                Console.WriteLine();
                diller.ShowCards();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tВаши карты");
                Console.WriteLine();
                player.ShowCards();
                Console.WriteLine();
                Console.WriteLine("\tЧтобы взять карту, нажмите 1");
                Console.WriteLine("\tЧтобы вскрыть диллера, нажмите 2");
                player.ScoreCount();
                diller.ScoreCount();
                if(diller.CardsDisplayFlag)
                {
                    continue;
                }
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        player.GetOneCard();
                        break;
                    case '2':
                        diller.OpenDiller();
                        break;
                }
            }
        }
    }
}
