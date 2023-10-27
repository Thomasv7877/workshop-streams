using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.model
{
    public class TutorialDto
    {
        public int Id { get; set; }
        public string description { get; set; }
        public TutorialType tutorialType { get; set; }
        public List<TutorialStepDto> steps { get; set; }
    }
}
