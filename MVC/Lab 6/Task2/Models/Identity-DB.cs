using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task2.Models
{
    public class Identity_DB : DbContext
    {
        public Identity_DB() :base("myConn")
        {

        }
        public DbSet<Client> Clients { get; set; }  


    }
}