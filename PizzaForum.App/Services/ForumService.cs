using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PizzaForum.App.BindingModels;
using PizzaForum.App.Data.Contracts;
using PizzaForum.App.Models;

namespace PizzaForum.App.Services
{
    public class ForumService : Service
    {

        public bool IsRegisterModelValid(RegisterUserBindingModel model)
        {
            if (model.Username.Length < 3)
                return false;

            var nameRegex = new Regex("^[a-z0-9]+$");
            if (!nameRegex.IsMatch(model.Username))
                return false;

            if (!model.Email.Contains("@"))
                return false;

            var passRegex = new Regex("^[0-9]{4}$");
            if (!passRegex.IsMatch(model.Password))
                return false;

            if (model.Password != model.ConfirmPassword)
                return false;

            if (this.Context.Users.Any(u => u.Username == model.Username || u.Email == model.Email))
                return false;

            return true;
        }

        public User GetUserFromModel(RegisterUserBindingModel model)
        {
            var user = new User()
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                IsAdmin = false
            };

            return user;
        }

        public void RegisterUser(User user)
        {
            if (this.Context.Users.Count() == 0)
            {
                user.IsAdmin = true;
            }

            this.Context.Users.Add(user);
            this.Context.SaveChanges();
        }
    }
}
