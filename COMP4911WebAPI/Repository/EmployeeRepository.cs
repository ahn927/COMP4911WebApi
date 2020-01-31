﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class EmployeeRepository : IDataRepository<Employee>
    {
        private readonly ApplicationDbContext _employeeContext;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this._employeeContext = context;
        }

        public async Task Add(Employee entity)
        {
            if (_employeeContext.Employees.Any(p => p.EmployeeId == entity.EmployeeId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding...");
                _employeeContext.Employees.Add(entity);
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating...");
                Employee existingEmployee = _employeeContext.Employees.FirstOrDefault(p => p.EmployeeId == entity.EmployeeId);
                this.Update(existingEmployee, entity);
            }

            await _employeeContext.SaveChangesAsync();
            _employeeContext.Entry(entity).State = EntityState.Detached;
        }

        public async Task Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _employeeContext.Employees.ToListAsync();
        }

        public async Task Update(Employee dbEntity, Employee entity)
        {
            _employeeContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            System.Diagnostics.Debug.Write("Updated...");
        }
    }
}
