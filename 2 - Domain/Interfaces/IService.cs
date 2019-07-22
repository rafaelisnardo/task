using FluentValidation;
using ddd.Domain.Entities;
using System.Collections.Generic;

namespace ddd.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;
        T Put<V>(T Obj) where V : AbstractValidator<T>;
        void Delete(int id);
        T Get(int id);
        IList<T> Get();
    }
}
