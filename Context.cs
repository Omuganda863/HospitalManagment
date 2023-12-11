

using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("Server=DESKTOP-G3JN959;Database=HOSPITAL_MANAGEMENT;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Room> Room { get; set; }
    }
}
