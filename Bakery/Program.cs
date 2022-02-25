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
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("We sell bread for $" + welcomeBreadPrice + " per loaf, and pastries for $" + welcomePastryPrice + " per pastry.");
        Console.WriteLine("Our specials right now are 3 pastries for $5 and Buy 2 get 1 free for loaves of bread!");
        Console.WriteLine("Would you like to buy some? (yes/no)");
        string userResponse = Console.ReadLine().ToLower();
        bool addToOrder = true;
        if (userResponse != "yes" && userResponse != "no")
        {
          addToOrder = false;
          Console.WriteLine("Please enter a valid response");

        }
        else if(userResponse == "no")
        {
          createOrder = false;
          addToOrder = false;
          Console.WriteLine("Thank you for stopping in! Have a good day!");
          break;
        }
        else
        {
          while(addToOrder == true){
            Console.WriteLine("What can we get for you?(Bread/Pastries)");
            string userOrder = Console.ReadLine().ToLower();
            bool isBread = false;
            bool isPastry = false;
            int orderTotal = 0;
            if (userOrder == "bread")
            {
              isBread = true;
              while(isBread == true)
              {
                Console.WriteLine("How many can we get for you? (Please type a number)");
                int userLoafCount = int.Parse(Console.ReadLine());
                Bread userBread = new Bread(userLoafCount);
                orderTotal += Bread.GetLoafPrice(userLoafCount);
                Console.WriteLine("Would you like to add anything else to your order?(yes/no)");
                string userContinue = Console.ReadLine().ToLower();
                if(userContinue == "yes"){
                  isBread = true;
                }
                else{
                  isBread = false;
                  addToOrder = false;
                  createOrder = false;
                  Console.WriteLine("Your total is $" + orderTotal);
                  Console.WriteLine("Thank you for stopping in! Enjoy your bread!");
                  break;
                }
              }
            }
            else if (userOrder == "pastries")
            {
              isPastry = true;
              while(isPastry == true)
              {
                Console.WriteLine("How many can we get for you? (Please type a number)");
                int userPastryCount = int.Parse(Console.ReadLine());
                Pastry userPastry = new Pastry(userPastryCount);
              }
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
}