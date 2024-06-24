using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial;
//this will allow us to READ the data in the database. Additional code needed to manage the Data.
public class User
{
    public int Id { get; set; } //no semicolon if you are not setting it equal to a value
    public string Password { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string? Phone { get; set; } = null; //question mark indicates to C# that these values can be null
    public string? Email { get; set; } //do not have to set to null because that is already the default.
    public bool IsReviewer { get; set; }
    public bool IsAdmin { get; set; }


}
