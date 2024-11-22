using EventManagementSystem.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManagementSystem.Controllers;
using EventManagementSystem.DAO;
using EventManagementSystem.Models;
using EventManagementSystem.Services;
using System.Xml.Linq;


namespace EventManagementSystem.Forms
{
    public partial class UpdateEventForm : Form
    {
        private readonly EventController _eventController;
        public event Action<EventItem> EventUpdated;
        private EventItem _event;
        public UpdateEventForm(EventItem eventItem)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var eventRepository = new EventRepository(context);
            var eventService = new EventService(eventRepository);
            _eventController = new EventController(eventService);

            _event = eventItem;
            PopulateFormFields();
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            string description = rtxtDescription.Text;
            string status = cboStatus.Text;

            _event.EventName = eventName;
            _event.EventDescription = description;
            _event.Status = status;

            EventUpdated?.Invoke(_event);
            this.Close();
        }

        private void PopulateFormFields()
        {
            
                
                txtEventName.Text = _event.EventName;
                rtxtDescription.Text = _event.EventDescription;
                cboStatus.Text = _event.Status;
                
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

