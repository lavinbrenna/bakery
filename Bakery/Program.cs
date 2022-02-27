using System;


namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      int breadTotal = 0;
      int pastryTotal = 0;
      int customerLoafCount = 0;
      int customerPastryCount = 0;

      Bread welcomeBread = new Bread(1, "none");
      int welcomeBreadPrice = Bread.GetLoafPrice(welcomeBread.LoafCount);
      Pastry welcomePastry = new Pastry(1, "none");
      int welcomePastryPrice = Pastry.GetPastryPrice(welcomePastry.PastryCount);

      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We sell many kinds of breads and pastries.");
      Console.WriteLine("Bread is normally priced at $" + welcomeBreadPrice + " per loaf and pastries are $" + welcomePastryPrice + " per pastry.");
      Console.WriteLine("Today our specials are 3 pastries for $5 or buy 2 get 1 for loaves of bread");

      Console.WriteLine("What kind of bread would you like to order?");
      Console.WriteLine("Please choose one from the following options: ");
      string breadTypes = "Japanese Milk Bread(Shokupan), Brioche, Challah, Sourdough, Rye, Sunflower Seed Whole Grain";
      Console.WriteLine(breadTypes);
      string customerBreadType = Console.ReadLine().ToLower();
      Console.WriteLine("How many loaves of this kind would you like to order?");
      customerLoafCount += int.Parse(Console.ReadLine());
      Bread customerBread = new Bread(customerLoafCount, customerBreadType);
      breadTotal += Bread.GetLoafPrice(customerLoafCount);

      Console.WriteLine("What kind of pastries would you like to order?");
      Console.WriteLine("Please choose from one of the following options: ");
      string pastryTypes = "Croissant, Chocolate Croissant, Marionberry Cream Cheese Brioche, Bear Claw, Cannoli, Vanilla Cornet";
      Console.WriteLine(pastryTypes);
      string customerPastryType = Console.ReadLine().ToLower();
      Console.WriteLine("How many pastries of this kind would you like to order?");
      customerPastryCount += int.Parse(Console.ReadLine());
      Pastry customerPastry = new Pastry(customerPastryCount, customerPastryType);
      pastryTotal += Pastry.GetPastryPrice(customerPastryCount);

      Console.WriteLine("You have ordered: ");
      Console.WriteLine("<------------------------------------------------>");
      Console.WriteLine(customerBread.LoafCount + " loaf/loaves of " + customerBread.BreadType);
      Console.WriteLine(customerPastry.PastryCount + " " + customerPastry.PastryType + "(s)");

      breadTotal += pastryTotal;
      Console.WriteLine("<------------------------------------------------>");
      Console.WriteLine("Your final total is $" + breadTotal + ".00");
      Console.WriteLine("Thank you for shopping with us, have a nice day!");
      }
    }
  }




