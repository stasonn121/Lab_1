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

        public enum Americano
        {
            water = 200,
            sugar = 10,
            coffee = 20
        }

        public enum Espresso
        {
            water = 100,
            sugar = 10,
            coffee = 20
        }
        public enum Latte
        {
            water = 200,
            sugar = 10,
            coffee = 20, 
            milk = 50
        }
        public enum Tea
        {
            water = 200,
            sugar = 10,
            tea = 5
        }
        public enum Cappuccino
        {
            water = 200,
            sugar = 10,
            coffee = 20, 
            milk  = 50
        }
        public enum LatteTea
        {
            water = 200,
            sugar = 10,
            coffee = 20,
            tea = 5,
            milk = 20
        }

    }

    // добавил чай

    public enum Resource
    {
        milk,
        coffee,
        water,
        sugar,
        tea
    }
      
    
}
