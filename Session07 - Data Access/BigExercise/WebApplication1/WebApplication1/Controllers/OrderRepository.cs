using WebApplication1.Data.Entities;

namespace WebApplication1.Controllers
{
    public class OrderRepository
    {
        public Cat cat;
        public Order order;

        public OrderRepository(Cat cat, Order order)
        {
            this.cat = cat;
            this.order = order; 
        }

        public void sellCat(Cat cat, Order order)
        {
            order.Cats.Add(cat);
        }
    }
}