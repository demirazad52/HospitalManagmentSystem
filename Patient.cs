using System;
using System.Collections.Generic;

namespace HospitalManagmentSystem
{
    

    public class Patient : PersonalProfile
    {
        public string MedicalHistory { get; set; }

        public Patient(string id, string fullName, char gender, DateTime dateOfBirth, string medicalHistory)
            : base(id, fullName, gender, dateOfBirth)
        {
            MedicalHistory = medicalHistory;
        }

        public void ViewMedicalHistory()
        {
            Console.WriteLine("Patient: " + FullName + ", Medical History: " + MedicalHistory);
        }
    }


}

