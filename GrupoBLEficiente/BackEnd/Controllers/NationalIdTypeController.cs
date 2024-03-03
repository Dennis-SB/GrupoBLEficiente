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
    public class NationalIdTypeController : ControllerBase
    {
        private INationalIdTypeDAL entityDAL;

        private NationalIdTypeModel Convert(NationalIdType entity)
        {
            return new NationalIdTypeModel
            {
                IdType = entity.IdType,
                Name = entity.Name,
                Description = entity.Description
            };
        }

        private NationalIdType Convert(NationalIdTypeModel entity)
        {
            return new NationalIdType
            {
                IdType = entity.IdType,
                Name = entity.Name,
                Description = entity.Description
            };
        }

        #region Builders
        public NationalIdTypeController()
        {
            entityDAL = new NationalIdTypeDALImpl();
        }
        #endregion

        #region Gets
        // GET: api/<Controller>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<NationalIdType> entities = entityDAL.GetAll();
            List<NationalIdTypeModel> models = new List<NationalIdTypeModel>();
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
            NationalIdType entity = entityDAL.Get(id);
            return new JsonResult(Convert(entity));
        }
        #endregion

        #region Add
        // POST api/<Controller>
        [HttpPost]
        public JsonResult Post([FromBody] NationalIdTypeModel entity)
        {
            entityDAL.Add(Convert(entity));
            return new JsonResult(entity);
        }
        #endregion

        #region Update
        // PUT api/<Controller>/5
        [HttpPut]
        public JsonResult Put([FromBody] NationalIdTypeModel entity)
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
            NationalIdType entity = new NationalIdType
            {
                IdType = id
            };
            entityDAL.Remove(entity);
        }
        #endregion
    }
}