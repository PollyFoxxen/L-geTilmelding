using LægeTilmelding.Models;
using LægeTilmelding.Enum;
using System;
using LægeTilmelding;

class Program
{
    static void Main(string[] args)
    {
        var app = new ClinicApp();
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Hvad vil du?");
            Console.WriteLine("1. Registrer ny patient");
            Console.WriteLine("2. Liste af patienter");
            Console.WriteLine("3. Registrer ny læge");
            Console.WriteLine("4. Liste af læger");

            switch (Console.ReadLine())
            {
                case "1":
                    app.patients.Add(app.RegisterPatient());
                    break;
                case "2":
                    app.ListAllPatients();
                    break;
                case "3":
                case "4":
                default:
                    break;
            }
        }

        //try
        //{
        //    app.RegisterPatient("John", "Doe", "55555555", "Thomas Olsen");
        //    app.RegisterPatient("Jane", "Smith", "66666666", "Peter Hansen");
        //    app.RegisterPatient("Alice", "Johnson", "77777777", "Ole Nielsen");
        //    app.RegisterPatient("Bob", "Brown", "88888888", "Martin Jensen");
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("An error occurred: " + e.Message);
        //}
    }


}