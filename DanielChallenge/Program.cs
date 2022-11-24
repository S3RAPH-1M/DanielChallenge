
using System;

var storeNumber = "";
var userName = "";
decimal BooksAmount = 0;
decimal BooksCost;
decimal TaxRate;
decimal StoredTotalCost = 0;

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

    Console.WriteLine("The total cost of your books is " + TotalCost + " From " + storeNumber + "\n");
    Console.WriteLine("Thank you for shopping with us\n");
    goto start;
}
else if (userOption == "cart")
{
    if (StoredTotalCost != 0)
    {
        Console.WriteLine("What store did you purchase from?\n");
        var CartChecker = Console.ReadLine();
        if (CartChecker == storeNumber)
        {
            Console.WriteLine("Your most recent purchase was " + BooksAmount + " Books for the total price of " + StoredTotalCost + " from " + storeNumber + "\n");
            Console.WriteLine("Thank you for shopping with us");
            goto start;
        }
        else if (CartChecker != storeNumber)
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
        Console.WriteLine("What is the name of the person you want to see the purchase history of?\n");
        var HistoryChecker = Console.ReadLine();
        if (userNames.Contains(HistoryChecker))
        {
            var index = userNames.IndexOf(HistoryChecker);
            Console.WriteLine("The purchase history of " + HistoryChecker + " is " + BooksAmounts[index] + " Books for the total price of " + StoredTotalCosts[index] + " from " + storeNumbers[index] + "\n");
            Console.WriteLine("Thank you for shopping with us");
            goto start;
        }
        else if (!userNames.Contains(HistoryChecker))
        {
            Console.WriteLine("There are no purchases from that user recently.\n");
            goto start;

        }

    }

    Console.WriteLine("There are no purchases anywhere. Stop being poor and get that Economy up.\n");
    goto start;
}
if (userOption != "cart" || userOption != "purchase" || userOption != "history")
{
    Console.WriteLine("\n\nPlease type purchase or cart");
    goto typedsomethingsilly;
}
