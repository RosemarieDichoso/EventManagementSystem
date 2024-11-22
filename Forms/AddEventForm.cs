using EventManagementSystem.Data;
using EventManagementSystem.Controllers;
using EventManagementSystem.DAO;
using EventManagementSystem.Data;
using EventManagementSystem.Services;

namespace EventManagementSystem.Forms
{
    public partial class AddEventForm : Form
    {
        private readonly EventController _eventController;
        public event Action EventAdded;
        public AddEventForm()
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

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            string description = rtxtDescription.Text;
            string status = cboStatus.Text;

            _eventController.AddEvent(eventName, description, status);
            MessageBox.Show("Added Successfully", "Information");

            //Raise the event to notify the Main Form
            EventAdded?.Invoke();
            this.Close();
        }

        private void exitAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
