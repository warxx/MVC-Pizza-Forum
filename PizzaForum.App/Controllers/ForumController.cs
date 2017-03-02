using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.App.BindingModels;
using PizzaForum.App.Data;
using PizzaForum.App.Data.Contracts;
using PizzaForum.App.Services;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;

namespace PizzaForum.App.Controllers
{
    public class ForumController : Controller
    {
        private ForumService service;

        public ForumController()
        {
            this.service = new ForumService();
        }

        

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserBindingModel rubm, HttpResponse response)
        {
            if (!service.IsRegisterModelValid(rubm))
            {
                this.Redirect(response, "/forum/register");
                return null;
            }

            var user = service.GetUserFromModel(rubm);
            this.service.RegisterUser(user);

            this.Redirect(response, "/forum/login");
            return null;
        }
    }
}
