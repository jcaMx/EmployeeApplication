using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class User
    {
        string Id; 
        public string fName;
        public string lName;
        public string position; 

        public string ID
        {
            get { return ID; }
            set { ID = value; }
        }
        public string LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        public User (string id, string fName, string lName, string position)
        {
            this.Id = Id;
            this.fName = fName;
            this.lName = lName;
            this.position = position;
            
        }


    }
    
}
