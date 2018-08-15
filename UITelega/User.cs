using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace UITelega
{
    public class User
    {
        public string Name { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Avatar { get; set; }
        public string DateVisit { get; set; }
        public string Username { get; set; }

        public User() {}
    }
}
