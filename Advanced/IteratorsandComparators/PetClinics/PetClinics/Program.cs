using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            int numberOfComand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComand; i++)
            {
                string[] comand = Console.ReadLine()
                    .Split(" ");

                string toDo = comand[0];

                if (toDo == "Create")
                {
                    if (comand[1] == "Pet")
                    {
                        string name = comand[2];
                        int age = int.Parse(comand[3]);
                        string kind = comand[4];

                        Pet pet = new Pet(name, age, kind);

                        pets.Add(pet);
                    }

                    else if (comand[1] == "Clinic")
                    {
                        string name = comand[2];
                        int roomsCount = int.Parse(comand[3]);
                        Clinic clinic = null;

                        try
                        {
                            clinic = new Clinic(name, roomsCount);
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                            continue;
                        }

                        clinics.Add(clinic);
                        continue;
                    }
                }

                else if (comand[0] == "Add")
                {
                    string petName = comand[1];
                    string clinic = comand[2];

                    if (clinics.Any(x => x.ClinicName == clinic))
                    {
                        var clinicToAdd = clinics.FirstOrDefault(x =>
                        x.ClinicName == clinic);
                        var petToAdd = pets.FirstOrDefault(x => x.Name == petName);

                        Console.WriteLine(clinicToAdd.AddPet(petToAdd));
                    }
                    //TODO: Check if the value is not null;
                }

                else if (comand[0] == "Release")
                {
                    string clinicName = comand[1];

                    var clinic = clinics.FirstOrDefault(x => x.ClinicName == clinicName);

                    Console.WriteLine(clinic?.Release());
                }

                else if (comand[0] == "HasEmptyRooms")
                {
                    string clinicName = comand[1];
                    var clinic = clinics.FirstOrDefault(x => x.ClinicName == clinicName);

                    if (clinic != null)
                    {
                        Console.WriteLine(clinic.HasEmptyRooms());
                        // Console.WriteLine(clinic?.HasEmptyRooms());
                    }
                }

                else if (comand[0] == "Print")
                {
                    if (comand.Length == 2)
                    {
                        string currenrtClinicName = comand[1];
                        var clinic = clinics.FirstOrDefault(x => x.ClinicName == currenrtClinicName);

                        clinic.Print();
                    }

                    else
                    {
                        string clinicName = comand[1];
                        int room = int.Parse(comand[2]);

                        var clinic = clinics.FirstOrDefault(x => x.ClinicName == clinicName);

                        clinic.Print(room);
                    }
                }
            }
        }
    }
}
