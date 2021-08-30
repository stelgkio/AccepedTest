using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Models
{
    public class MatchOdds : BaseEntity
    {
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }
        public string Specifier { get; set; }
        public double Odd { get; set; }
        public MatchOdds():base()
        {

        }
    }
}
