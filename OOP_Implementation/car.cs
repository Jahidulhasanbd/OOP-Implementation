﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public sealed class car:fourWheeler
    {
        public car()
        {
            
        }
        public car(int numberOfSeats, int numberOfDoor, string stearingSystem,string modelNo,
            int yearMake,int noOfGear,int engineCapacityCC)
        {
            this.modelNo = modelNo;
            this.yearMake = yearMake;
            this.noOfGear = noOfGear;
            this.engineCapacityCC = engineCapacityCC;
            this.numberOfSeats = numberOfSeats;
            this.numberOfDoor = numberOfDoor;
            this.stearingSystem = stearingSystem;
        }

        public int numberOfSeats { get; set; }
        public int numberOfDoor { get; set; }
        public string stearingSystem { get; set; }
    }
}
