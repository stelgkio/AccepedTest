﻿using Accepted.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Queries
{
    public class GetMatchByIdQuery : IRequest<Match>
    {
        public int Id { get; }
        public GetMatchByIdQuery(int id)
        {
            Id = id;
        }
    }
}
