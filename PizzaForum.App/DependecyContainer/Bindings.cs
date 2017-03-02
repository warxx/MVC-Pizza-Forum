using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using PizzaForum.App.Data;
using PizzaForum.App.Data.Contracts;

namespace PizzaForum.App.DependecyContainer
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
