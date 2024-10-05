using System;

namespace ASS2Assignment1
{
    class Fish
    {
        public string Species { get; set; }
        public double PricePerFish { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the species to buy:");
            Console.ReadLine();
            Console.WriteLine("enter the price per fish :");
            Console.ReadLine();
            Console.WriteLine("enter the fishes you want to buy:");
            Console.ReadLine();
            FishUtility fishUtility = new FishUtility();
            fishUtility.AddFish("ClownFish", 50);
            fishUtility.BuyFish();
            double totalprice=fishUtility.CalculatePrice(35);
            Console.WriteLine(totalprice);
        }
    }
    class FishUtility : Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;



        }
        public bool BuyFish()
        {
            if (Species == "ClownFish" || Species == "GoldFish")
                return true;
            else
                Console.WriteLine("{Species}is not found");
            return false;

        }
        public double CalculatePrice(int numberOfFishes)
        {
            int additionalcharges = 0;
            if (Species == "ClownFish")
            {
                additionalcharges = 100;
            }

            else if (Species == "GoldFish")
            {
                additionalcharges = 150;

            }
                return numberOfFishes * PricePerFish + additionalcharges;
            
        }
    }
}



    

