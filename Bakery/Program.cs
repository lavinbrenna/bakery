using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      bool breadOrder = false;
      bool pastryOrder = false;
      int breadTotal = 0;
      int pastryTotal = 0;
      Bread welcomeBread = new Bread(1, "none");
      int welcomeBreadPrice = Bread.GetLoafPrice(welcomeBread.LoafCount);
      string breadTypes = "Japanese Milk Bread(Shokupan), Brioche, Challah, Sourdough, Rye, Sunflower Seed Whole Grain";
      Pastry welcomePastry = new Pastry(1, "none");
      int welcomePastryPrice = Pastry.GetPastryPrice(welcomePastry.PastryCount);
      string pastryTypes = "Croissant, Chocolate Croissant, Marionberry Cream Cheese Brioche, Bear Claw, Cannoli, Vanilla Cornet";
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We sell many kinds of breads and pastries.");
      Console.WriteLine("Bread is normally priced at $" + welcomeBreadPrice + " per loaf and pastries are $" + welcomePastryPrice + " per pastry.");
      Bread.ClearAll();
      Pastry.ClearAll();
      Console.WriteLine("Today our specials are 3 pastries for $5 or buy 2 get 1 for loaves of bread");
      Console.WriteLine("Would you like to order any bread? (yes/no)");
      string breadResponse = Console.ReadLine().ToLower();
      if (breadResponse == "yes")
      {
        breadOrder = true;
        while (breadOrder == true)
        {
          int customerLoafCount = 0;
          Console.WriteLine("Please choose one from the following options: ");
          Console.WriteLine(breadTypes);
          string customerBreadType = Console.ReadLine().ToLower();
          Console.WriteLine("How many loaves of this kind would you like to order?");
          customerLoafCount += int.Parse(Console.ReadLine());
          Bread customerBread = new Bread(customerLoafCount, customerBreadType);
          breadTotal += Bread.GetLoafPrice(customerLoafCount);
          Console.WriteLine("Would you like to add any more bread to your order?(yes/no)");
          string breadResponse2 = Console.ReadLine().ToLower();
          if (breadResponse2 == "yes")
          {
            breadOrder = true;
          }
          else
          {
            breadOrder = false;
            List<Bread> breadResult = Bread.GetAllBread();
            Console.WriteLine("You have ordered: ");
            foreach (Bread thisBread in breadResult)
            {
              Console.WriteLine(thisBread.LoafCount + " loaf/loaves of :" + thisBread.BreadType);
            }
            Console.WriteLine("Your final total is $" + breadTotal);
            Console.WriteLine("Thank you for shopping with us, have a nice day!");
            }
          }
      }
      else if (breadResponse == "no")
      {
        Console.WriteLine("Would you like to order any pastries?(yes/no)");
        string pastryResponse = Console.ReadLine().ToLower();
        if (pastryResponse == "yes")
        {
          pastryOrder = true;
          while (pastryOrder == true)
          {
            int customerPastryCount = 0;
            Console.WriteLine("Please choose from one of the following options: ");
            Console.WriteLine(pastryTypes);
            string customerPastryType = Console.ReadLine().ToLower();
            Console.WriteLine("How many pastries of this kind would you like to order?");
            customerPastryCount += int.Parse(Console.ReadLine());
            Pastry customerPastry = new Pastry(customerPastryCount, customerPastryType);
            pastryTotal += Pastry.GetPastryPrice(customerPastryCount);
            Console.WriteLine("Would you like to add any more pastries to your order?(yes/no)");
            string pastryResponse2 = Console.ReadLine().ToLower();
            if (pastryResponse2 == "yes")
            {
              pastryOrder = true;
            }
            else
            {
              pastryOrder = false;
              List<Pastry> pastryResult = Pastry.GetAllPastries();
              Console.WriteLine("You have ordered: ");
              foreach (Pastry thisPastry in pastryResult)
              {
                Console.WriteLine(thisPastry.PastryCount + ": " + thisPastry.PastryType + "(s)");
              }
              Console.WriteLine("Your final total is $" + pastryTotal);
              Console.WriteLine("Thank you for shopping with us, have a nice day!");
            }
          }
        }
        else
        {
          Console.WriteLine("Thank you for stopping by! Have a good day!");
        }
      }
    }
  }
}


