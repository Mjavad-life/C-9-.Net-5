using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar 
{
    // از نوع رکورد هسته
    public class Car : IComparable
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // Property to return the PetNameComparer.
        public static IComparer SortByPetName
        => (IComparer)new PetNameComparer();
    
    public int CarID { get; set; }

        // Is the car still operational?
        private bool _carIsDead;
        // A car has-a radio.
       // private readonly Radio _theMusicBox = new Radio();
        // Constructors.
        public Car() { }
        public Car(string name, int speed , int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }
        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            //_theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delta),
                "Speed must be greater than zero");
            }

            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    // Use the "throw" keyword to raise an exception
                    // and return to the caller.
                    throw new CarIsDeadException("you have a lead fooft"
                        , DateTime.Now ,$"{PetName} has overheated!")
                    {
                        // when define custom exception below propertoes
                        // are not used they belong to system.execption
                        // i changed the custom exception and now link
                        // is unchained
                        HelpLink = "http://www.CarsRUs.com",
                       // Data = {
                       //             {"TimeStamp",$"The car exploded at {DateTime.Now}"},
                       //             {"Cause","You have a lead foot."}
                       //         }
                    };
                }
                
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }

        // public int compareto() was defined by intelisense
        
        // this form of comapreto is designed by author
        int IComparable.CompareTo(object obj)
        {
            // return CarID.CompareTo(obj);

            // another for for implementing compare to based on int value
            // of car id
            /*if (obj is Car temp)
            {
                return this.CarID.CompareTo(temp.CarID);
            }*/
            if (obj is Car temp)
            {
                if (this.CarID > temp.CarID)
                {
                    return 1;
                }
                if (this.CarID < temp.CarID)
                {
                    return -1;
                }
                return 0;
            }
            throw new ArgumentException("Parameter is not a Car!");
        }
    }
  }

