using Accepted.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Models
{
    public class MatchOdd : BaseEntity
    {
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }
        public string Specifier { get; set; }
        public double Odd { get; set; }
     

        public MatchOdd():base()
        {

        }

        public MatchOdd(MatchOddDTO matchOddDTO)
        {
            this.MatchId = matchOddDTO.MatchId;
            this.Odd = matchOddDTO.Odd;
            this.Specifier = matchOddDTO.Specifier;
                
        }
    }
}
