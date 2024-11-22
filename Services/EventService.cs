using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.DAO;
using EventManagementSystem.Models;

namespace EventManagementSystem.Services
{
    public class EventService
    {
        private readonly EventRepository _eventRepository;
        public EventService(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public List<EventItem> GetAllEvent()
        {
            return _eventRepository.GetAllEvent();
        }
        public EventItem GetEventById(int id)
        {
            return _eventRepository.GetEventById(id);
        }
        public void AddEvent(EventItem eventItem)
        {
            _eventRepository.AddEvent(eventItem);
        }
        public void DeleteEvent(int id)
        {
            _eventRepository.DeleteEvent(id);
        }
        public void UpdateEvent(EventItem eventItem)
        {
            _eventRepository.UpdateEvent(eventItem);
        }
    }
}
