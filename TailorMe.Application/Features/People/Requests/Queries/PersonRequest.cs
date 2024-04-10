using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Person;

namespace TailorMe.Application.Features.People.Requests.Queries
{
    public class PersonRequest : IRequest<PersonDto>
    {
        public int Id { get; set; }
    }
}
