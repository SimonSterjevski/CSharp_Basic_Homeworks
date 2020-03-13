using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] drinks = { "Espresso", "Macchiato", "Latte", "Capuccino", "Tea" };
                double[] prices = { 2, 3.5, 4, 6, 1.5 };

            while (true)
            {
                Console.WriteLine("Welcome dear customer! Please select the correct number for the drink you like:");
                Console.WriteLine("1. Espresso...........2$");
                Console.WriteLine("2. Macchiato........3.5$");
                Console.WriteLine("3. Latte..............4$");
                Console.WriteLine("4. Cappuccino.........6$");
                Console.WriteLine("5. Tea..............1.5$");

                bool ifDrinkExist = int.TryParse(Console.ReadLine(), out int drink);
                if (ifDrinkExist && drink < 6 && drink > 0)
                {
                    while (true)
                    {
                        Console.WriteLine("Please choose level od sweetness from 1 to 5");
                        bool ifLevelValid = int.TryParse(Console.ReadLine(), out int sweetness);
                        if (ifLevelValid && sweetness < 6 && sweetness > 0)
                        {
                            Console.WriteLine("Sweetness level " + sweetness + " selected.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Level wrong. Please press enter and insert valid number");
                            Console.ReadLine();
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("You choose " + drinks[drink - 1] + ". That cost " + prices[drink - 1] + "$. Please insert money");
                        bool ifMoneyValid = double.TryParse(Console.ReadLine(), out double money);
                       
                            if (ifMoneyValid && money < prices[drink - 1])
                            {
                                double missing = prices[drink - 1] - money;
                                Console.WriteLine("You are missing " + missing + " $. Please press enter and try again");
                                Console.ReadLine();
                            }
                          
                        else if (!ifMoneyValid)
                        {
                            Console.WriteLine("Please press enter and insert valid number");
                            Console.ReadLine();
                        }
                        else
                        {
                            if (money > prices[drink-1])
                            {
                                double change = money - prices[drink - 1];
                                Console.WriteLine("Change: " + change + "$");
                            }
                            Console.WriteLine("Thanks! Enjoy your " + drinks[drink - 1]);
                            Console.ReadLine();
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Press enter and try again");
                    Console.ReadLine();
                }
            }


           



            
          
        }
    }
}
