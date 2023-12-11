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
            try
            {
                var patient = dc.Patients.Where(patient => patient.PatientID == patientId).FirstOrDefault();

                if (patient != null)
                {
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                    Console.WriteLine("Patient Deleted");
                    return;
                }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Patient> GetAllPatients(Context dc, Patient patient)
        {
            var list = dc.Patients.ToList();
        }

        public Patient GetPatientById(int id, Context dc)
        {
            var patient = dc.Patients.ToList().Find(patient => patient.PatientID == id) ?? null;
        }
    }
}
