﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class EmployeeWorkPackageAssignmentRepository : IDataRepository<EmployeeWorkPackageAssignment>
    {
        private readonly ApplicationDbContext _employeeWorkPackageAssignmentContext;

        public EmployeeWorkPackageAssignmentRepository(ApplicationDbContext context)
        {
            this._employeeWorkPackageAssignmentContext = context;
        }

        public async Task<bool> Add(EmployeeWorkPackageAssignment entity)
        {
            _employeeWorkPackageAssignmentContext.Add(entity);
            await _employeeWorkPackageAssignmentContext.SaveChangesAsync();
            _employeeWorkPackageAssignmentContext.Entry(entity).State = EntityState.Detached;

            return true;
        }

        public Task<bool> CheckIfExists(EmployeeWorkPackageAssignment entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(EmployeeWorkPackageAssignment entity)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeWorkPackageAssignment> Get(int id)
        {
            return await _employeeWorkPackageAssignmentContext.EmployeeWorkPackageAssignments.FindAsync(id);
        }

        public async Task<IEnumerable<EmployeeWorkPackageAssignment>> GetAll()
        {
            return await _employeeWorkPackageAssignmentContext.EmployeeWorkPackageAssignments.ToListAsync();
        }

        public Task<EmployeeWorkPackageAssignment> GetLastId()
        {
            throw new NotImplementedException();
        }

        public Task Update(EmployeeWorkPackageAssignment entity)
        {
            throw new NotImplementedException();
        }
    }
}