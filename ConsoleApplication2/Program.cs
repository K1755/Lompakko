using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet lompakko = new Wallet();

            Card sKortti = new Card { Name = "S-Etukortti", Number = "1234 5678", Owner = "Terttu Rypäle" };
            Card kKortti = new Card { Name = "K-Plussakortti", Number = "8765 4321", Owner = "Terttu Rypäle" };
            lompakko.AddCard(sKortti);
            lompakko.AddCard(kKortti);
            lompakko.AddMoney(500);
            lompakko.PrintContent();
            lompakko.WithDraw(250);
            lompakko.WithDraw(300);
            lompakko.PrintContent();
            lompakko.RemoveCard(sKortti);
            lompakko.PrintContent();

            Console.ReadLine();
        }
    }
}
