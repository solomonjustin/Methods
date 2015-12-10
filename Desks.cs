using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab9
{
    class Desks
    {
        static void Main(string[] args)
        {
            int numberOfDrawers, price;
            char woodType;

            //GET NUNBER OF DRAWERS FROM USER WHICH IS SAVED VIA GetNumOfDrawers()
            Write("Enter # of drawers: ");
            numberOfDrawers = GetNumOfDrawers();

            //GET WOOD TYPE FROM USER
            Write("Enter wood type (m for mahogany, p for pine, o for oak): ");
            woodType = GetWoodType();

            //PRICE = DATA RETURNED FROM PASSING THE USER INPUT TO CalculatePrice()
            price = CalculatePrice(numberOfDrawers, woodType);

            //DISPLAY RESULTS VIA DisplayDetails()
            WriteLine();
            DisplayDetails(price, numberOfDrawers, woodType);
        }

        private static int GetNumOfDrawers()
        {
            int numberOfDrawers = int.Parse(ReadLine());
            return numberOfDrawers;
        }

        private static char GetWoodType()
        {
            char woodType = char.Parse(ReadLine().ToLower());
            return woodType;
        }

        private static int CalculatePrice(int numOfDrawers, char woodType)
        {
            int price, woodCost; 
            const int SURCHARGE = 30;

            if (woodType == 'p')
                woodCost = 100;
            else if (woodType == 'o')
                woodCost = 140;
            else
                woodCost = 180;

            price = woodCost + (numOfDrawers * SURCHARGE);
            
            return price;
        }

        private static void DisplayDetails(int price, int numberOfDrawers, char woodType)
        {
            WriteLine("Order Details -------");
            WriteLine();
            WriteLine("Wood Type: {0}", woodType);
            WriteLine("# of Drawers: {0}", numberOfDrawers);
            WriteLine("Price: {0}", price.ToString("C2"));
        }
    }
}
