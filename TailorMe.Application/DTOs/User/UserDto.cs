using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Domain.Enums;

namespace TailorMe.Application.DTOs.User
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Pasword { get; set; }
        public UserType UserType { get; set; }
    }
}
