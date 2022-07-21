using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {

        public Reptile()
        {
            IsAlive = true;
            Age = 0;
            Limbs = 4;
            LandSeaAir = "sea";

        }
        public bool IsColdBlooded { get; set; }

        public int NumberOfTeeth { get; set; }

        public bool ShedsSkin { get; set; }

        public bool CanRegrowTail { get; set; }
    
    
    }
}
