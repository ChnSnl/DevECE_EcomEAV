using Project.BLL.DesingPatterns.GenericRepository.IntRep;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        //todo : baserepository metotları yazılacak
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public void Destroy(T item)
        {
            throw new NotImplementedException();
        }

        public void DestroyRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetDatas(int count)
        {
            throw new NotImplementedException();
        }

        public List<T> GetDeleteds()
        {
            throw new NotImplementedException();
        }

        public List<T> GetFirstDatas(int count)
        {
            throw new NotImplementedException();
        }

        public List<T> GetLastDatas(int count)
        {
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            throw new NotImplementedException();
        }

        public List<MyModel> SelectVia<MyModel>(Expression<Func<T, MyModel>> exp) where MyModel : class
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
