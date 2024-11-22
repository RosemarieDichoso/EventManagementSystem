using EventManagementSystem.Data;
using EventManagementSystem.Models;


namespace EventManagementSystem.DAO
{
    public class EventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<EventItem> GetAllEvent()
        {
            return _context.EventItems.ToList();
        }

        public EventItem GetEventById(int id)
        {
            return _context.EventItems.Find(id);
        }

        public void AddEvent(EventItem eventItem)
        {
            _context.EventItems.Add(eventItem);
            _context.SaveChanges();
        }
        public void UpdateEvent(EventItem eventItem)
        {
            _context.EventItems.Update(eventItem);
            _context.SaveChanges();
        }
        public void DeleteEvent(int id)
        {
            var foundEvent = _context.EventItems.Find(id);
            if (foundEvent != null)
            {
                _context.EventItems.Remove(foundEvent);
                _context.SaveChanges();
            }
        }
    }
}
