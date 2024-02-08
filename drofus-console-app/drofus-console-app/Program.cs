using drofus_console_app;

Console.WriteLine("Welcome to Daniel's Vending Machine, please choose one of the following options:");
Console.WriteLine("*** Type 'list' to show available products");
Console.WriteLine("*** Type 'insert' followed by an amount to insert currency");
Console.WriteLine("*** Type 'recall' to return your inserted currency");
Console.WriteLine("*** Type 'order' followed by the product you wish to purchase");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Please make your selection from the options listed at the top :-)");
    Console.WriteLine();

    VendingMachine vendingMachine = new VendingMachine();

    var userInput = Console.ReadLine();

    if(userInput != null)
    {
        if (userInput.IndexOf("list", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            vendingMachine.ListProducts();
        }
        else if (userInput.IndexOf("insert", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            vendingMachine.InsertMoney(userInput);
        }
        else if (userInput.IndexOf("recall", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            vendingMachine.RecallMoney();
        }
        else if (userInput.IndexOf("order", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            vendingMachine.OrderProduct(userInput);
        }
        else if (userInput.IndexOf("fillstock", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            vendingMachine.FillStock(userInput);
        }
    }
}
