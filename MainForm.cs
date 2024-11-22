using EventManagementSystem.Controllers;
using EventManagementSystem.DAO;
using EventManagementSystem.Data;
using EventManagementSystem.Forms;
using EventManagementSystem.Models;
using EventManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace EventManagementSystem
{
    public partial class MainForm : Form
    {
        public readonly EventController _eventController;
        public MainForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var eventRepository = new EventRepository(context);
            var eventService = new EventService(eventRepository);
            _eventController = new EventController(eventService);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            var addEventForm = new AddEventForm();
            addEventForm.EventAdded += LoadEvents;
            addEventForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }
        private void LoadEvents()
        {
            var events = _eventController.GetAllEvent();
            eventPanel.Controls.Clear();
            foreach (var eventItem in events)
            {
                AddEventCard(eventItem);
            }
        }
        private void AddEventCard(EventItem eventItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.Beige,
                Margin = new Padding(30),
                Padding = new Padding(10)
            };

            // Delete Icon (Text-Based)
            var deleteIcon = new Label
            {
                Text = "✖", // Unicode character for 'X' symbol
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteEvent(eventItem);
            cardPanel.Controls.Add(deleteIcon);

            var editIcon = new Label
            {
                Text = "✏", // Unicode character for pencil
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateEvent(eventItem);
            cardPanel.Controls.Add(editIcon);

            var courseLabel = new Label
            {
                Text = $"{eventItem.EventName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(courseLabel);

            var nameLabel = new Label
            {
                Text = $"{eventItem.EventDescription}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(nameLabel);


            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(20, 55),
                AutoSize = true
            };
            
            viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
            viewDetails.LinkClicked += (sender, e) => ShowEventDetails(eventItem);
            cardPanel.Controls.Add(viewDetails);

            eventPanel.Controls.Add(cardPanel);
        }

        private void ShowEventDetails(EventItem eventItem)
        {
            MessageBox.Show(eventItem.EventName);
        }

        private void UpdateEvent(EventItem eventItem)
        {
            
            var updateEventForm = new UpdateEventForm(eventItem);
            updateEventForm.EventUpdated += (updatedEvent) =>
            {
                LoadEvents();
            };

            updateEventForm.ShowDialog();
        }

        private void DeleteEvent(EventItem eventItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {eventItem.EventName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _eventController.DeleteEvent(eventItem.Id);
                LoadEvents(); // Refresh the events list
            }
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
