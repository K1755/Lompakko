using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Wallet
    {
        private int money;

        private Dictionary<String, Card> cards;
        public Wallet()
        {
            cards = new Dictionary<String, Card>();
            Console.WriteLine("Lompakko alustettu");
        }
        public void AddMoney(int amount)
        {
            money = money + amount;
        }
        public void WithDraw(int amount)
        {
            if (amount > money)
            {
                Console.WriteLine("Otto epäonnistui, yritettiin ottaa {0} euroa, lompakko sisältää vain {1} euroa", amount, money);
            }
            else
            {
                money = money - amount;
                Console.WriteLine("Lompakosta otettiin: {0} euroa", amount);
            }
        }
        public void AddCard(Card card)
        {
            cards.Add(card.Name, card);
            Console.WriteLine("Lompakkoon lisättiin kortti: {0}", card.ToString());
        }
        public void RemoveCard(Card card)
        {
            cards.Remove(card.Name);
            Console.WriteLine("Lompakosta poistettiin kortti: {0}", card.ToString());
        }
        public void PrintContent()
        {
            Console.WriteLine("Lompakon sisältö:\n -rahaa:{0} euroa\n -kortit: ", money);
            foreach (var card in cards)
            {
                Console.WriteLine("   {0}", card.Value.ToString());
            }
        }
    }
}
