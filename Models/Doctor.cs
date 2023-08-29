using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LægeTilmelding.Enum;

namespace LægeTilmelding.Models
{
    public class Doctor
    {
        public string Name { get; }
        public Speciality Specialty { get; }
        public string Phone { get; }
        public int PatientsAssigned { get; set; }

        public Doctor(string name, Speciality specialty, string phone)
        {
            Name = name;
            Specialty = specialty;
            Phone = phone;
            PatientsAssigned = 0;
        }
    }
}
