using BackEnd.DAL.interfaces;
using BackEnd.Data;
using Entities.Entities;
using System.Linq.Expressions;

namespace BackEnd.DAL.Implementations
{
    public class JobTitleDALImpl : IJobTitleDAL
    {
        private WorkUnit<JobTitle> workunit;

        public bool Add(JobTitle entity)
        {
            try
            {
                using (workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
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

        public void AddRange(IEnumerable<JobTitle> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobTitle> Find(Expression<Func<JobTitle, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public JobTitle Get(int id)
        {
            JobTitle entity = null;
            using (workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
            {
                entity = workunit.genericDAL.Get(id);
            }
            return entity;
        }

        public IEnumerable<JobTitle> GetAll()
        {
            IEnumerable<JobTitle> entities = null;
            using (workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
            {
                entities = workunit.genericDAL.GetAll();
            }
            return entities;
        }

        public bool Remove(JobTitle entity)
        {
            try
            {
                using (workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
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

        public void RemoveRange(IEnumerable<JobTitle> entities)
        {
            throw new NotImplementedException();
        }

        public JobTitle SingleOrDefault(Expression<Func<JobTitle, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(JobTitle entity)
        {
            try
            {
                using (workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
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