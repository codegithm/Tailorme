using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Domain.Enums;

namespace TailorMe.Domain.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pasword { get; set; }
        public UserType UserType { get; set; }
    }
}
