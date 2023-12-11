
namespace HospitalManagementSystem
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int RoomID { get; set; }

        public Room Room { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
