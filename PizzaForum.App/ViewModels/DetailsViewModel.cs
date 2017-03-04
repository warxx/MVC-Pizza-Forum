using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.Appp.ViewModels
{
    public class DetailsViewModel
    {
        public int TopicId { get; set; }

        public DetailTopicViewModel TopicVM { get; set; }

        public IEnumerable<DetailsReplyViewModel> RepliesVM { get; set; }
    }
}
