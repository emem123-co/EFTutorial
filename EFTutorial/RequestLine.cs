using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial;
public class RequestLine
{
    public int Id { get; set;} //these two do not need a constructor because they are not FK within the RequestLine table. 
    public int Quantity { get; set;} = 1;
    
    
    public int RequestId { get; set;}
    public virtual Request? Request { get; set;} //question mark goes after the Class instance name bc that is the "type" of data technically.
    
    
    public int ProductId { get; set;}
    public virtual Product? Product { get; set;}
    
}
