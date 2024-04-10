using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.User;

namespace TailorMe.Application.Features.Users.Requests.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public CreateUserDto UserDto { get; set; }
    }
}
