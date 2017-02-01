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
            int numberOfCards = 52;
            CardDistributor cardDistributor = new CardDistributor(CardDeckMaker.GetCardDeck(numberOfCards));
            Diller diller = new Diller(cardDistributor, numberOfPlayers);
            Player player = new Player(diller, cardDistributor);
            diller.ConnectWithPlayer = player;
            diller.newDistribut();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tКарты диллера");
                diller.ShowCards();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tВаши карты");
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
