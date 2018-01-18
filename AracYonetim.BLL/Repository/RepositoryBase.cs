using AracYonetim.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetim.BLL.Repository
{
   public abstract class RepositoryBase<T,TId>where T:class//t bi classdan referans alınmalı
        //2 tane nesne vermek zorunda
    {//generik yapı kullan.Mesela list:dbset gibi

        protected static MyContext dbContext;//static metot
        public virtual List<T>GetAll()
        {
            try
            {
            dbContext = new MyContext();
      return  dbContext.Set<T>().ToList();//t nin yerine arac gelecek
            //set metotu burada yazılmıs dbcontexti.araclar.tolist()
            }
            catch (Exception ex)
            {
                throw ex;//hatayı geldiği gibi gönderir.web ,consol,vs...
            }
        }
        public virtual T GetById(TId id)//id ver o da bize nesneyi getirecek
        {
            try
            {
            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);
           }
            catch (Exception)
            {
                 throw;
            }
            //insert update delete kaldı
            
        }
        public virtual int insert(T entity)
        {
            try
            {
            dbContext = dbContext ?? new MyContext();
            //null sa instance al değilse almaya gerek yok alma.
            dbContext.Set<T>().Add(entity);
            return dbContext.SaveChanges();
             }
            catch (Exception)
            {
              throw;
            }

        }
        public virtual int delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                //null sa instance al değilse almaya gerek yok alma.
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {
              throw;
            }
        }
        public virtual int Update()
        {
            try
            {
            dbContext = dbContext ?? new MyContext();
            return dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public  IQueryable<T> Queryable()//sorgu yazabilmek için gerekli
            //virtual yazmaya gerek yok ezecek bişey yok
        {try
            {
                dbContext = new MyContext();
                return dbContext.Set<T>().AsQueryable();
            }
            catch (Exception)
            {
               throw;
            }
        }

        }
}
