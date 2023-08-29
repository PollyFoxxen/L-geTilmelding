using LægeTilmelding.Enum;
using LægeTilmelding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LægeTilmelding
{
    public class ClinicApp
    {
        private List<Doctor> doctors;
        public List<Patient> patients { get; set; }

        public ClinicApp()
        {
            doctors = new List<Doctor>
        {
            new Doctor("Peter Hansen", Speciality.Øjenlæge, "11111111"),
            new Doctor("Martin Jensen", Speciality.Radiologi, "22222222"),
            new Doctor("Thomas Olsen", Speciality.Kirurgi, "33333333"),
            new Doctor("Ole Nielsen", Speciality.Onkologi, "44444444")
        };
            patients = new List<Patient>();
        }

        public Patient RegisterPatient()
        {
            Console.Clear();
            var newPatient = new Patient();
            Console.Write("Fornavn: ");
            newPatient.FirstName = Console.ReadLine() ?? "";
            Console.Write("Efternavn: ");
            newPatient.LastName = Console.ReadLine() ?? "";
            Console.Write("Telefonnummer: ");
            newPatient.Phone = Console.ReadLine() ?? "";
            return newPatient;
        }

        public void ListAllPatients()
        {
            Console.Clear();
            foreach (var pat in patients)
            {
                Console.WriteLine(pat);
            }
            Console.ReadLine();
        }

        //public void RegisterPatient(string firstName, string lastName, string phone, string doctorName)
        //{
        //    var doctor = doctors.Find(doc => doc.Name == doctorName);
        //    if (doctor == null)
        //    {
        //        throw new Exception("Doctor not found");
        //    }

        //    var patient = new Patient(firstName, lastName, phone);
        //    patient.AssignDoctor(doctor);
        //    patients.Add(patient);
        //}
    }
}
