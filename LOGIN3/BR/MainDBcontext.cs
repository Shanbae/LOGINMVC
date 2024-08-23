using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LOGIN3.BR
{
    public class MainDBcontext: DbContext
    {

        public MainDBcontext():base("name=DefaultConnection") { }

       // public DbSet<Item> Items { get; set; }
    }
}