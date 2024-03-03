using BackEnd.DAL.interfaces;
using BackEnd.Data;
using Entities.Entities;
using System.Linq.Expressions;

namespace BackEnd.DAL.Implementations
{
    public class JobTitleDALImpl : IJobTitleDAL
    {
        private WorkUnit<JobTitle> _workunit;

        public bool Add(JobTitle entity)
        {
            try
            {
                using (_workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
                {
                    _workunit.genericDAL.Add(entity);
                    _workunit.Complete();
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
            JobTitle category = null;
            using (_workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
            {
                category = _workunit.genericDAL.Get(id);
            }
            return category;
        }

        public IEnumerable<JobTitle> GetAll()
        {
            IEnumerable<JobTitle> categories = null;
            using (_workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
            {
                categories = _workunit.genericDAL.GetAll();
            }
            return categories;
        }

        public bool Remove(JobTitle entity)
        {
            try
            {
                using (_workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
                {
                    _workunit.genericDAL.Remove(entity);
                    _workunit.Complete();
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
                using (_workunit = new WorkUnit<JobTitle>(new GrupoBLContext()))
                {
                    _workunit.genericDAL.Update(entity);
                    _workunit.Complete();
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