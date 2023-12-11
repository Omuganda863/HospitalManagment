using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services.IServices
{
   public interface IPatientServices
    {
       List<Patient> GetAllPatients(Context dc, Patient patient);
       Patient GetPatientById(int id, Context dc);
        string DeletePatientName(int id, Context dc);
        void  CreatePatient (Patient patient, Context dc);
       



    }
}
