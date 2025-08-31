using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data
{
    public class PizzaContext(DbContextOptions<PizzaContext> options) : DbContext(options)
    {
        public DbSet<Models.Pizza>? Pizzas { get; set; }
    }
}
