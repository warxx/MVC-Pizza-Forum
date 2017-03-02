﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.App.Models
{
    public class Category
    {
        public Category()
        {
            this.Topics = new HashSet<Topic>();
        }

        public int Id { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
    }
}
