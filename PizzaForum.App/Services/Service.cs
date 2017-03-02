using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using PizzaForum.App.Data;
using PizzaForum.App.Data.Contracts;
using PizzaForum.App.DependecyContainer;

namespace PizzaForum.App.Services
{
    public abstract class Service
    {

        public Service()
        {
            this.Context = DependencyKernel.Kernel.Get<IUnitOfWork>();
        }

        protected IUnitOfWork Context { get; }
    }
}
