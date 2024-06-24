using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace EFTutorial;


internal class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext(); //instance of context class. Use it to access the tables in the database. 

     //Users is the variable name that was created in the context class. This adds it to a list. 
        /*var users = context.Users.ToList();
        foreach(var user in users)
        {
            Console.WriteLine($"{user.Firstname} {user.Lastname}");
        }*/
        
     //PRINT VENDORS
        //var vendors = context.Vendors.ToList(); //Users is the variable name that was created in the context class. This adds it to a list. 
        /*foreach(var vendor in vendors)
        {
            Console.WriteLine($"{vendor.Name} {vendor.Code}");
        }*/
     
                                            //OR you can do the below. This is part of Linq that creates a foreach loop shortcut:
        /*vendors.ForEach( v=> Console.WriteLine($"{v.Name} {v.Code}"));*/

     //PRODUCTS 
        /*var products = context.Products.Include(x=> x.Vendor).ToList(); //be sure to add the "Include()" statement here that adds the class instance of the table that the foreign key points to so you can access the that other table's data when you access this one. 
      
        products.ForEach( p=> Console.WriteLine($"PRODUCT NAME/VENDOR/VENDOR ID: {p.Name} {p.Vendor!.Name} {p.Vendor!.Id}")); //this is "p.Vendor" because the Vendor instance is within the Product class. It is telling it to access the product class (p.), read the data AND produce data from the Vendor class. "!" indicates the value being called from the Vendor class is NOT null. This is included beacause in the Product class, the instance of Vendor CAN be null. We did that so we don't HAVE to include an instance of Vendor every time we read the data from the Product class. However, including the instance of the Vendor class in the Product class allows us to do so if needed. */

     //REQUESTS
        var requests = context.Requests.Include(x=> x.User).ToList();

        requests.ForEach(r=> Console.WriteLine($"{r.Description} | {r.User!.Id}"));
        
    //REQUEST LINES
        var requestLines = context.RequestLines.Include(y=> y.Request).Include(y=> y.Product).ToList(); //whatever you choose to make the variable name at the beginning of this code is the same variable you must use when writing the foreach loop below to access the ___ of RequestLines that you created in the AppDbContext class.

        requestLines.ForEach(requestLines=> Console.WriteLine($"{requestLines.Request!.Id} | {requestLines.Request!.Description} | {requestLines.Quantity} | {requestLines.Product!.Name} | {requestLines.Product!.Price:C} {requestLines.Quantity} * {requestLines.Product!.Price:C}"));

        var total = context.RequestLines.Include(y=> y.Product).Sum(y=> y.Quantity * y.Product!.Price);
        Console.WriteLine($"Total: {total:C}");
    }
} //end of Program class
