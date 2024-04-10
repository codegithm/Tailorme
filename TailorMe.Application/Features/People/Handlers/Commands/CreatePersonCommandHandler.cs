using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.Features.People.Requests.Commands;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.People.Handlers.Commands
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public CreatePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
        {
           _personRepository = personRepository;
           _mapper = mapper;
        }
        public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = _mapper.Map<Domain.Entites.Person>(request.CreatePersonDto);
            var createPerson = await _personRepository.Add(person);

            return createPerson.Id;
        }
    }
}
