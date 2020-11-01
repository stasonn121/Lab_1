using Lab_1.Constants;

namespace Lab_1.Model
{
    static class CoffeeMachine
    {
        //Maximum capacity
        private const int _milkMax = 1000;
        private const int _coffeeMax = 1000;
        private const int _waterMax = 1000;
        private const int _sugarMax = 1000;
        private static int _cashBox;
        //private string _temp;
       // private int _tempInt;

        public static string NameMachine { get; private set; }
        public static int MilkNow { get; private set; }
        public static int CoffeeNow { get; private set; }
        public static int WaterNow { get; private set; }
        public static int SugarNow { get; private set; }
        public static int DeposedMoney { get; set; }
        public static int OrderAmount { get; set; }
        public static int Surrender { get; set; }



        static CoffeeMachine()
        {
            NameMachine = "CoffeMachine";
            MilkNow = _milkMax;
            CoffeeNow = _coffeeMax;
            WaterNow = _waterMax;
            SugarNow = _sugarMax;
            _cashBox = 0;
        }

        public static bool ReplenishmentAndPayment(int enteredMoney)
         {
            DeposedMoney += enteredMoney;
            _cashBox     += enteredMoney;

            if (DeposedMoney < OrderAmount)
            {
                return false; 
            }
            else
            {
                Surrender = DeposedMoney - OrderAmount;
                DeposedMoney = 0;
                OrderAmount = 0;
                return true;

            }
        }

        public static int Remainder(Resource resource)
        {
            switch (resource)
            {
                case Resource.milk:
                    return _milkMax - MilkNow;
                case Resource.coffee:
                    return _coffeeMax - CoffeeNow;
                case Resource.water:
                    return _waterMax - WaterNow;
                case Resource.sugar:
                    return _sugarMax - SugarNow;
            }
            return 0;
        }
    }
}
