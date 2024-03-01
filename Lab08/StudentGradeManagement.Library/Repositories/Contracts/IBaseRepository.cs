﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Library.Repositories.Contracts
{
    public interface IBaseRepository<T> where T : new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetSingleAsync(dynamic query);
        Task DeleteAsync(dynamic query);
        Task UpdateAsync(T entity);
        Task<dynamic> CreateAsync(T entity);
    }

}
