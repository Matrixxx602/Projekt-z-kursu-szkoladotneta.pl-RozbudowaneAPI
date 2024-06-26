﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieManagement.Application.Common.Interfaces;
using System;

namespace MovieManagement.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MovieDatabase")));

            services.AddScoped<IMovieDbContext, MovieDbContext>();

            return services;
        }
    }
}
