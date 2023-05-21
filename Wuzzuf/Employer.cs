using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuzzuf
{
    internal class Employer
    {
        public int ID;
        public String
            companyName, 
            email,
            password,
            contact,
            address;

        public Employer(int ID, String companyName, String email, String password, String contact, String address)
        {
            this.ID = ID;
            this.companyName = companyName;
            this.email = email;
            this.password = password;
            this.contact = contact;
            this.address = address;
        }

        public Employer() {
            this.ID=0;
            this.companyName=null;
            this.email=null;
            this.password=null;
            this.contact=null;
            this.address=null;
        }

        public String InsertQueryText()
        {
            return ("insert into Employees value(" + this.ID + ", " + this.companyName + ", " + this.email + ", "  + this.password + ", " + this.contact + "," + this.address + ");");
        }

    }
}
