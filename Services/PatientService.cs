using HospitalManagementSystem.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class PatientService : IPatientServices
    {
        public void  CreatePatient(Patient patient, Context dc)
        {
            try
            {
                dc.Patients.Add(patient);
                dc.SaveChanges();
                Console.WriteLine("patient created successfully");

            }
            catch(Exception e) {
                Console.WriteLine(e.Message);

            }
        }

        public string DeletePatientName(int id, Context dc)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAllPatients(Context dc, Patient patient)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientById(int id, Context dc)
        {
            throw new NotImplementedException();
        }
    }
}
