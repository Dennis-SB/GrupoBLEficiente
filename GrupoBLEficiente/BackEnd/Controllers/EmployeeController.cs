using BackEnd.DAL.Implementations;
using BackEnd.DAL.interfaces;
using BackEnd.Models;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeDAL entityDAL;

        private EmployeeModel Convert(Employee entity)
        {
            return new EmployeeModel
            {
                IdEmployee = entity.IdEmployee,
                Name = entity.Name,
                LastName = entity.LastName,
                IdType = entity.IdType,
                NationalId = entity.NationalId,
                BirthDate = entity.BirthDate,
                HireDate = entity.HireDate,
                Email = entity.Email,
                Phone = entity.Phone,
                Address = entity.Address,
                IdJobTitle = entity.IdJobTitle,
                MonthlyGrossSalary = entity.MonthlyGrossSalary,
                Status = entity.Status
            };
        }

        private Employee Convert(EmployeeModel entity)
        {
            return new Employee
            {
                IdEmployee = entity.IdEmployee,
                Name = entity.Name,
                LastName = entity.LastName,
                IdType = entity.IdType,
                NationalId = entity.NationalId,
                BirthDate = entity.BirthDate,
                HireDate = entity.HireDate,
                Email = entity.Email,
                Phone = entity.Phone,
                Address = entity.Address,
                IdJobTitle = entity.IdJobTitle,
                MonthlyGrossSalary = entity.MonthlyGrossSalary,
                Status = entity.Status
            };
        }

        #region Builders
        public EmployeeController()
        {
            entityDAL = new EmployeeDALImpl();
        }
        #endregion

        #region Gets
        // GET: api/<Controller>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Employee> entities = entityDAL.GetAll();
            List<EmployeeModel> models = new List<EmployeeModel>();
            foreach (var entity in entities)
            {
                models.Add(Convert(entity));
            }
            return new JsonResult(models);
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Employee entity = entityDAL.Get(id);
            return new JsonResult(Convert(entity));
        }
        #endregion

        #region Add
        // POST api/<Controller>
        [HttpPost]
        public JsonResult Post([FromBody] EmployeeModel entity)
        {
            entityDAL.Add(Convert(entity));
            return new JsonResult(entity);
        }
        #endregion

        #region Update
        // PUT api/<Controller>/5
        [HttpPut]
        public JsonResult Put([FromBody] EmployeeModel entity)
        {
            entityDAL.Update(Convert(entity));
            return new JsonResult(entity);
        }
        #endregion

        #region Delete
        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Employee entity = new Employee
            {
                IdEmployee = id
            };
            entityDAL.Remove(entity);
        }
        #endregion
    }
}