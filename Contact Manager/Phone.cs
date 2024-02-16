using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    public class Phone
    {
        public int phone { get; set; }
        public int type { get; set; }
        public string description { get; set; }
        public void setPhone(int newPhone)
        {
            this.phone = newPhone;
        }
        public void setType(int newType)
        {
            this.type = newType;
        }
        public void setDescription(string newDescription)
        {
            this.description = newDescription;
        }
        public void getPhone()
        {
            Console.WriteLine($"Full Phone Number is: {setPhone} {setType} {setDescription}");
        }


    }
}
