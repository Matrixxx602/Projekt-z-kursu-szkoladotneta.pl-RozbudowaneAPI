using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieManagement.Application.Directors.Queries.GetDirectorDetail
{
    public class GetDirectorDetailQueryHandler : IRequestHandler<GetDirectorDetailQuery, DirectorDetailVm>
    {
        private readonly IMovieDbContext _context;

        public GetDirectorDetailQueryHandler(IMovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        public async Task<DirectorDetailVm> Handle(GetDirectorDetailQuery request, CancellationToken cancellationToken)
        {
            var director = await _context.Directors.Where(p => p.Id == request.DirectorId).FirstOrDefaultAsync(cancellationToken);

            var directorVm = new DirectorDetailVm()
            {
                FullName = director.DirectorName.ToString(),
                LastMovieName = director.Movies.OrderByDescending(p => p.PremiereYear).FirstOrDefault().Name
            };
            
            return directorVm;
        }
    }
}
