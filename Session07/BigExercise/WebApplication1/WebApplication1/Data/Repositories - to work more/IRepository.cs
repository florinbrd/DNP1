using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data.Repositories
{
    public interface IRepository
    {
        public void create(Order order);

        public void sellcat(Order order, Cat cat);

        IEnumerable getorders();

        Order FindbyId(int id); 
    }
}