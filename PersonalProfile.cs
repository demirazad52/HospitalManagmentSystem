using System;
using System.Collections.Generic;

namespace HospitalManagmentSystem
{ 


    public class PersonalProfile
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PersonalProfile(string id, string fullName, char gender, DateTime dateOfBirth)
        {
            Id = id;
            FullName = fullName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        public void ChangeName(string newName)
        {
            FullName = newName;
        }
    }

}