using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student : Course
    {
        private string   _firstname;
        private string   _lastname;
        private DateTime _dateofbirth;
        private double   _tuitionfees;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value.ToUpper(); }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        }

        public DateTime DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value; }
        }

        public double TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; }
        }

        public override string ToString()      
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of Birth: {_dateofbirth}\tTuition fees: {_tuitionfees}");
        }
    }

    
}
