using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial;
//each app will have a "Context" class that is needed for Entity Framework. It tells the app which Db its allowed to access. 

// 1 - inherit app called DbContext so that "using Microsoft.EntitFrameworkCore is added to the top of this class. 


public class AppDbContext : DbContext {
    
    public DbSet<User> Users { get; set;} //in this program, EFTutorial will be able to access the table Users, and nothing else. You can add more tables you want to access here.100% of the time you will use the Context class to access tables within the program (EFTutorial). This creates a class named "Users" that will allow you access the columns and rows of this table within your program file. 
    public DbSet<Vendor> Vendors { get; set;}
    public DbSet<Product> Products { get; set;}
    public DbSet<Request> Requests { get; set;}
    public DbSet<RequestLine> RequestLines { get; set;} //green is the class name, "RequestLines" 

    public AppDbContext() {} //this is a default constructor. dont have to inherit the base. 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //
    {
        var connectionString = "server=localhost\\sqlexpress01;" + //instance of sql
                               "database=tqlprsdb;" + //database name
                               "trusted_connection=true;" + //authentication for connection
                               "trustServerCertificate=true;"; 
        optionsBuilder.UseSqlServer(connectionString);
    }
}
