using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Person;
using TailorMe.Application.Features.People.Requests.Queries;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.Person.Handlers.Queries
{
    public class PersonRequestHandler : IRequestHandler<PersonRequest, PersonDto>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonRequestHandler(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<PersonDto> Handle(PersonRequest request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.Get(request.Id);
            if (person == null)
                throw new Exception();


            return _mapper.Map<PersonDto>(person);
        }
    }
}
