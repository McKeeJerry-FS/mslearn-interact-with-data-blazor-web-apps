using System;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
  public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options)
      : base(options)
  {
  }

  public DbSet<PizzaSpecial> Specials { get; set; }
  
}
