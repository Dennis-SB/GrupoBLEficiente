using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class JobTitleHelper
    {
        ServiceRepository repository;

        public JobTitleHelper()
        {
            repository = new ServiceRepository();
        }

        #region GetAll
        public List<JobTitleViewModel> GetAll()
        {
            List<JobTitleViewModel> entities = new List<JobTitleViewModel>();
            HttpResponseMessage responseMessage = repository.GetResponse("api/JobTitle/");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                entities = JsonConvert.DeserializeObject<List<JobTitleViewModel>>(content);
            }
            return entities;
        }
        #endregion

        #region GetByID
        public JobTitleViewModel GetByID(int id)
        {
            JobTitleViewModel entity = new JobTitleViewModel();
            HttpResponseMessage responseMessage = repository.GetResponse("api/JobTitle/" + id);
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            entity = JsonConvert.DeserializeObject<JobTitleViewModel>(content);
            return entity;
        }
        #endregion

        #region Update
        public JobTitleViewModel Edit(JobTitleViewModel entity)
        {
            HttpResponseMessage responseMessage = repository.PutResponse("api/JobTitle/", entity);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            JobTitleViewModel entityAPI = JsonConvert.DeserializeObject<JobTitleViewModel>(content);
            return entityAPI;
        }
        #endregion

        #region Create
        public JobTitleViewModel Add(JobTitleViewModel entity)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/JobTitle/", entity);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            JobTitleViewModel entityAPI = JsonConvert.DeserializeObject<JobTitleViewModel>(content);
            return entityAPI;
        }
        #endregion

        #region Delete
        public JobTitleViewModel Delete(int id)
        {
            JobTitleViewModel entity = new JobTitleViewModel();
            HttpResponseMessage responseMessage = repository.DeleteResponse("api/JobTitle/" + id);
            return entity;
        }
        #endregion
    }
}