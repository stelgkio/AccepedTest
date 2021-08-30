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
    public class CreateMatchCommand  : IRequest<Match>
    {
     
        public string Description { get; set; }
      
        public DateTime MatchDate { get; set; }          
        public TimeSpan MachTime { get; set; }            
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public SportType Sport { get; set; }

    }

    public class CreateMatchCommandValidator  : AbstractValidator<CreateMatchCommand>
    {
        public CreateMatchCommandValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.MatchDate).NotEmpty();
            RuleFor(x => x.TeamA).NotEmpty();
            RuleFor(x => x.TeamB).NotEmpty();
            RuleFor(x => x.Sport).NotNull().NotEmpty().IsInEnum().WithMessage("Sport can only be Football,  or BasketBall");

        }
    }
}
