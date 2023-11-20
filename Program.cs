using System;
using System.Collections.Generic;

namespace HospitalManagmentSystem
{


    public class Program
    {
        private static Hospital hospital = new Hospital("General Hospital", "Istanbul Taksim 345.St");

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hospital Management System\\n");

            bool running = true;
            while (running)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Schedule Appointment");
                Console.WriteLine("4. View Doctor Details");
                Console.WriteLine("5. View Appointment Details");
                Console.WriteLine("6. Exit");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddNewDoctor();
                        break;
                    case "2":
                        AddNewPatient();
                        break;
                    case "3":
                        CreateNewAppointment();
                        break;
                    case "4":
                        ViewDoctorDetails();
                        break;
                    case "5":
                        ViewAppointmentDetails();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }




        private static void AddNewDoctor()
        {
            Console.Write("Enter doctor's ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter doctor's full name: ");
            string name = Console.ReadLine();
            Console.Write("Enter doctor's gender (M/F): ");
            char gender = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter doctor's date of birth: ");
            DateTime dob = DateTime.Parse(Console.ReadLine()); // Corrected line
            Console.Write("Enter doctor's specialization: ");
            string specialization = Console.ReadLine();

            Doctor doctor = new Doctor(id, name, gender, dob, specialization);
            hospital.AddDoctor(doctor);
            Console.WriteLine("Doctor added successfully!");
        }

        private static void AddNewPatient()
        {
            Console.Write("Enter patient's ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter patient's full name: ");
            string name = Console.ReadLine();
            Console.Write("Enter patient's gender (M/F): ");
            char gender = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter patient's date of birth: ");
            DateTime dob = DateTime.Parse(Console.ReadLine()); // Corrected line
            Console.Write("Enter patient's medical history: ");
            string medicalHistory = Console.ReadLine();

            Patient patient = new Patient(id, name, gender, dob, medicalHistory);
            hospital.AddPatient(patient);
            Console.WriteLine("Patient added successfully!");
        }


        private static void CreateNewAppointment()
        {
            Console.WriteLine("Select a doctor by ID:");
            foreach (Doctor doctor in hospital.Doctors)
            {
                Console.WriteLine($"ID: {doctor.Id}, Name: {doctor.FullName}");
            }
            string doctorId = Console.ReadLine();
            Doctor selectedDoctor = hospital.Doctors.FirstOrDefault(d => d.Id == doctorId);

            Console.WriteLine("Select a patient by ID:");
            foreach (Patient patient in hospital.Patients)
            {
                Console.WriteLine($"ID: {patient.Id}, Name: {patient.FullName}");
            }
            string patientId = Console.ReadLine();
            Patient selectedPatient = hospital.Patients.FirstOrDefault(p => p.Id == patientId);

            hospital.ScheduleAppointment(selectedDoctor, selectedPatient);
            Console.WriteLine("Appointment scheduled successfully!");
        }

        private static void ViewDoctorDetails()
        {
            Console.Write("Enter the doctor's ID to view details: ");
            string id = Console.ReadLine();
            Doctor doctor = hospital.Doctors.FirstOrDefault(d => d.Id == id);
            if (doctor != null)
            {
                doctor.ShowDoctorInfo();
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        private static void ViewAppointmentDetails()
        {
            Console.Write("Enter the appointment's ID to view details: ");
            string id = Console.ReadLine();
            Appointment appointment = hospital.Appointments.FirstOrDefault(a => a.Id == id);
            if (appointment != null)
            {
                appointment.GetDetails();
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }


    }
}



