using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Metrics;



namespace Contact_Manager
{
    public class User
    {
        object user1;
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        private DateTime addedDate;
        public User()
        {
            addedDate = DateTime.Now;
        }
        string[] address = { "mansoura", "cairo", "alexandria", "mahalla" };
        int[] phone = { 01123, 32342, 67564, 86534 };
        string[] email = { "a@gmail.com", "b@gmail.com", "c@gmail.com", "d@gmail.com" };
    }
}
