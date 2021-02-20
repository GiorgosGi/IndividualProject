using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Classrooms : Student
    {
        private string _className;

        public string ClassName  
        {
            get { return (this._className); }
            set { this._className = value; }
        }

        public Classrooms(string CB12, string stream, string type)
        {

        }

    }
}
