using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class EmployeeHelper
    {
        ServiceRepository repository;

        public EmployeeHelper()
        {
            repository = new ServiceRepository();
        }

        #region GetAll
        public List<EmployeeViewModel> GetAll()
        {
            List<EmployeeViewModel> entities = new List<EmployeeViewModel>();
            HttpResponseMessage responseMessage = repository.GetResponse("api/Employee/");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                entities = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(content);
            }
            return entities;
        }
        #endregion

        #region GetByID
        public EmployeeViewModel GetByID(int id)
        {
            EmployeeViewModel entity = new EmployeeViewModel();
            HttpResponseMessage responseMessage = repository.GetResponse("api/Employee/" + id);
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            entity = JsonConvert.DeserializeObject<EmployeeViewModel>(content);
            return entity;
        }
        #endregion

        #region Update
        public EmployeeViewModel Edit(EmployeeViewModel entity)
        {
            HttpResponseMessage responseMessage = repository.PutResponse("api/Employee/", entity);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EmployeeViewModel entityAPI = JsonConvert.DeserializeObject<EmployeeViewModel>(content);
            return entityAPI;
        }
        #endregion

        #region Create
        public EmployeeViewModel Add(EmployeeViewModel entity)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/Employee/", entity);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EmployeeViewModel entityAPI = JsonConvert.DeserializeObject<EmployeeViewModel>(content);
            return entityAPI;
        }
        #endregion

        #region Delete
        public EmployeeViewModel Delete(int id)
        {
            EmployeeViewModel entity = new EmployeeViewModel();
            HttpResponseMessage responseMessage = repository.DeleteResponse("api/Employee/" + id);
            return entity;
        }
        #endregion
    }
}