using HospitalManagementSystem;
using HospitalManagementSystem.Services;

using Context context = new Context();

PatientService patientService = new PatientService();

Room room = new Room() { RoomNumber="1", RoomType="Ward"};

Patient patient = new Patient() { FirstName="Ian", LastName="Omuganda", Email="ian@dummy.com", Room=room}; 

patientService.CreatePatient(patient, context);


