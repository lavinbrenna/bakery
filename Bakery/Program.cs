using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      bool createOrder = true;
      while (createOrder == true)
      {
        Bread welcomeBread = new Bread(1);
        int welcomeBreadPrice = Bread.GetLoafPrice(welcomeBread.LoafCount);
        Pastry welcomePastry = new Pastry(1);
        int welcomePastryPrice = Pastry.GetPastryPrice(welcomePastry.PastryCount);
        Console.WriteLine("Welcome to Pierre's Bakery! We sell bread for $" + welcomeBreadPrice + " per loaf, and pastries for $" + welcomePastryPrice + " per pastry. Would you like to buy some? (yes/no)");
        string userResponse = Console.ReadLine().ToLower();
        if (userResponse != "yes" && userResponse != "no")
        {
          Console.WriteLine("Please enter a valid response");
        }
        else if(userResponse == "no")
        {
          createOrder = false;
          Console.WriteLine("Thank you for stopping in! Have a good day!");
        }
        else
        {
          Console.WriteLine("What can we get for you?(Bread/Pastries)");
          string userOrder = Console.ReadLine().ToLower();
          if (userOrder == "bread")
          {
            Console.WriteLine("How many can we get for you? (Please type a number)");
            int userLoafCount = int.Parse(Console.ReadLine());
            Bread userBread = new Bread(userLoafCount);
            int orderTotal = Bread.GetLoafPrice(userLoafCount);
            Console.WriteLine("Your total is $" + orderTotal);
            Console.WriteLine("Would you like to add anything else to your order?");
            string userResponse2 = Console.ReadLine().toLower();
          }
          else if (userOrder == "pastries")
          {
            Console.WriteLine("How many can we get for you? (Please type a number)");
            int userPastryCount = int.Parse(Console.ReadLine());
            Pastry userPastry = new Pastry(userPastryCount);
          }
          else
          {
            Console.WriteLine("Please enter a valid response");
          }
        }
      }
    }
  }
}