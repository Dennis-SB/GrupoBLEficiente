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
    public class JobTitleController : ControllerBase
    {
        private IJobTitleDAL entityDAL;

        private JobTitleModel Convert(JobTitle entity)
        {
            return new JobTitleModel
            {
                IdJobTitle = entity.IdJobTitle,
                Name = entity.Name,
                Description = entity.Description
            };
        }

        private JobTitle Convert(JobTitleModel entity)
        {
            return new JobTitle
            {
                IdJobTitle = entity.IdJobTitle,
                Name = entity.Name,
                Description = entity.Description
            };
        }

        #region Builders
        public JobTitleController()
        {
            entityDAL = new JobTitleDALImpl();
        }
        #endregion

        #region Gets
        // GET: api/<Controller>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<JobTitle> entities = entityDAL.GetAll();
            List<JobTitleModel> models = new List<JobTitleModel>();
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
            JobTitle entity = entityDAL.Get(id);
            return new JsonResult(Convert(entity));
        }
        #endregion

        #region Add
        // POST api/<Controller>
        [HttpPost]
        public JsonResult Post([FromBody] JobTitleModel entity)
        {
            entityDAL.Add(Convert(entity));
            return new JsonResult(entity);
        }
        #endregion

        #region Update
        // PUT api/<Controller>/5
        [HttpPut]
        public JsonResult Put([FromBody] JobTitleModel entity)
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
            JobTitle entity = new JobTitle
            {
                IdJobTitle = id
            };
            entityDAL.Remove(entity);
        }
        #endregion
    }
}