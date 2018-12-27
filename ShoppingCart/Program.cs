using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int apple = 0;
                int orange = 0;
                int appleCountAfterOffer = 0;
                int orangecountAfterOffer = 0;
                decimal applePrice = 0.60m;
                decimal orangePrice = 0.25m;
                decimal totalAmount = 0;
                string selectedOption;
                ArrayList fruitsCollection = new ArrayList();
                string[] fruitList = new string[] { "" };
                FruitsCount fruitsCount = new FruitsCount();
                Calculate calculate = new Calculate();
                Offer offer = new Offer();
                Console.WriteLine("Select Option");
            option:
                Console.WriteLine("1. Non-Offer  2. Offer");
                selectedOption = Console.ReadLine();

                if (selectedOption == "1" || selectedOption == "2")
                {
                    Console.WriteLine("Enter fruits with comma seperation");
                    string fruit = Console.ReadLine();
                    fruitList = fruit.ToLower().Split(',');
                    fruitsCount.Fruits(fruitList, ref apple, ref orange);
                    switch (selectedOption)
                    {
                        case "1":
                            Console.WriteLine("\n ******************************************************* \n");
                            Console.WriteLine(" Number of Apples  : {0}\n Number of Oranges : {1}", apple, orange);
                            totalAmount = calculate.CalculateTotal(apple, orange, applePrice, orangePrice);
                            Console.WriteLine("\n ******************************************************* \n");
                            Console.WriteLine(" Total Amount: {0}", totalAmount);
                            break;
                        default:
                            Console.WriteLine("\n ******************************************************* \n");
                            Console.WriteLine(" Number of Apples  : {0}\n Number of Oranges : {1}", apple, orange);
                            Console.WriteLine("\n ******************************************************* \n");
                            appleCountAfterOffer = offer.BuyOneGetOne(apple);
                            orangecountAfterOffer = offer.ThreeForTwo(orange);
                            totalAmount = calculate.CalculateTotal(appleCountAfterOffer, orangecountAfterOffer, applePrice, orangePrice);
                            Console.WriteLine(" Total Amount: {0}", totalAmount);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Select Valid Option");
                    goto option;
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Unable to process your request, Please try again");
            }            
        }
    }
}
