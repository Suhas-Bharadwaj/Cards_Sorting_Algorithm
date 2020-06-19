using System;
using System.Linq;

namespace Cards_Sorting_Algorithm
{
    static class Program
    {
        enum Deck
        {
            Diamonds_Ace,
            Diamonds_2,
            Diamonds_3,
            Diamonds_4,
            Diamonds_5,
            Diamonds_6,
            Diamonds_7,
            Diamonds_8,
            Diamonds_9,  
            Diamonds_10,  
            Diamonds_Jack,
            Diamonds_Queen,
            Diamonds_King, 

            Hearts_Ace,
            Hearts_2,
            Hearts_3,
            Hearts_4,
            Hearts_5,
            Hearts_6,
            Hearts_7,
            Hearts_8,
            Hearts_9,
            Hearts_10,
            Hearts_Jack,
            Hearts_Queen,
            Hearts_King,

            Clubs_Ace,
            Clubs_2,
            Clubs_3,
            Clubs_4,
            Clubs_5,
            Clubs_6,
            Clubs_7,
            Clubs_8,
            Clubs_9,
            Clubs_10,
            Clubs_Jack,
            Clubs_Queen,
            Clubs_King,

            Spades_Ace,
            Spades_2,
            Spades_3,
            Spades_4,
            Spades_5,
            Spades_6,
            Spades_7,
            Spades_8,
            Spades_9,
            Spades_10,
            Spades_Jack,
            Spades_Queen,
            Spades_King
        }
        static void Main(string[] args)
        {
            var Decks = Enumerable.Range(0, 52).ToArray();
            Random rnd = new Random();
            for (int i = 0; i < 52; i++)
            {
                int rndIndex = rnd.Next(0, 51);
                int temp = Decks[i];
                Decks[i] = Decks[rndIndex];
                Decks[rndIndex] = temp;
            }
            Console.WriteLine("The shuffled Deck is : ");
            foreach (var card in Decks)
            {
                Console.WriteLine((Deck)card + " ");
            }
            SelectionSort(Decks);
            Console.ReadLine();
        }
        private static void SelectionSort(int[] Decks)
        {
            for (int i = 0; i < Decks.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Decks.Length; j++)
                {
                    if (Decks[j] < Decks[min])
                    {
                        min = j;
                    }
                }
                int temp = Decks[i];
                Decks[i] = Decks[min];
                Decks[min] = temp;
            }
            Console.WriteLine("\nThe sorted deck is: ");
            foreach (var card in Decks)
            {
                Console.WriteLine((Deck)card + " ");
            }
        }
    }
}
       