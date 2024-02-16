using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    public class Address 
    {
        public string place { get; set; }
        public string type { get; set; }
        public string description { get; set; }

        public void setPlace(string newPlace)
        {
            this.place = newPlace;
        }
        public void setType(string newType)
        {
            this.type = newType;
        }
        public void setDescription(string newDescription)
        {
            this.description = newDescription;
        }
        public void getAddress()
        {
            Console.WriteLine($"Full address is: {setPlace} {setType} {setDescription}");
        }

    }
}
