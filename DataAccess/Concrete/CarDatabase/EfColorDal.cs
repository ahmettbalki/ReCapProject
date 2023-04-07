using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.CarDatabase
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using(CarSqlContext context = new CarSqlContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using( CarSqlContext context = new CarSqlContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using(CarSqlContext context = new CarSqlContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using(CarSqlContext contex = new CarSqlContext())
            {
                return filter == null ? contex.Set<Color>().ToList() : contex.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using(CarSqlContext contex = new CarSqlContext())
            {
                var updatedEntity = contex.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
