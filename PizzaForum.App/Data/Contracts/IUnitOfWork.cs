using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.App.Models;

namespace PizzaForum.App.Data.Contracts
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }

        IRepository<Category> Categories { get; }

        IRepository<Topic> Topics { get; }

        IRepository<Reply> Replies { get; }

        int SaveChanges();
    }
}
