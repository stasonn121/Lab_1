using System.Collections.Generic;

namespace Lab_1.Constants
{
    static class Consts
    {

        public static readonly Dictionary<string, int> drinkPrice = new Dictionary<string, int>
        {
            {"Americano", 15},
            {"Espresso",  15},
            {"Latte",     25},
            {"Tea",       10},
            {"Cappuccino",25},
            {"LatteTea",  20},
        };

        public static Dictionary<string, int> selectedDrinks = new Dictionary<string, int>
        {
            {"Americano", 0},
            {"Espresso",  0},
            {"Latte",     0},
            {"Tea",       0},
            {"Cappuccino",0},
            {"LatteTea",  0},
        };

    }
}
