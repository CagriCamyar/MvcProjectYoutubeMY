using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        DbSet<Category> _object;
        
             
        public void Delete(Category category)
        {
            _object.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _object.ToList();    
        }

        public void Update(Category category)
        {
            context.SaveChanges();
        }

        public void Add(Category entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
