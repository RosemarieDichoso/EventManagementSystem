using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
    public class EventItem
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string Status { get; set; }
    }
}
