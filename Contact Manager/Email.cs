using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contact_Manager
{
    public class Email
    {
        public string email { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public void setEmail(string newEmail)
        {
            this.email = newEmail;
        }
        public void setType(string newType)
        {
            this.type = newType;
        }
        public void setDescription(string newDescription)
        {
            this.description = newDescription;
        }
        public void getEmail()
        {
            Console.WriteLine($"Full Phone Number is: {setEmail} {setType} {setDescription}");
        }


    }
}
