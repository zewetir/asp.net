using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options)
           : base(options)
        {
        }   
      /**  public static DataContext GetDataContext()
        {
            
          var  optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=MoneyM;Integrated Security=True;Pooling=False",
                b => b.UseRowNumberForPaging());
           var dataContext = new DataContext(optionsBuilder.Options);
            return dataContext;


        }*/
        public DbSet<Register> Users { get; set; }

    }
}
