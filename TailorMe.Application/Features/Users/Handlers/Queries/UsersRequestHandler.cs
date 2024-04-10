using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.User;
using TailorMe.Application.Features.Users.Requests.Queries;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.Users.Handlers.Queries
{
    public class UsersRequestHandler : IRequestHandler<UsersRequest, List<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersRequestHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UserDto>> Handle(UsersRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll();
            if (!users.Any())
                throw new Exception();

            return _mapper.Map<List<UserDto>>(users);
        }
    }
}
