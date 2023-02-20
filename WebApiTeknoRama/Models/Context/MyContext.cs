using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiTeknoRama.Models.Entities;
using WebApiTeknoRama.Models.Init;

namespace WebApiTeknoRama.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        public DbSet<CardInfo> Cards { get; set; }
    }
}