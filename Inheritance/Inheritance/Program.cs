using System;
using System.Collections.Generic;

//-----------------------------------------------------------------
//Inheritance
//
// Name: David Zientara
// Date: 7-15-2022
// Comments: An exercise in inheritance
// Added methods per the instructions
//-----------------------------------------------------------------

namespace Inheritance
{
    class Program
    {
        public class Animal
        {
            // Declare some properties common to all animals:
            private string CommonName { get; set; }
            private string Species { get; set; }
            private bool IsMammal { get; set; }
            private bool IsPredator { get; set; }
            private int Legs { get; set; }

            // Animal
            // Constructor for Animal class
            
            public Animal()
            {
                CommonName = "Fish";
                Species = "NA";
                IsMammal = false;
                IsPredator = true;
                Legs = 0;
            }
            // SetCommonName
            // Sets the common name
            // PARAMS: commonName (String)
            // RETURNS: Nothing; CommonName changed
            public void SetCommonName (string commonName)
            {
                this.CommonName = commonName;
            }
            // SetSpecies
            // Sets the species
            // PARAMS: species (String)
            // RETURNS: Nothing; Species changed
            public void SetSpecies(string species)
            {
                this.Species = species;
            }
            // SetIsMammal
            // Sets IsMammal
            // PARAMS: ismammal (bool)
            // RETURNS: Nothing; isMammal changed
            public void SetIsMammal(bool ismammal)
            {
                this.IsMammal = ismammal;
            }
            // SetIsPredator
            // Sets IsPredator
            // PARAMS: ispredator (bool)
            // RETURNS: Nothing; IsPredator changed
            public void SetIsPredator(bool ispredator)
            {
                this.IsPredator = ispredator;
            }
            // SetLegs
            // Sets the # of legs
            // PARAMS: legs (int)
            // RETURNS: Nothing; Legs changed
            public void SetLegs (int legs)
            {
                this.Legs = legs;
            }
            // GetCommonName
            // Get the common name
            // PARAMS: None
            // RETURNS: CommonName (string)
            public string GetCommonName()
            {
                return this.CommonName;
            }
            // GetSpecies
            // Get the species
            // PARAMS: None
            // RETURNS: Species (string)
            public string GetSpecies()
            {
                return this.Species;
            }
            // GetIsMammal
            // Get IsMammal
            // PARAMS: None
            // RETURNS: IsMammal (bool)
            public bool GetIsMammal()
            {
                return this.IsMammal;
            }
            // GetIsPredator
            // Get IsPredator
            // PARAMS: None
            // RETURNS: IsPredator (bool)
            public bool GetIsPredator()
            {
                return this.IsPredator;
            }
            // GetLegs
            // Get IsLegs
            // PARAMS: None
            // RETURNS: IsPredator (bool)
            public int GetLegs()
            {
                return this.Legs;
            }

        }
        public class Bird : Animal
        {
            public string Color { get; set; }
            public bool CanFly { get; set; }
            public bool CanMigrate { get; set; }
            public string Call { get; set; }
            // Bird
            // Constructor for Bird class
            public Bird(string color, bool canFly, bool canMigrate, string call)
            {
                Color = color;
                CanFly = canFly;
                CanMigrate = canMigrate;
                Call = call;
            }
            // SetColor
            // Sets the color
            // PARAMS: color (String)
            // RETURNS: Nothing; Color changed
            public void SetColor(string color)
            {
                this.Color = color;
            }
            // SetCanFLy
            // Sets CanFly
            // PARAMS: canFLy (bool)
            // RETURNS: Nothing; CanFly changed
            public void SetCanFly(bool canFly)
            {
                this.CanFly = canFly;
            }
            // SetCanMigrate
            // Sets CanMigrate
            // PARAMS: canMigrate (bool)
            // RETURNS: Nothing; CanMigrate changed
            public void SetCanMigrate(bool canMigrate)
            {
                this.CanMigrate = canMigrate;
            }
            // SetCall
            // Sets the bird call
            // PARAMS: call (String)
            // RETURNS: Nothing; Call changed
            public void SetCall(string call)
            {
                this.Call = call;
            }
            // GetColor
            // Get the color
            // PARAMS: None
            // RETURNS: Color (string)
            public string GetColor()
            {
                return this.Color;
            }
            // GetCanFLy
            // Get CanFly
            // PARAMS: None
            // RETURNS: CanFly (bool)
            public bool GetCanFly()
            {
                return this.CanFly;
            }
            // GetCanMigrate
            // Get CamMigrate
            // PARAMS: None
            // RETURNS: CanMigrate (bool)
            public bool GetCanMigrate()
            {
                return this.CanMigrate;
            }
            // GetCall
            // Get the bird call
            // PARAMS: None
            // RETURNS: Call (string)
            public string GetCall()
            {
                return this.Call;
            }
        }
        public class Reptile: Animal
        {
            public bool HasTail { get; set; }
            public bool HasCloaca { get; set; }
            public int TimeToShedSkinInDays { get; set; }
            bool AsexualReproduction { get; set; }
            // Reptile
            // Constructor for the Reptile class
            public Reptile(bool hasTail, bool hasCloaca, int timeToShedSkinInDays, bool asexualReproduction)
            {
                HasTail = hasTail;
                HasCloaca = hasCloaca;
                TimeToShedSkinInDays = timeToShedSkinInDays;
                AsexualReproduction = asexualReproduction;
            }
            // SetHasTail
            // Sets the HasTail variable
            // PARAMS: hasTail (bool)
            // RETURNS: Nothing; HasTail changed
            public void SetHasTail (bool hasTail)
            {
                this.HasTail = hasTail;
            }
            // SetHasCloaca
            // Sets the HasCloaca variable
            // PARAMS: hasCloaca (bool)
            // RETURNS: Nothing; HasCloaca changed
            public void SetHasCloaca(bool hasCloaca)
            {
                this.HasCloaca = hasCloaca;
            }
            // SetColor
            // Sets the TimeToShedSkinInDays variable
            // PARAMS: time (int)
            // RETURNS: Nothing; TimeToShedSkinInDays changed
            public void SetTimeToShedSkinInDays(int time)
            {
                this.TimeToShedSkinInDays = time;
            }
            // SetColor
            // Sets the color
            // PARAMS: color (String)
            // RETURNS: Nothing; Color changed
            public void SetAsexualReproduction(bool repro)
            {
                this.AsexualReproduction = repro;
            }
            // GetHasTail
            // Gets HasTail
            // PARAMS: Nothing
            // RETURNS: HasTail (bool)
            public bool GetHasTail()
            {
                return this.HasTail;
            }
            // GetHasCloaca
            // Gets HasCloaca
            // PARAMS: Nothing
            // RETURNS: HasCloaca (bool)
            public bool GetHasCloaca()
            {
                return this.HasCloaca;
            }
            // GetTimeToShedSkinInDays()
            // Gets TimetoShedSkinInDays
            // PARAMS: Nothing
            // RETURNS: TimetoShedSkinInDays (int)
            public int GetTimeToShedSkinInDays()
            {
                return this.TimeToShedSkinInDays;
            }
            // GetAsexualReproduction
            // Gets AsexualReproduction
            // PARAMS: Nothing
            // RETURNS: AsexualReproduction (bool)
            
            public bool GetAsexualReproduction()
            {
                return this.AsexualReproduction;
            }

        }
        static void Main()
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            // DONE

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            //DONE

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            //DONE



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            //Set relevant parameters in Bird ctor; other parameters should use 
            //mutators:
            Bird Cardinal = new Bird("red", true, true, "whistling");
            Cardinal.SetCommonName("Northern cardinal");
            Cardinal.SetSpecies("Cardinalis cardinalis");
            Cardinal.SetIsPredator(true);
            Cardinal.SetIsMammal(false);
            Cardinal.SetLegs(2);
            //I "creatively" displayed values by using tabs:
            Console.WriteLine($"Here are some properties of the {Cardinal.GetCommonName()}:");
            Console.WriteLine($"Species:\t{Cardinal.GetSpecies()}");
            Console.WriteLine($"Is Predator?:\t{Cardinal.GetIsPredator()}");
            Console.WriteLine($"Is Mammal?:\t{Cardinal.GetIsMammal()}");
            Console.WriteLine($"Legs:\t\t{Cardinal.GetLegs()}");
            Console.WriteLine($"Color:\t\t{Cardinal.GetColor()}");
            Console.WriteLine($"Can Fly?:\t{Cardinal.GetCanFly()}");
            Console.WriteLine($"Can Migrate?\t{Cardinal.GetSpecies()}");
            Console.WriteLine($"Call:\t\t{Cardinal.GetCall()}");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            //Set relevant parameters in Reptile ctor; other parameters should use 
            //mutators:
            Reptile Frog = new Reptile(false, true, 14, false);

            Frog.SetCommonName("Garden frog");
            Frog.SetSpecies("Mantella baroni");
            Frog.SetIsPredator(true);
            Frog.SetIsMammal(false);
            Frog.SetLegs(2);
      

            Console.WriteLine($"Here are some properties of the {Frog.GetCommonName()}:");
            Console.WriteLine($"Species:\t\t{Frog.GetSpecies()}");
            Console.WriteLine($"Is Predator?:\t\t{Frog.GetIsPredator()}");
            Console.WriteLine($"Is Mammal?:\t\t{Frog.GetIsMammal()}");
            Console.WriteLine($"Legs:\t\t\t{Frog.GetLegs()}");
            Console.WriteLine($"Has Tail?:\t\t{Frog.GetHasTail()}");
            Console.WriteLine($"Has Cloaca?:\t\t{Frog.GetHasCloaca()}");
            Console.WriteLine($"Asexual Reproduction?\t{Frog.GetAsexualReproduction()}");
            Console.WriteLine($"Days to shed skin:\t{Frog.GetTimeToShedSkinInDays()}");


        }
    }
}
