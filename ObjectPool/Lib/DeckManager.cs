using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Lib
{
    class DeckManager
    {
        private const int POOL_SIZE = 10;
        protected static readonly DeckManager instance = new DeckManager();
        private List<Deck> decks;

        protected DeckManager()
        {
            decks = new List<Deck>(POOL_SIZE);
        }

        public static DeckManager CreateDeckManager()
        {
            return instance;
        }

        public Deck TakeDeck()
        {
            if (decks.Count != 0)
            {
                foreach (Deck deck in decks)
                {
                    if (!deck.IsActive)
                    {
                        deck.IsActive = true; //???
                        return deck;
                    }
                }
            }

            else
            {
                decks = new List<Deck>(POOL_SIZE);
                for (int i = 0; i < POOL_SIZE; i++)
                {
                    decks.Add(new Deck());
                }
                decks[0].IsActive = true;
                return decks[0];
            }

            return null;
        }
        
        public void ReleaseDeck(Deck d)
        {
            d.IsActive = false;
        }

    }
}
