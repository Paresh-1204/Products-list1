//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

List<Product> lstproducts = new List<Product>();




lstproducts.Add(new Product
{
    ProductId = 1,
    ProductType = "Electronics",
    BrandName = "Philips",
    Price = 500,
    DiscountPrice = 250,
});
lstproducts.Add(new Product
{
    ProductId = 2,
    ProductType = "Electronics",
    BrandName = "Jayant",
    Price = 200,
    DiscountPrice = 150,
});

lstproducts.Add(new Product
{
    ProductId = 3,
    ProductType = "Electronics",
    BrandName = "Paras",
    Price = 700,
    DiscountPrice = 250,
});

lstproducts.Add(new Product
{
    ProductId = 4,
    ProductType = "Bakery",
    BrandName = "Paras",
    Price = 700,
    DiscountPrice = 45,
});

lstproducts.Add(new Product
{
    ProductId = 5,
    ProductType = "Bakery",
    BrandName = " Bhargav Bakery",
    Price = 900,
    DiscountPrice = 200,
});

lstproducts.Add(new Product
{
    ProductId = 6,
    ProductType = "Bakery",
    BrandName = "Indian Bakery",
    Price = 620,
    DiscountPrice = 50,
});

lstproducts.Add(new Product
{
    ProductId = 7,
    ProductType = "Grocery",
    BrandName = "Vidhya ",
    Price = 523,
    DiscountPrice = 23,
});

lstproducts.Add(new Product
{
    ProductId = 8,
    ProductType = "Grocery",
    BrandName = "BSC Grocerry ",
    Price = 150,
    DiscountPrice = 30,
});

lstproducts.Add(new Product
{
    ProductId = 9,
    ProductType = "Grocery",
    BrandName = "Bajarand",
    Price = 100,
    DiscountPrice = 30,
});

lstproducts.Add(new Product
{
    ProductId = 10,
    ProductType = "Grocery",
    BrandName = "Bhavan",
    Price = 50,
    DiscountPrice = 10,

});



Console.WriteLine("Count Of Total Product " + lstproducts.Count());
Console.WriteLine("Count Of Electronics Product " + lstproducts.Where(X=>X.ProductType=="Electronics").Count());
Console.WriteLine("Maximum Discount " + lstproducts.Max(p => p.DiscountPrice));
Console.WriteLine("Minimum Price Of Grocery " + lstproducts.Where(p => p.ProductType == "Grocery").Min(p => p.Price));
Console.WriteLine("Get ProductType By BradName " + lstproducts.Where(p => p.BrandName=="Bhavan").Select(p => p.ProductType).FirstOrDefault());
Console.WriteLine("Get Total Of Brand Count " + lstproducts.Select(p => p.BrandName).Distinct().Count());
Console.WriteLine("Get Maximum Price By Brand " + lstproducts.Where(p => p.BrandName== "Paras").Max(p => p.Price));
Console.WriteLine("Find Last Record Of Electronics Product Type" + lstproducts.Where(p => p.ProductType == "Electronics").LastOrDefault());

Console.WriteLine("Get Maximum Price By Brand " + lstproducts.Max(p => p.Price));


public class Product
{

    public int ProductId;
    public string ProductType;
    public string BrandName;
    public int Price;
    public int DiscountPrice;

    public override string ToString()
    {
        return $"ProductId:{ProductId},ProductType:{ProductType},BrandName={BrandName}, Price:{Price}, DiscountPrice:{DiscountPrice}";
    }

};




