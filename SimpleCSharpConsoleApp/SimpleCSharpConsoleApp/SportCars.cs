using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpConsoleApp
{
    public class SportCars : Car
    {
        public string GetPetName()
        {
            PetName = "fred";
            return PetName;
        }
    }
}