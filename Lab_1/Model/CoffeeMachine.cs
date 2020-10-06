using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Model
{
    static class CoffeeMachine
    {
        //Maximum capacity
        private const int _milkMax = 1000;
        private const int _coffeeMax = 1000;
        private const int _waterMax = 1000;
        private const int _sugarMax = 1000;
        //private string _temp;
       // private int _tempInt;

        public static string NameMachine { get; private set; }
        public static int MilkNow { get; private set; }
        public static int CoffeeNow { get; private set; }
        public static int WaterNow { get; private set; }
        public static int SugarNow { get; private set; }
        public static int Cash { get; set; }


    }
}
