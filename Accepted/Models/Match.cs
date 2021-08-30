using Accepted.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Models
{
    public class Match : BaseEntity
    {
        public string Description { get; set; }
        public DateTime MatchDate { get; set; }

        public TimeSpan MachTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public SportType Sport { get; set; }

        public ICollection<MatchOdds> MatchOdds { get; set; }

        public Match(): base()
        {

        }
        public Match(CreateMatchCommand data) : base()
        {
            this.Description = data.Description;
            this.MachTime = data.MachTime;
            this.MatchDate = data.MatchDate;
            this.TeamA = data.TeamA;
            this.TeamB = data.TeamB;
           
        }

        public void UpdateData(Match data)
        {
            this.Description = data.Description;
            this.MachTime = data.MachTime;
            this.MatchDate = data.MatchDate;
            this.TeamA = data.TeamA;
            this.TeamB = data.TeamB;
            this.SetUpdatedDate();


        }

      
    }
}
