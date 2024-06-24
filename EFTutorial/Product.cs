using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial;
public class Product
{
    public int Id { get; set;}
    public string PartNbr { get; set;} = string.Empty;
    public string Name { get; set;} = string.Empty;
    public decimal Price { get; set;}
    public string Unit { get; set;} = string.Empty;
    public string? PhotoPath { get; set;} = string.Empty;

    public int VendorId { get; set;} //this property is the only property that will tie a product to the vendor. 
    public virtual Vendor? Vendor { get; set; } //this will retrieve an instance of Vendor when you read data from Product (because VendorId is the FK pointing to Product). You want to make this nullable because you dont want to have to put an instance of Vendor every time you want to insert, update or delete. By reading one product, I can display the vendor AND the product. 
    // "virtual" indicates that this property is not in the database, it is only in the class. 
    //if you ever want to access the foreign key information, you have to have include an instance of the class/table that the FK points to. 

}
