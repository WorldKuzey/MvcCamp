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
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context C =new Context();
        DbSet<T> _object;//_object T değerine karşılık gelen sınıfı tutuyor

        public List<Category> List()
        {
            throw new NotImplementedException();
        }

        public GenericRepository()
        {
            _object=C.Set<T>();
        }


        //Context sınıfından c nesnesi yarattık ve DbSet'e t paremetresi
        //gönsderdik bunu object'e bağladık ardından bir kurucu metot
        //oluşturduk

        //Constractur' neden oluşturduk?
        //T değerine karşılk gelen sınıf bulabilmek için
        


        public void Delete(T p)
        {
           _object.Remove(p);
            C.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            C.SaveChanges();
        }

        public List<T> List(T p)
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
           return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            C.SaveChanges();
        }
    }
}
