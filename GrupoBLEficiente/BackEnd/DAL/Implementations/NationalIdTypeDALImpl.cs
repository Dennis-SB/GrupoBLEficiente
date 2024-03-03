using BackEnd.DAL.interfaces;
using BackEnd.Data;
using Entities.Entities;
using System.Linq.Expressions;

namespace BackEnd.DAL.Implementations
{
    public class NationalIdTypeDALImpl : INationalIdTypeDAL
    {
        private WorkUnit<NationalIdType> workunit;

        public bool Add(NationalIdType entity)
        {
            try
            {
                using (workunit = new WorkUnit<NationalIdType>(new GrupoBLContext()))
                {
                    workunit.genericDAL.Add(entity);
                    workunit.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AddRange(IEnumerable<NationalIdType> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NationalIdType> Find(Expression<Func<NationalIdType, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public NationalIdType Get(int id)
        {
            NationalIdType entity = null;
            using (workunit = new WorkUnit<NationalIdType>(new GrupoBLContext()))
            {
                entity = workunit.genericDAL.Get(id);
            }
            return entity;
        }

        public IEnumerable<NationalIdType> GetAll()
        {
            IEnumerable<NationalIdType> entities = null;
            using (workunit = new WorkUnit<NationalIdType>(new GrupoBLContext()))
            {
                entities = workunit.genericDAL.GetAll();
            }
            return entities;
        }

        public bool Remove(NationalIdType entity)
        {
            try
            {
                using (workunit = new WorkUnit<NationalIdType>(new GrupoBLContext()))
                {
                    workunit.genericDAL.Remove(entity);
                    workunit.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void RemoveRange(IEnumerable<NationalIdType> entities)
        {
            throw new NotImplementedException();
        }

        public NationalIdType SingleOrDefault(Expression<Func<NationalIdType, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(NationalIdType entity)
        {
            try
            {
                using (workunit = new WorkUnit<NationalIdType>(new GrupoBLContext()))
                {
                    workunit.genericDAL.Update(entity);
                    workunit.Complete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}