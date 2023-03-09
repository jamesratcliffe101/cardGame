using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> cardpack = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    Card new_card = new Card();
                    new_card.Suit = j;
                    new_card.Value = i;
                    cardpack.Add(new_card);
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle, List<Card> deck)
        {
            //Shuffles the pack based on the type of shuffle
            var rand = new Random();

            switch(typeOfShuffle)
            {
                case 1:  // fisher shuffle
                    Console.WriteLine("fisher shuffle");
                    for (int i = deck.Count()-1; i > 0; i--)
                    {
                        swap(rand.Next(i-1), i);
                    }
                    break;

                case 2:  // riffle shuffle
                    Console.WriteLine("riffle shuff");
                    // simulate a riffle shuffle using swaps...
                    // riffle shuffle moves cards in such a way...

                    // 1, 2, 3, 4, 5, 6, 7, 8, ... , 51, 52
                    // after shuffle \/   before shuffle /\
                    // 26, 1, 27, 2, 28, 3, 29, ... , 25, 52

                    // 1 swich with 26
                    // 2 swich with 1
                    // 3 switch with 27
                    // 4 switch with 2
                    // etc...

                    for (int i = 0; i < deck.Count() - 1; i++)
                    {
                        int switch_state = 0;
                        switch (switch_state)
                        {
                            case 0:
                                swap(i, (i / 2) + 25);
                                switch_state = 1;
                                break;

                            case 1:
                                swap(i, (i / 2));
                                switch_state = 0;
                                break;
                        }
                    }

                    break;
                case 3:  // no shuffle
                    Console.WriteLine("no shuff!");
                    break;
            }

            return false;
        }
        public static Card deal(List<Card> deck)
        {
            //Deals one card
            return deck[0];

        }
        public static List<Card> dealCard(int amount, List<Card> deck)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> test = new List<Card>();
            
            for (int i = 0; i < amount; i++)
            {
                test.Add(deck[i]);
            }
            return test;
        }

        private static void swap(int a, int b)
        {
            // given two indexes, swaps the cards of a and b
            Card store = cardpack[a];
            cardpack[a] = cardpack[b];
            cardpack[b] = store;
        }
    }
}
