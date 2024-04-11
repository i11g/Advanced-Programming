string command = Console.ReadLine(); 

Dictionary<string,List<double>> products= new Dictionary<string,List<double>>();

while(command!="buy")
{
    string[] productInfo = command.Split(' ').ToArray();

    string productName = productInfo[0];
   double productPrice = double.Parse(productInfo[1]);
    double productQuantity = double.Parse(productInfo[2]);
        
    if(!products.ContainsKey(productName)) 
    { 
        products.Add(productName,new List<double>());
        products[productName].Add(productPrice);
        products[productName].Add(productQuantity);

    }
    else
    {
        products[productName][0] = productPrice;
        products[productName][1] += productQuantity;
    }
    
    command = Console.ReadLine();
}

foreach (var product in products)
{
    double totalPrice = product.Value[0] * product.Value[1];
    Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
}


