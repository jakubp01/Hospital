using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Hospital.Application.Core;
using Hospital.DbContextAndBuilders.ApiDbContext;
using Hospital.Entities;
using Hospital.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Hospital.Application.Queries
{
    public class GetVisits
    {
        
        public class Query : IRequest<Result<List<VisitDto>>>
        {

        }
        
        public class Handler : IRequestHandler<Query, Result<List<VisitDto>>>
        {
            private readonly HospitalDbContext _context;
            private readonly IMapper _mapper;
            public Handler(HospitalDbContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Result<List<VisitDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var response = await _context.Visits
                    .Include(r=>r.Doctor)
                    .Include(r=>r.Patient)
                    .ToListAsync(cancellationToken: cancellationToken);
                if(response!=null)
                {
                    
                    return Result<List<VisitDto>>.Success(_mapper.Map<List<VisitDto>>(response));
                    
                }
                return Result<List<VisitDto>>.Failure("error");

            }
        }
    }
}