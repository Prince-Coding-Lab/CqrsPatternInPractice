using CqrsPatternInPractice.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CqrsPatternInPractice.Common.Context.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : BaseEntity
    {
        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
