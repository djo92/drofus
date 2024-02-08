namespace drofus_console_app
{
    public class VendingMachine
    {
        private List<Item> items { get; }

        private static int creditCounter { get; set; }

        public VendingMachine()
        {

            items = new List<Item>()
            {
                new Item("Cola", 30),
                new Item("Fanta", 30),
                new Item("Sprite", 30),
                new Item("Pepsi-max", 30),
                new Item("Potetgull", 38),
                new Item("Firkløver", 35),
                new Item("Melkesjokolade", 35),
                new Item("Urge", 30),
                new Item("Grandiosa Pepperoni", 60),
                new Item("Smash", 40)
            };
        }

        public void ListProducts()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Price} NOK");
            }
        }

        public void InsertMoney(string input)
        {
            //Assumes that the input will always be written in the correct format: insert x
            string[] parts = input.Split(' ');

            if (int.TryParse(parts[1], out int number))
            {
                creditCounter += number;
                Console.WriteLine($"Current credit is {creditCounter}");
            }
            else
            {
                Console.WriteLine("Error: Invalid number format.");
            }
        }

        public void RecallMoney()
        {
            Console.WriteLine($"Giving out {creditCounter}");
            creditCounter = 0;
        }

        public void OrderProduct(string input)
        {
            //Assumes that user will order something that is on the vending machine "menu"
            string[] parts = input.Split(new[] { ' ' }, 2, StringSplitOptions.None);

            Item foundItem = items.FirstOrDefault(item => item.Name.Equals(parts[1], StringComparison.OrdinalIgnoreCase));

            if (foundItem.Price > creditCounter)
            {
                var priceDifference = foundItem.Price - creditCounter;
                Console.WriteLine($"Not enough credit need {priceDifference} more");
            }
            else
            {
                var change = creditCounter - foundItem.Price;
                Console.WriteLine($"Giving out {foundItem.Name}. Giving back change of {change}");
            }
        }

        public void FillStock(string product)
        {
            //Bit unsure what this method is supposed to do. 
            //Perhaps item class should cointain a third parameter, quantity?
            //And this method would increase the quantity for said product
        }
    }
}

