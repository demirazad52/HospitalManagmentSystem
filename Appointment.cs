using System;
using System.Collections.Generic;

namespace HospitalManagmentSystem
{

    public class Appointment
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public Appointment(string id, DateTime date, Doctor doctor, Patient patient)
        {
            Id = id;
            Date = date;
            Doctor = doctor;
            Patient = patient;
        }

        public void GetDetails()
        {
            Console.WriteLine("Appointment ID: " + Id + ", Date: " + Date.ToShortDateString() +
                              ", Doctor: " + Doctor.FullName + ", Patient: " + Patient.FullName);
        }
    }


}

