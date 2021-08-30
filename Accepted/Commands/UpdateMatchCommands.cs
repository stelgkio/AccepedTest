using Accepted.Models;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Commands
{
    public class UpdateMatchCommands : IRequest<Match>
    {

        public int Id{ get; set; }
        public string Description { get; set; }
        public DateTime MatchDate { get; set; }
        public TimeSpan MachTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public SportType Sport { get; set; }

        public UpdateMatchCommands(Match data)
        {
            this.Id = data.Id;
            this.MachTime = data.MachTime;
            this.MatchDate = data.MatchDate;
            this.Sport = data.Sport;
            this.TeamA = data.TeamA;
            this.TeamB = data.TeamB;
            this.Description = data.Description;

        }

    }

    public class UpdateMatchCommandValidator : AbstractValidator<UpdateMatchCommands>
    {
        public UpdateMatchCommandValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.MatchDate).NotEmpty();
            RuleFor(x => x.MachTime).NotEmpty().NotNull();
            RuleFor(x => x.TeamA).NotEmpty();
            RuleFor(x => x.TeamB).NotEmpty();
            RuleFor(x => x.Sport).NotNull().NotEmpty().IsInEnum().WithMessage("Sport can only be Football, or BasketBall");

        }
    }
}
