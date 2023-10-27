using BL.managers;
using models.model;

namespace API.Controllers
{
    [ExtendObjectType("Mutation")]
    public class WorkshopMutation
    {
        private WorkshopManager _manager;

        public WorkshopMutation(WorkshopManager manager)
        {
            _manager = manager;
        }
        
        public Workshop AdWorkshop(Workshop workshop) {
            _manager.Add(workshop);
            return workshop;
        }
    }
}
