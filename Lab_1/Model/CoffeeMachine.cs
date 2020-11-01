using Lab_1.Constants;

namespace Lab_1.Model
{
    static class CoffeeMachine
    {
        //Maximum capacity
        private const int _milkMax = 1000; //ml 
        private const int _coffeeMax = 1000; //mg
        private const int _waterMax = 1000; // ml
        private const int _sugarMax = 1000; // bg 
        private const int _teaMax = 1000; // bg 
                                          //private string _temp;
                                          // private int _tempInt;

        public static string NameMachine { get; private set; }
        public static int MilkNow { get; private set; }
        public static int CoffeeNow { get; private set; }
        public static int WaterNow { get; private set; }
        public static int SugarNow { get; private set; }
        public static int TeaNow { get; private set; }
        public static int CashBox { get; private set; }
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
            TeaNow = _teaMax;
            CashBox = 0;
        }
        public static bool IsResourseEnoughForDrink(string name, int amount)
        {
            int tempWater = WaterNow;
            int tempMilk = MilkNow;
            int tempTea = TeaNow;
            int tempSugar = SugarNow;
            int tempCoffee = CoffeeNow;

            switch (name)
            {
                case "Americano":
                    {
                        {
                            tempWater -= (int)Consts.Americano.water * amount;
                            tempSugar -= (int)Consts.Americano.sugar * amount;
                            tempCoffee -= (int)Consts.Americano.coffee * amount;
                            return tempWater >= 0 && tempSugar >= 0 && tempCoffee >= 0;
                        }
                    }
                case "Espresso":
                    {
                        {
                            tempCoffee -= (int)Consts.Espresso.coffee *amount;
                            tempWater -= (int)Consts.Espresso.water * amount;
                            tempSugar -= (int)Consts.Espresso.sugar * amount;
                            return tempWater >= 0 && tempSugar >= 0 && tempCoffee >= 0;
                        }
                    }
                case "Latte":
                    {
                        {
                            tempCoffee -= (int)Consts.Latte.coffee * amount;
                            tempWater -= (int)Consts.Latte.water * amount;
                            tempSugar -= (int)Consts.Latte.sugar * amount;
                            tempMilk  -= (int)Consts.Latte.milk * amount;
                            return tempWater >= 0 && tempSugar >= 0 && tempCoffee >= 0 && tempMilk >= 0;
                        }
                    }
                case "Tea":
                    {
                        {
                            TeaNow -= (int)Consts.Tea.tea     *amount;
                            WaterNow -= (int)Consts.Tea.water *amount;
                            SugarNow -= (int)Consts.Tea.sugar * amount;
                            return tempWater >= 0 && tempSugar >= 0 && TeaNow >= 0;

                        }
                    }
                case "Cappuccino":
                    {
                        {
                            CoffeeNow -= (int)Consts.Cappuccino.coffee *amount;
                            WaterNow -= (int)Consts.Cappuccino.water   *amount ;
                            SugarNow -= (int)Consts.Cappuccino.sugar   *amount ;
                            MilkNow -= (int)Consts.Cappuccino.milk * amount;
                            return tempWater >= 0 && tempSugar >= 0 && tempCoffee >= 0 && tempMilk >= 0;

                        }
                    }
                case "LatteTea":
                    {
                        {
                            CoffeeNow -= (int)Consts.Cappuccino.coffee *amount;
                            WaterNow -= (int)Consts.Cappuccino.water   *amount ;
                            SugarNow -= (int)Consts.Cappuccino.sugar   *amount ;
                            MilkNow -= (int)Consts.Cappuccino.milk     *amount ;
                            TeaNow -= (int)Consts.LatteTea.tea * amount;
                            return tempWater >= 0 && tempSugar >= 0 && tempCoffee >= 0 && tempMilk >= 0 && tempTea >= 0;

                        }
                    }
            }
            return true;
        }



        public static bool IsResourseEnough()
        {
            bool isEnough = false;
            foreach (var item in Consts.selectedDrinks)
            {
                if (item.Value != 0)
                {
                    isEnough = IsResourseEnoughForDrink(item.Key, item.Value);
                    if (!isEnough)
                    {
                        return false;
                    }
                }

            }
            return true;
        }




        public static bool MakeDrink(string name)
        {
            switch (name)
            {
                case "Americano":
                    {
                        if ((CoffeeNow - Consts.Americano.coffee) >= 0 &&
                            (WaterNow - Consts.Americano.water) >= 0 &&
                            (SugarNow - Consts.Americano.sugar) >= 0)
                        {
                            CoffeeNow -= (int)Consts.Americano.coffee;
                            WaterNow -= (int)Consts.Americano.water;
                            SugarNow -= (int)Consts.Americano.sugar;
                            return true;
                        }

                        break;
                    }
                case "Espresso":
                    {
                        if ((CoffeeNow - Consts.Espresso.coffee) >= 0 &&
                            (WaterNow - Consts.Espresso.water) >= 0 &&
                            (SugarNow - Consts.Espresso.sugar) >= 0)
                        {
                            CoffeeNow -= (int)Consts.Espresso.coffee;
                            WaterNow -= (int)Consts.Espresso.water;
                            SugarNow -= (int)Consts.Espresso.sugar;
                            return true;
                        }
                        break;
                    }
                case "Latte":
                    {
                        if ((CoffeeNow - Consts.Latte.coffee) >= 0 &&
                            (WaterNow - Consts.Latte.water) >= 0 &&
                            (SugarNow - Consts.Latte.sugar) >= 0 &&
                            (MilkNow - Consts.Latte.milk) >= 0)
                        {
                            CoffeeNow -= (int)Consts.Latte.coffee;
                            WaterNow -= (int)Consts.Latte.water;
                            SugarNow -= (int)Consts.Latte.sugar;
                            MilkNow -= (int)Consts.Latte.milk;
                            return true;
                        }
                        break;
                    }
                case "Tea":
                    {
                        if ((TeaNow - Consts.Tea.tea) >= 0 &&
                            (WaterNow - Consts.Tea.water) >= 0 &&
                            (SugarNow - Consts.Tea.sugar) >= 0)
                        {
                            TeaNow -= (int)Consts.Tea.tea;
                            WaterNow -= (int)Consts.Tea.water;
                            SugarNow -= (int)Consts.Tea.sugar;
                            return true;
                        }

                        break;
                    }
                case "Cappuccino":
                    {
                        if ((CoffeeNow - Consts.Cappuccino.coffee) >= 0 &&
                            (WaterNow - Consts.Cappuccino.water) >= 0 &&
                            (SugarNow - Consts.Cappuccino.sugar) >= 0 &&
                            (MilkNow - Consts.Cappuccino.milk) >= 0)
                        {
                            CoffeeNow -= (int)Consts.Cappuccino.coffee;
                            WaterNow -= (int)Consts.Cappuccino.water;
                            SugarNow -= (int)Consts.Cappuccino.sugar;
                            MilkNow -= (int)Consts.Cappuccino.milk;
                            return true;
                        }
                        break;
                    }
                case "LatteTea":
                    {
                        if ((CoffeeNow - Consts.LatteTea.coffee) >= 0 &&
                            (WaterNow - Consts.LatteTea.water) >= 0 &&
                            (SugarNow - Consts.LatteTea.sugar) >= 0 &&
                            (MilkNow - Consts.LatteTea.milk) >= 0 &&
                            (TeaNow - Consts.LatteTea.tea) >= 0)
                        {
                            CoffeeNow -= (int)Consts.Cappuccino.coffee;
                            WaterNow -= (int)Consts.Cappuccino.water;
                            SugarNow -= (int)Consts.Cappuccino.sugar;
                            MilkNow -= (int)Consts.Cappuccino.milk;
                            TeaNow -= (int)Consts.LatteTea.tea;
                            return true;
                        }
                        break;
                    }
            }
            return false;
        }


        public static bool MakeDrinks()
        {

            foreach (var item in Consts.selectedDrinks)
            {
                if (item.Value != 0)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        MakeDrink(item.Key);
                    }
                }

            }
            return false;

        }




     public static bool ReplenishmentAndPayment(int enteredMoney)
         {
            if (enteredMoney == 0)
                return false;

            DeposedMoney += enteredMoney;
            CashBox += enteredMoney;

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
