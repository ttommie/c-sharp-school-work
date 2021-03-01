using System;

/*
 * Programmer: Tommie
 * Date: 03/01/2021
 * Desc: Instantiable Class
 * Data Members: Name | Type | Direction | Surface | # of Lanes | Toll | Party |
 */


namespace ATHCh04_MotorwayApp
{
    class Motorway
    {
        //INSTANCE VARIABLES 
        private string nameOfMotorway,
            typeOfMotorway,
            surface,
            mntceParty,
            direction;
        private int numberOfLanes;
        private bool toll;

        //DEFAULT CONSTRUCTOR 
        public Motorway()
        {

        }

        //MOST COMMON CONSTRUCTOR 
        public Motorway(string mwName, string mwType, string mwSurface, int mwNbrLanes, string mwMntceParty)
        {
            nameOfMotorway = mwName;
            typeOfMotorway = mwType;
            surface = mwSurface;
            numberOfLanes = mwNbrLanes;
            mntceParty = mwMntceParty;
        }

        //ALL VARIABLE CONSTRUCTOR 
        public Motorway(string mwName, string mwType, string mwSurface, int mwNbrLanes,bool mwToll, string mwMntceParty)
        {
            nameOfMotorway = mwName;
            typeOfMotorway = mwType;
            surface = mwSurface;
            numberOfLanes = mwNbrLanes;
            toll = mwToll;
            mntceParty = mwMntceParty;
        }

        //PROPERTIES 
        public string NameOfMotorway
        {
            get
            {
                return nameOfMotorway;
            }
            set
            {
                nameOfMotorway = value;
            }
        }

        public string TypeOfMotorway
        {
            get
            {
                return typeOfMotorway;
            }
            set
            {
                typeOfMotorway = value;
            }
        }

        public string Surface
        {
            get
            {
                return surface;
            }
            set
            {
                surface = value;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }

        public int NumberOfLanes
        {
            get
            {
                return numberOfLanes;
            }
            set
            {
                numberOfLanes = value;
            }
        }

        public bool Toll
        {
            get
            {
                return toll;
            }
            set
            {
                toll = value;
            }
        }

        public string MntceParty
        {
            get
            {
                return mntceParty;
            }
            set
            {
                mntceParty = value;
            }
        }

        //INSTANCE METHODS 
        public string GetFullName()
        {
            return "Name of Motorway: " + nameOfMotorway + " " + typeOfMotorway + " " + direction;
        }

        public string GetTollInformation()
        {
            return GetFullName() + "\n" + "Toll: " + toll;
        }
        public string GetLaneInformation()
        {
            return GetFullName() + "\n" + "Number of Lanes: " + numberOfLanes;
        }

        //INSTANCE METHOD INHERITED FROM OBJECT
        public override string ToString()
        {
            return GetFullName() +
                "\nToll: " + toll +
                "\nNumber of Lanes: " + numberOfLanes +
                "\nType of Surface: " + surface +
                "\nMaintained by: " + mntceParty;
        }
    }
}
 