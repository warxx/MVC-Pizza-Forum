using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.App.Data;
using PizzaForum.App.Data.Contracts;
using PizzaForum.App.Models;
using SimpleHttpServer.Models;

namespace PizzaForum.App.Utillities
{
    public class AuthenticationManager
    {
        private static IUnitOfWork data = new UnitOfWork();

        //public static User IsAuthenticated(HttpSession session)
        //{
        //    var login = data.
        //}
    }
}
