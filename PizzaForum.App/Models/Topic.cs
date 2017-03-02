using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.App.Models
{
    public class Topic
    {
        public Topic()
        {
            this.Replies = new HashSet<Reply>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? PublishDate { get; set; }

        public User Author { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }
    }
}
