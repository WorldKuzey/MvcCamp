using DataAccesLayre.Abstract;
using EntityLayer2.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayre.Concrete.Repostories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;

         //Görevleri tanımlıyoruz 
        public void Delete(Category p)
        {
           _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();//adonet karşılığı executenonquery()
        }

        public List<Category> List()
        {

            return _object.ToList();
        }

        public List<Category> List(Category p)
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }



    //   Entity frameworkte 

    // listeleme için tolist()
    // eklemek için add
    //silmek için remove 
    //bulmak için find metodu kullanılır

    }
}
