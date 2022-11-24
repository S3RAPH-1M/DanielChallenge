
using System;

var LaststoreNumber = "";
var LastuserName = "";
decimal LastStoredTotalCost = 0;
decimal LastBooksAmount = 0;
decimal lastBooksCost;
decimal lastTaxRate;

List<string> storeNumbers = new List<string>();
List<string> userNames = new List<string>();
List<string> BooksAmounts = new List<string>();
List<string> BooksCosts = new List<string>();
List<string> TaxRates = new List<string>();
List<string> StoredTotalCosts = new List<string>();

start:
Console.WriteLine("Hello & Welcome To Daniel's Book Store");
typedsomethingsilly:
Console.WriteLine("What would you want to do today? To Purchase Items type 'purchase'.  or to view your cart type 'cart'.\n\nTo show someones purchase history. Type 'history'");



var userOption = Console.ReadLine();
if (userOption == "purchase")
{
    var storeNumber = "";
    var userName = "";
    decimal BooksAmount = 0;
    decimal BooksCost;
    decimal TaxRate;
    decimal StoredTotalCost = 0;

    StoreCheck:
    Console.WriteLine("What store would you like to purchase from?\n");
    storeNumber = Console.ReadLine();
    if (string.IsNullOrEmpty(storeNumber))
    {
        Console.WriteLine("Please enter a store");
        goto StoreCheck;
    }
    storeNumbers.Add(storeNumber!);


    NameCheck:
    Console.WriteLine("What is your name?\n");
    userName = Console.ReadLine();
    if (string.IsNullOrEmpty(userName))
    {
        Console.WriteLine("Please enter a name");
        goto NameCheck;
    }
    userNames.Add(userName!);



    Console.WriteLine("How many books would you like to buy?\n");
    decimal BooksAmountNumber = Convert.ToDecimal(Console.ReadLine());
    BooksAmount = BooksAmount + BooksAmountNumber;
    BooksAmounts.Add(BooksAmount.ToString());

    Console.WriteLine("What is the price of the books?\n");
    decimal BooksCostNumber = Convert.ToDecimal(Console.ReadLine());
    BooksCost = BooksCostNumber;
    BooksCosts.Add(BooksCost.ToString());

    Console.WriteLine("What is the tax rate in your area?\n");
    decimal TaxRateNumber = Convert.ToDecimal(Console.ReadLine());
    TaxRate = TaxRateNumber;
    TaxRates.Add(TaxRate.ToString());


    var TotalCost = BooksAmount * BooksCost * (1 + (TaxRate / 100));
    StoredTotalCost = TotalCost;
    StoredTotalCosts.Add(StoredTotalCost.ToString());

    LastBooksAmount = BooksAmount;
    lastBooksCost = BooksCost;
    lastTaxRate = TaxRate;
    LastStoredTotalCost = StoredTotalCost;
    LastuserName = userName;

    Console.WriteLine("The total cost of your books is " + TotalCost + " From " + storeNumber + "\n");
    Console.WriteLine("Thank you for shopping with us\n");
    goto start;
}
else if (userOption == "cart")
{
    if (LastStoredTotalCost != 0)
    {
        Console.WriteLine("What is your name?\n");
        var CartChecker = Console.ReadLine();
        if (CartChecker == LastuserName)
        {
            Console.WriteLine("Your most recent purchase was " + LastBooksAmount + " Books for the total price of " + LastStoredTotalCost + " from " + LaststoreNumber + "\n");
            Console.WriteLine("Thank you for shopping with us");
            goto start;
        }
        else if (CartChecker != LaststoreNumber)
        {
            Console.WriteLine("There are no purchases within that store recently.\n");
        }

    }
    Console.WriteLine("You havent made a purchase!\n\n");
    goto start;
}
else if (userOption == "history")
{
    if (userNames.Count != 0)
    {
        Console.WriteLine("What is the name of the user you would like to see?\n");
        var userHistory = Console.ReadLine();
        if (userNames.Contains(userHistory))
        {
            Console.WriteLine("Here is the purchase history of " + userHistory + "\n\n");
            for (int i = 0; i < userNames.Count; i++)
            {
                if (userNames[i] == userHistory)
                {
                    Console.WriteLine("The purchase of " + BooksAmounts[i] + " books for the total cost of " + StoredTotalCosts[i] + " from " + storeNumbers[i] + "\n");
                }
            }
            goto start;
        }
        else if (userNames.Contains(userHistory) == false)
        {
            Console.WriteLine("That user does not exist\n");
            goto start;
        }
    }
    else if (userNames.Count == 0)
    {
        Console.WriteLine("There are no purchases to show\n");
        goto start;

    }

    Console.WriteLine("There are no purchases anywhere. Stop being poor and get that Economy up.\n");
    goto start;
}
if (userOption != "cart" || userOption != "purchase" || userOption != "history")
{
    Console.WriteLine("\n\nPlease type purchase or cart");
    goto typedsomethingsilly;
}
