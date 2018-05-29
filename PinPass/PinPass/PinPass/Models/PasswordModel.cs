using System;
using System.Collections.Generic;
using System.Text;

namespace PinPass.Models
{
    public class PasswordModel : IListable
    {
        public string Name { get ; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
