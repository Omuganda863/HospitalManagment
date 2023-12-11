using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Room
    {
        public int RoomID { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }

        public ICollection<Patient>? Patients { get; set; }
    }
}
