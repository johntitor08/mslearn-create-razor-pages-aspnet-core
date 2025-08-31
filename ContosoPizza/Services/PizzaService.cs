using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public class PizzaService(PizzaContext context)
    {
        private readonly PizzaContext _context = context;

        public IList<Pizza> GetPizzas()
        {
            if (_context.Pizzas != null)
            {
                return [.. _context.Pizzas];
            }
            return [];
        }

        public void AddPizza(Pizza pizza)
        {
            if (_context.Pizzas != null)
            {
                _context.Pizzas.Add(pizza);
                _context.SaveChanges();
            }
        }

        public void DeletePizza(int id)
        {
            if (_context.Pizzas != null)
            {
                var pizza = _context.Pizzas.Find(id);
                if (pizza != null)
                {
                    _context.Pizzas.Remove(pizza);
                    _context.SaveChanges();
                }
            }
        }
    }
}
