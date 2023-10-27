using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.model
{
    public class WorkshopDto
    {
        public int Id { get; set; }
        public string description { get; set; }
        public int duration { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int subscriberLimit { get; set; }
        public int tutorialId { get; set; }
        public TutorialDto tutorial { get; set; }

    }
}
