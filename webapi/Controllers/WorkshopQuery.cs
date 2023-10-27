using BL.managers;
using models.model;

namespace API.Controllers
{
    [ExtendObjectType("Query")]
    public class WorkshopQuery
    {
        private WorkshopManager _manager;

        public WorkshopQuery(WorkshopManager manager)
        {
            _manager = manager;
        }

        public List<Workshop> GetAllWorkshops()
        {
            return _manager.GetAll();
        }
        public Workshop GetWorkshop(int id)
        {
            return _manager.GetById(id);
        }
    }
}
