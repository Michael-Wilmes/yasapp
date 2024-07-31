﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yasapp.Domain.Entities.Masterdata;
using yasapp.Infrastructure.Data;
using yasapp.Infrastructure.Interfaces;

namespace yasapp.Infrastructure.Repositories
{
    public class ExaminationRepository<T>(YasappDbContext _context) : IExaminationRepository<T> where T : class 
    {
        
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}