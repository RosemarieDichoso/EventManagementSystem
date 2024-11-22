using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Models;
using EventManagementSystem.Services;

namespace EventManagementSystem.Controllers
{
    public class EventController
    {
        private readonly EventService _eventService;

        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }

        public List<EventItem> GetAllEvent()
        {
            return _eventService.GetAllEvent();
        }

        public EventItem GetEventById(int id)
        {
            return _eventService.GetEventById(id);
        }

        public void AddEvent(string eventName, string eventDescription, string status)
        {
            var eventItem = new EventItem
            {
                EventName = eventName,
                EventDescription = eventDescription,
                Status = status
            };
            _eventService.AddEvent(eventItem);
        }

        public void UpdateEvent(int id, string eventName, string eventDescription, string status)
        {
            var eventItem = _eventService.GetEventById(id);
            if (eventItem != null)
            {
                eventItem.EventName = eventName;
                eventItem.EventDescription = eventDescription;
                eventItem.Status = status;
                _eventService.UpdateEvent(eventItem);
            }
        }

        public void DeleteEvent(int id)
        {
            _eventService.DeleteEvent(id);
        }
    }
}
