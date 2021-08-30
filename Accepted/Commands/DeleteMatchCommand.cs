using Accepted.Models;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Commands
{
    public class DeleteMatchCommand  : IRequest<Match>
    {
     
      public int Id { get; set; }
        public DeleteMatchCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteMatchCommandValidator  : AbstractValidator<DeleteMatchCommand>
    {
        public DeleteMatchCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id must have value");
         

        }
    }
}
