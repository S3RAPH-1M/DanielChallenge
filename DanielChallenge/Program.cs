
var storeNumber = "";
decimal BooksAmount = 0;
decimal BooksCost;
decimal TaxRate;
decimal StoredTotalCost = 0;
start:
Console.WriteLine("Hello & Welcome To Daniel's Book Store");
typedsomethingsilly:
Console.WriteLine("What would you want to do today? To Purchase Items type 'purchase'.  or to view your cart type 'cart'");
Console.WriteLine("");



var userOption = Console.ReadLine();
while (userOption == "purchase")
{
    Console.WriteLine("");
    Console.WriteLine("What store would you like to purchase from?");
    storeNumber = storeNumber + Console.ReadLine();

    Console.WriteLine("");
    Console.WriteLine("How many books would you like to buy?");
    var BooksTempAmount = Console.ReadLine();
    decimal BooksAmountNumber = Convert.ToDecimal(BooksTempAmount);
    BooksAmount = BooksAmount + BooksAmountNumber;

    Console.WriteLine("");
    Console.WriteLine("What is the price of the books?");
    var BooksCostTemp = Console.ReadLine();
    decimal BooksCostNumber = Convert.ToDecimal(BooksCostTemp);
    BooksCost = BooksCostNumber;

    Console.WriteLine("");
    Console.WriteLine("What is the tax rate in your area?");
    var TaxRateTemp = Console.ReadLine();
    decimal TaxRateNumber = Convert.ToDecimal(TaxRateTemp);
    TaxRate = TaxRateNumber;


    var TotalCost = BooksAmount * BooksCost * (1 + (TaxRate / 100));
    StoredTotalCost = TotalCost;

    Console.WriteLine("");
    Console.WriteLine("The total cost of your books is " + TotalCost + " From " + storeNumber);
    Console.WriteLine("Thank you for shopping with us");
    goto start;
}
while (userOption == "cart")
{
    if (StoredTotalCost != 0)
    {
        Console.WriteLine("What store did you purchase from?");
        var CartChecker = Console.ReadLine();
        if (CartChecker == storeNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Your most recent purchase was " + BooksAmount + " Books for the total price of " + StoredTotalCost + " from " + storeNumber);
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            goto start;
        }
        else if (CartChecker != storeNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("There are no purchases within that store recently.");
        }

    }
    Console.WriteLine("You havent made a purchase!");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    goto start;
}
if (userOption != "cart" || userOption != "purchase")
{
    Console.WriteLine("");
    Console.WriteLine("Please type purchase or cart");
    goto typedsomethingsilly;
}
