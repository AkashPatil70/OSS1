using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using Day_11.Models;

namespace Day_11.DAL
{
    [DbConfigurationType (typeof(MySqlEFConfiguration))]
    public class DbOrmContext : DbContext //derived from DbContext
    {
       public DbSet<Product> products { get; set; }
        public DbOrmContext() :base("WebAppCon")
        {

        }

    }
}