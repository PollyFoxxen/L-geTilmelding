using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LægeTilmelding.Enum;

namespace LægeTilmelding.Models
{
    public class Patient
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public List<Doctor> AssignedDoctors { get; }

        public Patient()
        {
            AssignedDoctors = new();
        }

        public Patient(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            AssignedDoctors = new List<Doctor>();
        }

        public void AssignDoctor(Doctor doctor)
        {
            if (CheckCombination(doctor.Specialty))
            {
                throw new Exception("Invalid doctor combination");
            }

            if (doctor.PatientsAssigned >= 3)
            {
                throw new Exception("Doctor already assigned to 3 patients");
            }

            AssignedDoctors.Add(doctor);
            doctor.PatientsAssigned++;
        }

        private bool CheckCombination(Speciality newSpecialty)
        {
            foreach (var assignedDoctor in AssignedDoctors)
            {
                if ((assignedDoctor.Specialty is Speciality.Kirurgi or Speciality.Onkologi) &&
                    (newSpecialty is Speciality.Kirurgi or Speciality.Onkologi))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Navn: {FirstName} {LastName}"; 
        }
    }
}
