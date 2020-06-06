using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PetClinics
{
    class Clinic
    {
        private Pet[] pets;
        private int roomsCount;
        private int midRoomIndex;

        public Clinic(string clinicName, int numberOfRooms)
        {
            if (numberOfRooms % 2 != 0)
            {
                this.ClinicName = clinicName;
                this.pets = new Pet[numberOfRooms];
                this.roomsCount = numberOfRooms;
                this.midRoomIndex = numberOfRooms / 2;
            }

            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public string ClinicName { get; set; }

        public bool AddPet(Pet pet)
        {
            //if (pets.Length == 1)
            //{
            //    if (this.pets[midRoomIndex] != null)
            //    {
            //        this.pets[0] = pet;
            //        return true;
            //    }

            //    else
            //    {
            //        return false;
            //    }
            //}

            for (int i = 0; i < this.pets.Length; i++)
            {
                if (this.pets[midRoomIndex - i] == null)
                {
                    this.pets[midRoomIndex - i] = pet;
                    return true;
                }

                if (this.pets[midRoomIndex + i] == null)
                {
                    this.pets[midRoomIndex + i] = pet;  
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            for (int i = midRoomIndex; i < this.pets.Count(); i++)
            {
                if (pets[i] != null)
                {
                    pets[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < midRoomIndex; i++)
            {
                if (pets[midRoomIndex - i] != null)
                {
                    pets[midRoomIndex - i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            if (this.pets.Any(x => x == null))
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            foreach (var pet in pets)
            {
                if (pet != null)
                {
                    Console.WriteLine(pet);
                }

                else
                {
                    Console.WriteLine("Room empty");
                }
            }
        }

        public void Print(int room)
        {
            if (this.pets[room - 1] != null)
            {
                var petToPrint = pets[room - 1];
                Console.WriteLine(petToPrint);
            }
            else
            {
                Console.WriteLine("Room empty");
            }
        }
    }
}
