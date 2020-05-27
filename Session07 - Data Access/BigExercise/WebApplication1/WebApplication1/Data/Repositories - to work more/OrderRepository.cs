using System.Collections;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;
using WebApplication1.Data.Entities.Context;

namespace WebApplication1.Data.Repositories
{
    public class OrderRepository : IRepository
    {
        CatContext context = new CatContext();

        public void create(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void sellcat(Order order, Cat cat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable getorders()
        {
            return context.Orders;
        }

        public Order FindbyId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}