using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool.Lib
{
    public class Kahveci
    {
        string kahvecininAdi = "ismet abi";
        Deck verilecekDeste;
        DeckManager deckManager;

        public void KagitIste()
        {
            deckManager = DeckManager.CreateDeckManager();
            verilecekDeste = deckManager.TakeDeck();
            if (verilecekDeste == null)
            {
                Console.WriteLine("abim boşta kağıt yok okey vereyim");
            }

        }

        public void HesabiIste()
        {
            KagitlariGeriVer();
        }
        void KagitlariGeriVer()
        {
            deckManager.ReleaseDeck(verilecekDeste);
        }

        public void Uyar()
        {
            verilecekDeste.WearOutDeck();
        }
    }
}
