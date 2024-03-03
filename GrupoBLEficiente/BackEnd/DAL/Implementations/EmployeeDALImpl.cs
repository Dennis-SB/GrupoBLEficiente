using BackEnd.DAL.interfaces;
using BackEnd.Data;
using Entities.Entities;
using System.Linq.Expressions;

namespace BackEnd.DAL.Implementations
{
    public class EmployeeDALImpl : IEmployeeDAL
    {
        private WorkUnit<Employee> workunit;

        public bool Add(Employee entity)
        {
            try
            {
                using (workunit = new WorkUnit<Employee>(new GrupoBLContext()))
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

        public void AddRange(IEnumerable<Employee> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Find(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            Employee entity = null;
            using (workunit = new WorkUnit<Employee>(new GrupoBLContext()))
            {
                entity = workunit.genericDAL.Get(id);
            }
            return entity;
        }

        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> entities = null;
            using (workunit = new WorkUnit<Employee>(new GrupoBLContext()))
            {
                entities = workunit.genericDAL.GetAll();
            }
            return entities;
        }

        public bool Remove(Employee entity)
        {
            try
            {
                using (workunit = new WorkUnit<Employee>(new GrupoBLContext()))
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

        public void RemoveRange(IEnumerable<Employee> entities)
        {
            throw new NotImplementedException();
        }

        public Employee SingleOrDefault(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee entity)
        {
            try
            {
                using (workunit = new WorkUnit<Employee>(new GrupoBLContext()))
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