﻿using MediatR;
using MovieManagement.Application.Common.Interfaces;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieManagement.Application.Directors.Command.CreateDirector
{
    public class CreateDirectorCommandHandler : IRequestHandler<CreateDirectorCommand, int>
    {
        private readonly IMovieDbContext _context;

        public CreateDirectorCommandHandler(IMovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        public async Task<int> Handle(CreateDirectorCommand request, CancellationToken cancellationToken)
        {
            var director = new Director()
            {
                DirectorName = new Domain.ValueObjects.PersonName()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName
                }
            };

            _context.Directors.Add(director);

            var directorBiography = new DirectorBiography()
            {
                DoB = request.DoB,
                PlaceOfBirth = request.PlaceOfBirth,
                DirectorId = director.Id
            };

            _context.DirectorBiographies.Add(directorBiography);

            await _context.SaveChangesAsync(cancellationToken);

            return director.Id;
        }
        
    }
}
