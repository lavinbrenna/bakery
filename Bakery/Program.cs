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
      Console.WriteLine("Bread is normally priced at $"+ welcomeBreadPrice + " per loaf and pastries are $"+ welcomePastryPrice+ "per pastry.");
      Bread.ClearAll();
      Pastry.ClearAll();
      Console.WriteLine("Today our specials are 3 pastries for $5 or buy 2 get 1 for loaves of bread");
      Console.WriteLine("Would you like to order bread or pastries? (bread/pastries)");
      string orderType = Console.ReadLine().ToLower();
      if(orderType == "bread")
      {
        breadOrder = true;
        while(breadOrder == true)
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
          string breadResponse = Console.ReadLine().ToLower();
          if(breadResponse == "yes")
          {
            breadOrder = true;
          }
          else
          {
            breadOrder = false;
            List<Bread> result = Bread.GetAllBread();
            foreach(Bread thisBread in result)
            {
              Console.WriteLine(thisBread.BreadType);
            }
              Console.WriteLine("Your bread total is $" + breadTotal);
              break;
          }
        }
      }
      else if(orderType == "pastries")
      {
        pastryOrder = true;
        while(pastryOrder == true)
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
          string pastryResponse = Console.ReadLine().ToLower();
          if(pastryResponse == "yes"){
            pastryOrder = true;
          }
          else{
            pastryOrder = false;
            List<Pastry> result = Pastry.GetAllPastries();
            foreach(Pastry thisPastry in result)
            {
              Console.WriteLine(thisPastry.PastryType);
            }
            Console.WriteLine("Your pastry total is $" + pastryTotal);
            break;
          }
        }
      }
      else
      {
        Console.WriteLine("I'm sorry, please enter a valid response");
      }
      Console.WriteLine("Your final order total is: $" + breadTotal + pastryTotal);
      Console.WriteLine("Thank you for ordering with us! Have a nice day!");
    }
  }
}
