using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class testing
    {
        public testing()
            {
            // create a card pack
            Pack cards = new Pack();

            Pack.shuffleCardPack(2, Pack.cardpack);

            List<Card> test = Pack.dealCard(52, Pack.cardpack);


            for (int i = 0; i < test.Count; i++)
            {
               Console.WriteLine(test[i].Value.ToString() + "  " + test[i].Suit.ToString());
            }




            Console.ReadLine(); // to hold the program in place
            }
           
    }
}
