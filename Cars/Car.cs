using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum CarMake { BMW, Honda, Jaguar, Volvo, VW }
    internal class Car : IEquatable<Car>, IComparable<Car>
    {
        public CarMake Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

 
        public override string ToString()
        {
            return $"A {Make} {Model} of year {Year}";
        }
        
        #region  IEquatable
        public bool Equals(Car other)
        {
            if (Make == other.Make && Model == other.Model && Year == other.Year)
                return true ;

            return false ;
           //return (Make, Model, Year) == (other.Make, other.Model, other.Year);
        }

        public override bool Equals(object obj) => Equals(obj as Car);
        public override int GetHashCode() => (Make, Model, Year).GetHashCode();

        public int CompareTo(Car other)
        {
            return Make.CompareTo(other.Make);
            /*
            if (this.Year < other.Year) return -1 ;
            else if (this.Year> other.Year) return 1 ;
            else
            return 0;
            */
        }
        #endregion

        #region operator overload
        public static bool operator ==(Car c1, Car c2) => c1.Equals(c2);
        public static bool operator !=(Car c1, Car c2) => !c1.Equals(c2);
        #endregion

        public Car() { }
    }
}
