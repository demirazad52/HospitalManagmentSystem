using System;
using System.Collections.Generic;

namespace HospitalManagmentSystem
{

    public class Doctor : PersonalProfile
    {
        public string Specialization { get; protected set; }

        public Doctor(string id, string fullName, char gender, DateTime dateOfBirth, string specialization)
            : base(id, fullName, gender, dateOfBirth)
        {
            Specialization = specialization;
        }

        public void ShowDoctorInfo()
        {
            Console.WriteLine("Doctor: " + FullName + ", Specialization: " + Specialization);
        }
    }


}

