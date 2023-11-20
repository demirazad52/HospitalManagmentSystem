using System;
using System.Collections.Generic;

namespace HospitalManagmentSystem
{
  

    public class Hospital
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public Hospital(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void ScheduleAppointment(Doctor doctor, Patient patient)
        {
            var appointment = new Appointment(
                Guid.NewGuid().ToString(),
                DateTime.Now,
                doctor,
                patient
            );
            Appointments.Add(appointment);
        }

        public void ViewAppointments()
        {
            foreach (var appointment in Appointments)
            {
                appointment.GetDetails();
            }
        }
    }

}

