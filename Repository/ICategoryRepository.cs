using EmpregosYoyotaAPI.Models;
using System.Collections.Generic;

namespace EmpregosYoyotaAPI.Repository
{
    public interface ICategoryRepository
    {
        void Add(Category category);

        IEnumerable<Category> GetAll();

        Category Find(long id);

        void Remove(long id);

        void Update(Category category);
    }
}