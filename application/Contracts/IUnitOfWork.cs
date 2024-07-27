﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasapp.Application.Contracts
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}