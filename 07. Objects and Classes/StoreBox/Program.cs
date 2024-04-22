namespace StoreBox
{  

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }

        public int ItemQuantity { get; set; } 

        public decimal PriceForABox { get; set; }

        public Box(int serialNumber,Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForABox = item.Price * itemQuantity;
        }
    }

    
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>(); 

            while(input!="end")
            {
                string[] boxInfo = input.Split(" ");
                int serialNumber = int.Parse(boxInfo[0]);
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, itemPrice);

                Box currrentBox = new Box(serialNumber, item, itemQuantity)
                {
                    
                };

                boxes.Add(currrentBox);

                input = Console.ReadLine();
            }

            var decendingBoxes = boxes.OrderByDescending(box => box.PriceForABox).ToList();
            foreach(Box box in decendingBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"--{box.Item.Name} – {box.Item.Price:F2}: {box.ItemQuantity}" );
                Console.WriteLine($"--${box.PriceForABox:F2}");
            }
        }
    }
}
