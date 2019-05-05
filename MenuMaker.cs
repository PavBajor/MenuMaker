using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yelow mustard", "mustard", " honey mustard", "mayo", "relish" };
        string[] Breads = { "rye bread", "white bread", "wheat bread", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}
